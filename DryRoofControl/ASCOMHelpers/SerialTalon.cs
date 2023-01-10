using DryRoofControl.Configuration;
using DryRoofControl.Configuration;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static DryRoofControl.DryRoof.DryRoofProcess;

namespace DryRoofControl.ASCOMHelpers
{
    public class SerialTalon : Talon
    {
        public class RoofData
        {
            public bool Connected = false;
            public RoofState CurrentState = RoofState.Unknown;
            public string Version = "";
            public string Status = "";
            public string LastAction = "";
            public double PercentOpen = 0.0;
        }

        private const string CMDVERSION = "&V%#";
        private const string CMDSTATUS = "&G%#";
        private const string CMDGOTO = "&A";
        private const string CMDABORT = "&S%#";
        private const string CMDCLOSE = "&P%#";
        private const string CMDOPEN = "&O%#";

        private const int ENCODERTICKS = 72295;

        protected static SerialPort _SerialPort = null;
        protected static CheckResult _CheckResult = null;
        protected static Config _Config = null;
        protected static RoofData _RoofData = new RoofData();

        public SerialTalon(string port, CheckResult checkResult, Config config)
        {
            _CheckResult = checkResult;
            _Config = config;
            try
            {
                if (_SerialPort == null)
                {
                    _SerialPort = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
                    _SerialPort.NewLine = "#";
                    _SerialPort.Encoding = Encoding.GetEncoding("Windows-1252");
                    Connect();

                    Console.WriteLine("Serial roof controller connected");
                    _CheckResult.Log.Add(DateTime.Now + ": Serial roof controller connected");
                }

                Console.WriteLine("Serial roof get current state");
                _CheckResult.Log.Add(DateTime.Now + ": Serial roof get current state");
                State();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to roof: " + ex.Message);
                _CheckResult.Log.Add(DateTime.Now + ": Error connecting to roof: " + ex.Message);
                _CheckResult.Error = "Error connecting to roof: " + ex.Message;
            }
        }

        protected override bool Connect()
        {
            try
            {
                if (!_RoofData.Connected)
                {
                    _SerialPort.Open();
                    _RoofData.Connected = true;
                    Console.WriteLine("Serial roof controller connected");
                    _CheckResult.Log.Add(DateTime.Now + ": Serial roof controller connected");
                }
                return _RoofData.Connected;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to roof: " + ex.Message);
                _CheckResult.Log.Add(DateTime.Now + ": Error connecting to roof: " + ex.Message);
                _CheckResult.Error = "Error connecting to roof: " + ex.Message;
                return false;
            }
        }

        protected override bool Disconnect()
        {
            try
            {
                if (_RoofData.Connected)
                {
                    _SerialPort.Close();
                    _RoofData.Connected = false;
                    Console.WriteLine("Serial roof controller disconnected");
                    _CheckResult.Log.Add(DateTime.Now + ": Serial roof controller disconnected");
                }
                else
                {
                    Console.WriteLine("Serial roof controller not connected");
                    _CheckResult.Log.Add(DateTime.Now + ": Serial roof controller not connected");
                }
                return !_RoofData.Connected;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error disconnecting roof: " + ex.Message);
                _CheckResult.Log.Add(DateTime.Now + ": Error disconnecting roof: " + ex.Message);
                _CheckResult.Error = "Error disconnecting roof: " + ex.Message;
                return false;
            }
        }

