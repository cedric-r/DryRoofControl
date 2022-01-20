using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ASCOM.DeviceInterface;
using ASCOM.DriverAccess;

namespace DryRoofControl
{
    class Program
    {
        public class DataItem
        {
            public int time;
            public double temperature;
            public double humidity;
            public double dew;
            public double pressure;
            public double cloud;
            public double rain;
            public double board;
            public double wind;
            public double gust;
            public double light;
            public bool safe;
        }

        public class Config
        {
            public string WeatherUrl = "";
            public double MaxHumidity = 100;
            public double MinHumidity = 0;
            public double MaxTemperature = 100;
            public double MinTemperature = -100;
            public double MaxCloud = 100;
            public double MinCloud = 0;
            public double MaxWind = 100;
            public double MinWind = 0;
            public double MaxRain = 100;
            public double MinRain = 0;
            public double MaxGust = 100;
            public double MinGust = 0;
            public double MaxLight = 100;
            public double MinLight = 0;
            public double MaxHour = 24;
            public double MinHour = 0;
            public double MaxMinute = 0;
            public double MinMinute = 0;
            public int ExitAfterClose = 1;
        }

        private static Config LoadConfig()
        {
            Config config = new Config();
            config.WeatherUrl = GetConfigValue("WeatherUrl", config.WeatherUrl);
            config.ExitAfterClose = int.Parse(GetConfigValue("ExitAfterClose", config.ExitAfterClose.ToString()));
            config.MaxHumidity = Double.Parse(GetConfigValue("MaxHumidity", config.MaxHumidity.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MinHumidity = Double.Parse(GetConfigValue("MinHumidity", config.MinHumidity.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MaxCloud = Double.Parse(GetConfigValue("MaxCloud", config.MaxCloud.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MinCloud = Double.Parse(GetConfigValue("MinCloud", config.MinCloud.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MaxRain = Double.Parse(GetConfigValue("MaxRain", config.MaxRain.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MinRain = Double.Parse(GetConfigValue("MinRain", config.MinRain.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MaxTemperature = Double.Parse(GetConfigValue("MaxTemperature", config.MaxTemperature.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MinTemperature = Double.Parse(GetConfigValue("MinTemperature", config.MinTemperature.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MaxWind = Double.Parse(GetConfigValue("MaxWind", config.MaxWind.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MinWind = Double.Parse(GetConfigValue("MinWind", config.MinWind.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MaxGust = Double.Parse(GetConfigValue("MaxGust", config.MaxGust.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MinGust = Double.Parse(GetConfigValue("MinGust", config.MinGust.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MaxLight = Double.Parse(GetConfigValue("MaxLight", config.MaxLight.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            config.MinLight = Double.Parse(GetConfigValue("MinLight", config.MinLight.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            string time = GetConfigValue("MaxHour", config.MaxHour.ToString()+":"+ config.MaxMinute.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            string[] timeElements = time.Split(':');
            config.MaxHour = Double.Parse(timeElements[0]);
            config.MaxMinute = Double.Parse(timeElements[1]);
            time = GetConfigValue("MinHour", config.MinHour.ToString() + ":" + config.MinMinute.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            timeElements = time.Split(':');
            config.MinHour = Double.Parse(timeElements[0]);
            config.MinMinute = Double.Parse(timeElements[1]);
            return config;
        }

        private static string GetConfigValue(string key, string defaultValue = null)
        {
            string result = defaultValue;
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            if (!String.IsNullOrEmpty(appSettings[key]))
            {
                result = appSettings[key];
            }
            return result;
        }

        private static bool IsTalonLoaded()
        {
            Process[] p = Process.GetProcessesByName("Talon6_ROR");
            if (p.Length == 0) return false;
            return true;
        }

        private static DataItem LoadSoloData(string url)
        {
            DataItem di = new DataItem();
            try
            {
                HttpClient _Client = new HttpClient();
                using (HttpResponseMessage response = _Client.GetAsync(url).Result)
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (HttpContent content = response.Content)
                        {
                            // ... Read the string.
                            string result = content.ReadAsStringAsync().Result;
                            di = Decoder(result);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Couldn't load SOLO data");
            }
            return di;
        }

        private static DataItem Decoder(string data)
        {
            DataItem di = new DataItem();
            List<string> diList = data.Split('\n').ToList();
            foreach (string line in diList)
            {
                if (line.Contains("clouds=")) di.cloud = ConvertToDouble(line.Replace("clouds=", ""));
                if (line.Contains("temp=")) di.temperature = ConvertToDouble(line.Replace("temp=", ""));
                if (line.Contains("rain=")) di.rain = ConvertToDouble(line.Replace("rain=", ""));
                if (line.Contains("wind=")) di.wind = ConvertToDouble(line.Replace("wind=", ""));
                if (line.Contains("gust=")) di.gust = ConvertToDouble(line.Replace("gust=", ""));
                if (line.Contains("light=")) di.light = ConvertToDouble(line.Replace("light=", ""));
                if (line.Contains("hum=")) di.humidity = ConvertToDouble(line.Replace("hum=", ""));
                if (line.Contains("dewp=")) di.dew = ConvertToDouble(line.Replace("dewp=", ""));
                if (line.Contains("safe=")) di.safe = (ConvertToDouble(line.Replace("safe=", "")) == 1.0);
            }

            return di;
        }

        private static double ConvertToDouble(string num)
        {
            string a = Convert.ToString(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            num = num.Replace(".", a);
            num = num.Replace(",", a);
            return Double.Parse(num);
        }

        static void Main(string[] args)
        {
            if (!IsTalonLoaded())
            {
                Console.WriteLine("Talon program not found");
            }
            else
            {
                Console.WriteLine("Talon program found");
                Dome dome = new Dome("Talon6_ROR.Dome");
                dome.Connected = true;
                Console.WriteLine("Talon connected");
                while (dome.Connected && !System.Console.KeyAvailable)
                {
                    ShutterState shutterState = dome.ShutterStatus;
                    if (!shutterState.Equals(ShutterState.shutterOpen))
                    {
                        Console.WriteLine("Roof not open");
                    }
                    else
                    {
                        Config config = LoadConfig();
                        DataItem di = LoadSoloData(config.WeatherUrl);

                        bool close = false;
                        if (di.humidity < config.MinHumidity || di.humidity > config.MaxHumidity)
                        {
                            Console.WriteLine("Bad weather (humidity). Closing roof");
                            close = true;
                        }
                        if (di.rain < config.MinRain || di.rain > config.MaxRain)
                        {
                            Console.WriteLine("Bad weather (rain). Closing roof");
                            close = true;
                        }
                        if (di.temperature < config.MinTemperature || di.temperature > config.MaxTemperature)
                        {
                            Console.WriteLine("Bad weather (temperature). Closing roof");
                            close = true;
                        }
                        if (di.wind < config.MinWind || di.wind > config.MaxWind)
                        {
                            Console.WriteLine("Bad weather (wind). Closing roof");
                            close = true;
                        }
                        if (di.gust < config.MinGust || di.gust > config.MaxGust)
                        {
                            Console.WriteLine("Bad weather (gust). Closing roof");
                            close = true;
                        }
                        if (!di.safe)
                        {
                            Console.WriteLine("Bad weather (unsafe). Closing roof");
                            close = true;
                        }
                        if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)config.MaxHour, (int)config.MaxMinute, 0)
                            || DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)config.MinHour, (int)config.MinMinute, 0))
                        {
                            Console.WriteLine("Closing time. Closing roof");
                            close = true;
                        }
                        if (close)
                        {
                            Console.WriteLine("Closing roof");
                            dome.CloseShutter();
                            if (config.ExitAfterClose == 1) System.Environment.Exit(0);
                        }
                    }
                    Console.WriteLine("Sleeping 60 seconds");
                    Thread.Sleep(60000);
                }
                dome.Connected = false;
                System.Console.ReadKey();
            }
        }
    }
}
