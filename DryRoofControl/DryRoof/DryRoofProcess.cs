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

namespace DryRoofControl.DryRoof
{
    public class DryRoofProcess
    {
        public class CheckResult
        {
            public List<string> Log = new List<string>();
            public string Error = "";
            public DataItem WeatherData = null;
        }

        public static CheckResult CheckConditions(Config config)
        {
            CheckResult checkResult = new CheckResult();
            bool goodWeather = DryRoofProcess.GoodWeather(config, checkResult);

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
                Dome dome = new Dome(config.ASCOMDriver);
                dome.Connected = true;
                Console.WriteLine("ASCOM roof controller connected");
                checkResult.Log.Add(DateTime.Now + ": ASCOM roof controller connected");
                bool exit = false;
                if (dome.Connected)
                {
                    ShutterState shutterState = dome.ShutterStatus;
                    if (!shutterState.Equals(ShutterState.shutterOpen))
                    {
                        Console.WriteLine("Roof not open.");
                        checkResult.Log.Add(DateTime.Now + ": Roof not open");
                        if (config.AutoOpen)
                        {
                            if (DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)config.MaxHour, (int)config.MaxMinute, 0)
                                || DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)config.MinHour, (int)config.MinMinute, 0))
                            {
                                if (goodWeather)
                                {
                                    Console.WriteLine("Opening time. Opening roof");
                                    checkResult.Log.Add(DateTime.Now + ": Opening time. Opening roof");
                                    dome.OpenShutter();
                                }
                                else
                                {
                                    Console.WriteLine("Weather is bad. Not opening roof");
                                    checkResult.Error = DateTime.Now + ": Weather is bad. Not opening roof";
                                    return checkResult;
                                }
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
                            dome.CloseShutter();
                            exit = true;
                        }
                        else
                        {
                            checkResult.Log.Add(DateTime.Now + ": All is good");
                        }
                    }
                }

                if (!String.IsNullOrEmpty(checkResult.Error) && config.SafeClose)
                {
                    // We had an error and the default is to close for safety
                    Console.WriteLine("Closing roof");
                    checkResult.Log.Add(DateTime.Now + ": Closing roof");
                    dome.CloseShutter();
                }

                dome.Connected = false;
                checkResult.Log.Add(DateTime.Now + ": Roof disconnected");
                return checkResult;
            }
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
                Console.WriteLine("Bad weather (humidity). Closing roof");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (humidity). Closing roof");
                temp = false;
            }
            if (di.cloud < config.MinCloud || di.cloud > config.MaxCloud)
            {
                Console.WriteLine("Bad weather (clouds). Closing roof");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (clouds). Closing roof");
                temp = false;
            }
            if (di.rain < config.MinRain || di.rain > config.MaxRain)
            {
                Console.WriteLine("Bad weather (rain). Closing roof");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (rain). Closing roof");
                temp = false;
            }
            if (di.temperature < config.MinTemperature || di.temperature > config.MaxTemperature)
            {
                Console.WriteLine("Bad weather (temperature). Closing roof");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (temperature). Closing roof");
                temp = false;
            }
            if (di.wind < config.MinWind || di.wind > config.MaxWind)
            {
                Console.WriteLine("Bad weather (wind). Closing roof");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (wind). Closing roof");
                temp = false;
            }
            if (di.gust < config.MinGust || di.gust > config.MaxGust)
            {
                Console.WriteLine("Bad weather (gust). Closing roof");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (gust). Closing roof");
                temp = false;
            }
            if (!di.safe && !config.IgnoreCWUnsafe)
            {
                Console.WriteLine("Bad weather (unsafe). Closing roof");
                checkResult.Log.Add(DateTime.Now + ": Bad weather (unsafe). Closing roof");
                temp = false;
            }
            return temp;
        }
    }
}