        private void ParseDomeMessage(string message)
        {
            if (message.Length <= 3) return; //Empty message. Pointless
            if (message[0] != '&' || message[0] == 0) return; //Empty message. Pointless

            //_CheckResult.Log.Add(DateTime.Now + ": Parsing response: " + message);

            byte[] data = Encoding.GetEncoding("Windows-1252").GetBytes(message);

            if (data[1] == 'G')
            {
                //_CheckResult.Log.Add(DateTime.Now + ": data[2]: " + data[2]);

                int l = data[2] & 0x7F;
                int lStatus = l >> 4;
                int lLastAction = l & 0x0F;

                //_CheckResult.Log.Add(DateTime.Now + ": l: " + l);
                //_CheckResult.Log.Add(DateTime.Now + ": lStatus: " + lStatus);
                //_CheckResult.Log.Add(DateTime.Now + ": lLastAction: " + lLastAction);

                if (lStatus == 0)
                {
                    _RoofData.Status = "OPEN";
                    _RoofData.CurrentState = RoofState.Open;
                }
                else
                if (lStatus == 1)
                {
                    _RoofData.Status = "CLOSED";
                    _RoofData.CurrentState = RoofState.Closed;
                }
                else
                if (lStatus == 2)
                {
                    _RoofData.Status = "OPENING";
                    _RoofData.CurrentState = RoofState.Opening;
                }
                else
                if (lStatus == 3)
                {
                    _RoofData.Status = "CLOSING";
                    _RoofData.CurrentState = RoofState.Closing;
                }
                else
                if (lStatus == 4)
                {
                    _RoofData.Status = "ERROR";
                    _RoofData.CurrentState = RoofState.Error;
                }
                else
                {
                    _RoofData.Status = "UNKNOWN";
                    _RoofData.CurrentState = RoofState.Unknown;
                }

                if (lLastAction == 0)
                {
                    _RoofData.LastAction = "NONE";
                }
                else
                if (lLastAction == 1)
                {
                    _RoofData.LastAction = "OPEN BY USER";
                }
                else
                if (lLastAction == 2)
                {
                    _RoofData.LastAction = "CLOSE BY USER";
                }
                else
                if (lLastAction == 3)
                {
                    // Unused
                    _RoofData.LastAction = "";
                }
                else
                if (lLastAction == 4)
                {
                    _RoofData.LastAction = "GO TO BY USER";
                }
                else
                if (lLastAction == 5)
                {
                    _RoofData.LastAction = "CALIBRATE BY USER";
                }
                else
                if (lLastAction == 6)
                {
                    _RoofData.LastAction = "CLOSED DUE TO RAIN - CLOUD";
                }
                else
                if (lLastAction == 7)
                {
                    _RoofData.LastAction = "CLOSE DUE TO POWER DOWN";
                }
                else
                if (lLastAction == 8)
                {
                    _RoofData.LastAction = "CLOSE DUE TO COMMUNICATION LOST";
                }
                else
                if (lLastAction == 9)
                {
                    _RoofData.LastAction = "CLOSE DUE TO INTERNET LOST";
                }
                else
                if (lLastAction == 10)
                {
                    _RoofData.LastAction = "CLOSE DUE TO TIMEOUT EXPIRED";
                }
                else
                if (lLastAction == 11)
                {
                    _RoofData.LastAction = "CLOSE BY MANAGEMENT";
                }
                else
                if (lLastAction == 12)
                {
                    _RoofData.LastAction = "CLOSE BY AUTOMATION";
                }
                else
                if (lLastAction == 13)
                {
                    _RoofData.LastAction = "STOP --MOTOR STALLED";
                }
                else
                if (lLastAction == 14)
                {
                    _RoofData.LastAction = "EMERGENCY STOP";
                }
                else
                if (lLastAction == 15)
                {
                    _RoofData.LastAction = "ORDERED THE MOUNT TO PARK";
                }
                else
                {
                    _RoofData.LastAction = "UNKNOWN";
                }
                
                //Parse roof position
                int x1, x2, x3;
                int opening;
                double pcent;

                // Roof position is encoded using a custom 3 hex bytes encoding (see Talon6 documentation).
                //_CheckResult.Log.Add(DateTime.Now + ": data[3]: " + data[3]);
                x1 = (data[3] & 0x7F) << 14;
                //_CheckResult.Log.Add(DateTime.Now + ": x1: " + x1);
                //_CheckResult.Log.Add(DateTime.Now + ": data[4]: " + data[4]);
                x2 = (data[4] & 0x7F) << 7;
                //_CheckResult.Log.Add(DateTime.Now + ": x2: " + x2);
                //_CheckResult.Log.Add(DateTime.Now + ": data[5]: " + data[5]);
                x3 = data[5] & 0x7F;
                //_CheckResult.Log.Add(DateTime.Now + ": x3: " + x3);

                // The 3 bytes are packed together to store the absolute position of the roof
                opening = x1 + x2 + x3;
                //_CheckResult.Log.Add(DateTime.Now + ": opening: " + opening);
                pcent = 100 * (((double)opening) / ENCODERTICKS);
                _RoofData.PercentOpen = pcent;
                
                // We don't care about the rest of the sensors, so we don't parse them
            }
            else if (data[1] == 'V')
            {
                _RoofData.Version = message.Substring(2, 5);
            }
            else
            {
                // Unknown message
            }
        }

        private string DisplayRoofState()
        {
            string state = "";
            if (_RoofData.CurrentState == RoofState.Open) state += "Roof is open " + _RoofData.PercentOpen + "%";
            if (_RoofData.CurrentState == RoofState.Opening) state += "Roof is opening";
            if (_RoofData.CurrentState == RoofState.Closed) state += "Roof is closed";
            if (_RoofData.CurrentState == RoofState.Closing) state += "Roof is closing";
            if (_RoofData.CurrentState == RoofState.Error) state += "Roof is in error";
            if (_RoofData.CurrentState == RoofState.Unknown) state += "Roof state is unknown";
            state += "\n";
            state += "Last action was: " + _RoofData.LastAction;

            return state;
        }

