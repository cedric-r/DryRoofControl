using ASCOM.DeviceInterface;
using ASCOM.DriverAccess;
using DryRoofControl.ASCOMHelpers;
using DryRoofControl.Configuration;
using DryRoofControl.CW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DryRoofControl.ASCOMHelpers.Talon;

namespace DryRoofControl.DryRoof
{
    public class DryRoofProcess
    {
        protected static Talon roof = null;

        public class CheckResult
        {
            public List<string> Log = new List<string>();
            public string Error = "";
            public DataItem WeatherData = null;
        }

        public static CheckResult Close(Config config)
        {
            CheckResult checkResult = new CheckResult();
            if (roof != null)
                if (String.IsNullOrEmpty(config.SerialPort))
                {
                    checkResult.Log.Add(DateTime.Now + ": Connecting to ASCOM roof");
                    roof = new ASCOMTalon(config.ASCOMDriver, checkResult, config);
                }
                else
                {
                    checkResult.Log.Add(DateTime.Now + ": Connecting to serial roof");
                    roof = new SerialTalon(config.SerialPort, checkResult, config);
                }
            roof.Close();
            return checkResult;
        }

        public static CheckResult CheckConditions(Config config)
        {
            CheckResult checkResult = new CheckResult();
            bool goodWeather = DryRoofProcess.GoodWeather(config, checkResult);

            if (!String.IsNullOrEmpty(config.SerialPort) && !String.IsNullOrEmpty(config.ASCOMDriver))
            {
                checkResult.Error = "Please choose either serial port or ascom driver";
                return checkResult;
            }

            /*
            if (String.IsNullOrEmpty(config.SerialPort) && config.AutoOpen)
            {
                checkResult.Error = "AutoOpen is only possible via serial port";
                return checkResult;
            }
            */

            if (String.IsNullOrEmpty(config.SerialPort))
            {
                if (!Talon.IsTalonLoaded(config))
                {
                    Console.WriteLine("Roof control process not found");
                    checkResult.Error = "Roof control process not found";
                    return checkResult;
                }
                else
                {
                    Console.WriteLine("Roof controller process found");
                    checkResult.Log.Add(DateTime.Now + ": Roof controller process found");
                }
            }

            if (String.IsNullOrEmpty(config.SerialPort))
            {
                checkResult.Log.Add(DateTime.Now + ": Connecting to ASCOM roof");
                roof = new ASCOMTalon(config.ASCOMDriver, checkResult, config);
            }
            else
            {
                checkResult.Log.Add(DateTime.Now + ": Connecting to serial roof");
                roof = new SerialTalon(config.SerialPort, checkResult, config);
            }

            bool exit = false;
            if (roof.State() != RoofState.Open)
            {
                Console.WriteLine("Roof not open.");
                checkResult.Log.Add(DateTime.Now + ": Roof not open");
                if (config.AutoOpen)
                {
                    if (DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)config.MaxHour, (int)config.MaxMinute, 0)
                        && DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)config.MinHour, (int)config.MinMinute, 0))
                    {
                        if (goodWeather)
                        {
                            Console.WriteLine("Opening time. Opening roof");
                            checkResult.Log.Add(DateTime.Now + ": Opening time. Opening roof");
                            if (config.HowFar > 0) roof.Goto(config.HowFar);
                            else roof.Open();
                            checkResult.Log.Add(DateTime.Now + ": Roof opening");
                        }
                        else
                        {
                            Console.WriteLine("Weather is bad. Not opening roof");
                            return checkResult;
                        }
                    }
                    else
                    {
                        checkResult.Log.Add(DateTime.Now + ": Time is outside opening hours");
                    }
                }
            }
            else
            {
                bool close = !goodWeather;
                if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)config.MaxHour, (int)config.MaxMinute, 0)
                    || DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)config.MinHour, (int)config.MinMinute, 0))
                {
                    Console.WriteLine("Closing time");
                    checkResult.Log.Add(DateTime.Now + ": Closing time");
                    close = true;
                }

                if (close)
                {
                    Console.WriteLine("Closing roof");
                    checkResult.Log.Add(DateTime.Now + ": Closing roof");
                    roof.Close();
                    exit = true;
                }
                else
                {
                    checkResult.Log.Add(DateTime.Now + ": All is good");
                }
            }

            if (!String.IsNullOrEmpty(checkResult.Error) && config.SafeClose)
            {
                // We had an error and the default is to close for safety
                if (roof.State() == RoofState.Open)
                {
                    Console.WriteLine("Closing roof");
                    checkResult.Log.Add(DateTime.Now + ": Closing roof");
                    roof.Close();
                }
            }

            return checkResult;
        }

        public static void Disconnect()
        {
            if (roof != null) roof.Dispose();
        }

        public static bool GoodWeather(Config config, CheckResult checkResult)
        {
            bool temp = true;

            checkResult.Log.Add(DateTime.Now + ": Loading SOLO data");
            DataItem di = CWClient.LoadSoloData(config.WeatherUrl);
            checkResult.WeatherData = di;
            if (!String.IsNullOrEmpty(di.Error)) checkResult.Error = di.Error;

            if (di.humidity < config.MinHumidity || di.humidity > config.MaxHumidity)
            {
                Console.WriteLine("Bad weather (humidity)");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (humidity)");
                temp = false;
            }
            if (di.cloud < config.MinCloud || di.cloud > config.MaxCloud)
            {
                Console.WriteLine("Bad weather (clouds)");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (clouds)");
                temp = false;
            }
            if (di.rain < config.MinRain || di.rain > config.MaxRain)
            {
                Console.WriteLine("Bad weather (rain)");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (rain)");
                temp = false;
            }
            if (di.temperature < config.MinTemperature || di.temperature > config.MaxTemperature)
            {
                Console.WriteLine("Bad weather (temperature)");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (temperature)");
                temp = false;
            }
            if (di.wind < config.MinWind || di.wind > config.MaxWind)
            {
                Console.WriteLine("Bad weather (wind)");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (wind)");
                temp = false;
            }
            if (di.gust < config.MinGust || di.gust > config.MaxGust)
            {
                Console.WriteLine("Bad weather (gust)");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (gust)");
                temp = false;
            }
            if (!di.safe && !config.IgnoreCWUnsafe)
            {
                Console.WriteLine("Bad weather (unsafe)");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (unsafe)f");
                temp = false;
            }
            return temp;
        }
    }
}
