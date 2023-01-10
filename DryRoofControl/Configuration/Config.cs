using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DryRoofControl.Configuration
{
    public class Config
    {
        private const string FolderName = "DryRoofControl";
        private const string ConfigName = "DryRoofControl.config";
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
        public bool WaitAfterExit = false;
        public string ProcessName;
        public string ASCOMDriver;
        public bool AutoOpen = false;
        public bool IgnoreCWUnsafe = true;
        public int SleepTime = 60;
        public bool SafeClose = false;
        public string SerialPort = "";
        public double HowFar = 0;

        public void Save()
        {
            string strPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            strPath = Path.Combine(strPath, FolderName);
            if (!System.IO.Directory.Exists(strPath))
                System.IO.Directory.CreateDirectory(strPath);

            File.WriteAllText(Path.Combine(strPath, ConfigName), JsonConvert.SerializeObject(this));
        }

        public static Config Load()
        {
            Config config = null;

            try
            {
                config = LoadConfig();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Default configuration not loaded");
            }

            try
            {
                string strPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
                strPath = Path.Combine(strPath, FolderName);
                string conf = File.ReadAllText(Path.Combine(strPath, ConfigName));
                config = JsonConvert.DeserializeObject<Config>(conf);
            }
            catch(Exception e)
            {
                System.Console.WriteLine("Serialised configuration not loaded");
            }
            return config;
        }

        public void Display()
        {
            System.Console.WriteLine("Weather URL=" + WeatherUrl);
            System.Console.WriteLine("MaxHumidity=" + MaxHumidity);
            System.Console.WriteLine("MinHumidity=" + MinHumidity);
            System.Console.WriteLine("MaxCloud=" + MaxCloud);
            System.Console.WriteLine("MinCloud=" + MinCloud);
            System.Console.WriteLine("MaxRain=" + MaxRain);
            System.Console.WriteLine("MinRain=" + MinRain);
            System.Console.WriteLine("MaxTemperature=" + MaxTemperature);
            System.Console.WriteLine("MinTemperature=" + MinTemperature);
            System.Console.WriteLine("MaxWind=" + MaxWind);
            System.Console.WriteLine("MinWind=" + MinWind);
            System.Console.WriteLine("MaxGust=" + MaxGust);
            System.Console.WriteLine("MinGust=" + MinGust);
            System.Console.WriteLine("MaxLight=" + MaxLight);
            System.Console.WriteLine("MinLight=" + MinLight);
            System.Console.WriteLine("Max time=" + MaxHour + ":" + MaxMinute);
            System.Console.WriteLine("Min time=" + MinHour + ":" + MinMinute);
            System.Console.WriteLine("ProcessName=" + ProcessName);
            System.Console.WriteLine("ASCOMDriver=" + ASCOMDriver);
            System.Console.WriteLine("AutoOpen=" + AutoOpen);
            System.Console.WriteLine("IgnoreCWUnsafe=" + IgnoreCWUnsafe);
            System.Console.WriteLine("SleepTime=" + SleepTime + "s");
            System.Console.WriteLine("SafeClose=" + SafeClose);
            System.Console.WriteLine("SerialPort=" + SerialPort);
        }

        public static Config LoadConfig()
        {
            Config config = new Config();
            config.WeatherUrl = GetConfigValue("WeatherUrl", config.WeatherUrl);
            config.WaitAfterExit = Boolean.Parse(GetConfigValue("WaitAfterExit", "true"));
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
            config.IgnoreCWUnsafe = Boolean.Parse(GetConfigValue("IgnoreCWUnsafe", "false"));
            string time = GetConfigValue("MaxHour", config.MaxHour.ToString() + ":" + config.MaxMinute.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            string[] timeElements = time.Split(':');
            config.MaxHour = Double.Parse(timeElements[0]);
            config.MaxMinute = Double.Parse(timeElements[1]);
            time = GetConfigValue("MinHour", config.MinHour.ToString() + ":" + config.MinMinute.ToString()).Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            timeElements = time.Split(':');
            config.MinHour = Double.Parse(timeElements[0]);
            config.MinMinute = Double.Parse(timeElements[1]);
            config.ProcessName = GetConfigValue("ProcessName", "Talon6_ROR");
            config.ASCOMDriver = GetConfigValue("ASCOMDriver", "Talon6_ROR.Dome");
            config.AutoOpen = Boolean.Parse(GetConfigValue("AutoOpen", "true"));
            config.SleepTime = Int32.Parse(GetConfigValue("SleepTime", "60"));
            config.SafeClose = Boolean.Parse(GetConfigValue("SafeClose", "false"));
            config.SerialPort = GetConfigValue("SerialPort", "");
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
    }
}