        public override RoofState State()
        {
            if (Connect())
            {
                try
                {
                    Write(CMDSTATUS);

                    // Read response from command controller
                    string response = Read();
                    if (!String.IsNullOrEmpty(response))
                    {
                        ParseDomeMessage(response);
                        //_CheckResult.Log.Add(DisplayRoofState());
                    }
                    else
                    {
                        _CheckResult.Log.Add(DateTime.Now + ": No data in the buffer");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error getting roof state");
                    _CheckResult.Log.Add(DateTime.Now + ": Error getting roof state: " + ex.Message);
                    _CheckResult.Error = "Error getting roof state: " + ex.Message;
                }
            }
            else
            {
                Console.WriteLine("Roof not connected");
                _CheckResult.Log.Add(DateTime.Now + ": Roof not connected");
                _CheckResult.Error = "Roof not connected";
            }
            return _RoofData.CurrentState;
        }

        public override void Goto(double howFar)
        {
            if (howFar<0 || howFar>100)
            {
                Console.WriteLine("Opening target illegal: "+ howFar);
                _CheckResult.Log.Add(DateTime.Now + ": Opening target illegal: "+ howFar);
                _CheckResult.Error = "Opening target illegal: " + howFar;
            }
            if (Connect())
            {
                try
                {
                    _CheckResult.Log.Add(DateTime.Now + ": Opening roof to: " + howFar + "%");
                    double DoubleTicks = (howFar * ENCODERTICKS) / 100;
                    int IntTicks = (int)DoubleTicks;
                    //_CheckResult.Log.Add(DateTime.Now + ": Target position is: " + IntTicks);

                    // Convert to hex
                    string hex = IntTicks.ToString("x5").ToLower();
                    //_CheckResult.Log.Add(DateTime.Now + ": Target position in hex: " + hex);

                    //Transform to char and build command string formatted as to documentation
                    string commandString = CMDGOTO;
                    commandString += ShiftChar(hex[0]);
                    commandString += ShiftChar(hex[1]);
                    commandString += ShiftChar(hex[2]);
                    commandString += ShiftChar(hex[3]);
                    commandString += ShiftChar(hex[4]);
                    commandString += "%#";
                    Write(commandString);

                    if (howFar > 0) _RoofData.CurrentState = RoofState.Open;
                    else _RoofData.CurrentState = RoofState.Closed;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error in roof goto");
                    _CheckResult.Log.Add(DateTime.Now + ": Error in roof goto: " + ex.Message);
                    _CheckResult.Error = "Error in roof goto: " + ex.Message;
                }
            }
            else
            {
                Console.WriteLine("Roof not connected");
                _CheckResult.Log.Add(DateTime.Now + ": Roof not connected");
                _CheckResult.Error = "Roof not connected";
            }
        }

        private char ShiftChar(char shiftChar)
        {

            char shiftedChar = '0';

            switch (shiftChar)
            {
                case '\0':
                    shiftedChar = '0';
                    break;
                case 'a':
                    shiftedChar = ':';
                    break;
                case 'b':
                    shiftedChar = ';';
                    break;
                case 'c':
                    shiftedChar = '<';
                    break;
                case 'd':
                    shiftedChar = '=';
                    break;
                case 'e':
                    shiftedChar = '>';
                    break;
                case 'f':
                    shiftedChar = '?';
                    break;
                default:
                    shiftedChar = shiftChar;

                    break;
            }

            return shiftedChar;
        }

        public override void Open()
        {
            if (Connect())
            {
                Write(CMDOPEN);
            }
            else
            {
                Console.WriteLine("Roof not connected");
                _CheckResult.Log.Add(DateTime.Now + ": Roof not connected");
                _CheckResult.Error = "Roof not connected";
            }
        }

        public override void Close()
        {
            if (Connect())
            {
                Write(CMDCLOSE);
            }
            else
            {
                Console.WriteLine("Roof not connected");
                _CheckResult.Log.Add(DateTime.Now + ": Roof not connected");
                _CheckResult.Error = "Roof not connected";
            }
        }

        public override void Abort()
        {
            Write(CMDABORT);
        }

        private void Write(string message)
        {
            //_CheckResult.Log.Add(DateTime.Now + ": Sending " + message);
            _SerialPort.Write(message);
        }

        private string Read()
        {
            string message = _SerialPort.ReadLine();
            if (String.IsNullOrEmpty(message)) return null;

            //_CheckResult.Log.Add(DateTime.Now + ": Read " + message);

            return message;
        }

        public override void Dispose()
        {
            if (_SerialPort != null)
            {
                Disconnect();
                _SerialPort.Dispose();
            }
        }
    }
}
