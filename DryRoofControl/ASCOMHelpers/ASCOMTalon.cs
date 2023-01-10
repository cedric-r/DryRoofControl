using ASCOM.DeviceInterface;
using ASCOM.DriverAccess;
using DryRoofControl.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static DryRoofControl.DryRoof.DryRoofProcess;

namespace DryRoofControl.ASCOMHelpers
{
    public class ASCOMTalon : Talon
    {
        private Dome _Dome = null;
        private CheckResult _CheckResult = null;
        private Config _Config = null;

        public ASCOMTalon(string ASCOMname, CheckResult checkResult, Config config)
        {
            _CheckResult = checkResult;
            _Config = config;
            if (_Dome == null)
            {
                try
                {
                    _Dome = new Dome(ASCOMname);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error creating roof object: " + ex.Message);
                    _CheckResult.Log.Add(DateTime.Now + ": Error creating roof object: " + ex.Message);
                    _CheckResult.Error = "Error creating roof object: " + ex.Message;
                }
            }
        }

        protected override bool Connect()
        {
            try
            {
                if (!_Dome.Connected)
                {
                    _Dome.Connected = true;
                    Console.WriteLine("ASCOM roof controller connected");
                    _CheckResult.Log.Add(DateTime.Now + ": ASCOM roof controller connected");
                }
                return true;
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
                if (_Dome.Connected)
                {
                    _Dome.Connected = false; ;
                    Console.WriteLine("ASCOM roof controller disconnected");
                    _CheckResult.Log.Add(DateTime.Now + ": ASCOM roof controller disconnected");
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error disconnecting roof: " + ex.Message);
                _CheckResult.Log.Add(DateTime.Now + ": Error disconnecting roof: " + ex.Message);
                _CheckResult.Error = "Error disconnecting roof: " + ex.Message;
                return false;
            }
        }

        public override RoofState State()
        {
            RoofState result = RoofState.Unknown;
            if (Connect())
            {
                if (_Dome.ShutterStatus == ShutterState.shutterOpen) result = RoofState.Open; else result = RoofState.Closed;
            }
            else
            {
                Console.WriteLine("Roof not connected");
                _CheckResult.Log.Add(DateTime.Now + ": Roof not connected");
                _CheckResult.Error = "Roof not connected";
            }
            return result;
        }

        public override void Goto(double howFar)
        {
            if (Connect())
            {
                _Dome.OpenShutter();
                Thread.Sleep(TimeSpan.FromSeconds(_Config.HowFar));
                Abort();
            }
            else
            {
                Console.WriteLine("Roof not connected");
                _CheckResult.Log.Add(DateTime.Now + ": Roof not connected");
                _CheckResult.Error = "Roof not connected";
            }
        }

        public override void Open()
        {
            if (Connect())
            {
                _Dome.OpenShutter();
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
                _Dome.CloseShutter();
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
            // &S#
            if (_Dome.Connected)
            {
                string result = _Dome.CommandString("&S#", true);
            }
            else
            {
                Console.WriteLine("Roof not connected");
                _CheckResult.Log.Add(DateTime.Now + ": Roof not connected");
                _CheckResult.Error = "Roof not connected";
            }
        }

        public override void Dispose()
        {
            Disconnect();
        }
    }
}
