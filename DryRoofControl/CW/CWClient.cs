using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;


namespace DryRoofControl.CW
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
        public string Error = "";
    }

    public class CWClient
    {
        public static DataItem LoadSoloData(string url)
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
                di.Error = "Couldn't load SOLO data";
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
    }
}
