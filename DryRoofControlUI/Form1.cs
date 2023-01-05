using DryRoofControl.Configuration;
using DryRoofControl.DryRoof;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DryRoofControl.DryRoof.DryRoofProcess;

namespace DryRoofControlUI
{
    public partial class Form1 : Form
    {
        private Config config = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                config = Config.Load();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            this.URLtextBox.Text = config.WeatherUrl;
            this.MaxHumiditytextBox.Text = config.MaxHumidity.ToString();
            this.MinHumiditytextBox.Text = config.MinHumidity.ToString();
            this.MaxTemperaturetextBox.Text = config.MaxTemperature.ToString();
            this.MinTemperaturetextBox.Text = config.MinTemperature.ToString();
            this.MaxCloudtextBox.Text = config.MaxCloud.ToString();
            this.MinCloudtextBox.Text = config.MinCloud.ToString();
            this.MaxWindtextBox.Text = config.MaxWind.ToString();
            this.MinWindtextBox.Text = config.MinWind.ToString();
            this.MaxRaintextBox.Text = config.MaxRain.ToString();
            this.MinRaintextBox.Text = config.MinRain.ToString();
            this.MaxGusttextBox.Text = config.MaxGust.ToString();
            this.MinGusttextBox.Text = config.MinGust.ToString();
            this.MaxLighttextBox.Text = config.MaxLight.ToString();
            this.MinLighttextBox.Text = config.MinLight.ToString();
            this.StartTimetextBox.Text = String.Format("{0:00}", config.MinHour) + ":" + String.Format("{0:00}", config.MinMinute);
            this.EndTimetextBox.Text = String.Format("{0:00}", config.MaxHour) + ":" + String.Format("{0:00}", config.MaxMinute);
            this.ProcesstextBox.Text = config.ProcessName;
            this.DometextBox.Text = config.ASCOMDriver;
            this.SleepTimetextBox.Text = config.SleepTime.ToString();
            this.WaitAfterExitcheckBox.Checked = config.WaitAfterExit;
            this.AutoOpencheckBox.Checked = config.AutoOpen;
            this.IgnoreCWUnsafecheckBox.Checked = config.IgnoreCWUnsafe;
            this.SafeClosecheckBox.Checked = config.SafeClose;

            SaveButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                config.WeatherUrl = this.URLtextBox.Text;
                config.MaxHumidity = Double.Parse(this.MaxHumiditytextBox.Text);
                config.MinHumidity = Double.Parse(this.MinHumiditytextBox.Text);
                config.MaxTemperature = Double.Parse(this.MaxTemperaturetextBox.Text);
                config.MinTemperature = Double.Parse(this.MinTemperaturetextBox.Text);
                config.MaxCloud = Double.Parse(this.MaxCloudtextBox.Text);
                config.MinCloud = Double.Parse(this.MinCloudtextBox.Text);
                config.MaxWind = Double.Parse(this.MaxWindtextBox.Text);
                config.MinWind = Double.Parse(this.MinWindtextBox.Text);
                config.MaxGust = Double.Parse(this.MaxGusttextBox.Text);
                config.MinGust = Double.Parse(this.MinGusttextBox.Text);
                config.MaxRain = Double.Parse(this.MaxRaintextBox.Text);
                config.MinRain = Double.Parse(this.MinRaintextBox.Text);
                config.MaxLight = Double.Parse(this.MaxLighttextBox.Text);
                config.MinLight = Double.Parse(this.MinLighttextBox.Text);
                string[] time = StartTimetextBox.Text.Split(':');
                config.MinHour = Double.Parse(time[0]);
                config.MinMinute = Double.Parse(time[1]);
                time = EndTimetextBox.Text.Split(':');
                config.MaxHour = Double.Parse(time[0]);
                config.MaxMinute = Double.Parse(time[1]);
                config.ProcessName = this.ProcesstextBox.Text;
                config.ASCOMDriver = this.DometextBox.Text;
                config.SleepTime = Int32.Parse(this.SleepTimetextBox.Text);
                config.WaitAfterExit = this.WaitAfterExitcheckBox.Checked;
                config.AutoOpen = this.AutoOpencheckBox.Checked;
                config.IgnoreCWUnsafe = this.IgnoreCWUnsafecheckBox.Checked;
                config.SafeClose = this.SafeClosecheckBox.Checked;
                config.Save();
                SaveButton.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void URLtextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MaxHumiditytextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MinHumiditytextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MaxTemperaturetextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MinTemperaturetextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MaxCloudtextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MinCloudtextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MaxWindtextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MinWindtextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MaxGusttextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MinGusttextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MaxRaintextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MinRaintextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MaxLighttextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void MinLighttextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void SleepTimetextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void ProcesstextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void DometextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void StartTimetextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void EndTimetextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void WaitAfterExitcheckBox_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void AutoOpencheckBox_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private void IgnoreCWUnsafecheckBox_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
        }

        private int count = 0;
        private void Startbutton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            StopButton.Enabled = true;
            timer1.Interval = config.SleepTime*100;
            progressBar1.Value = 0;
            count = 0;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Value = 0;
            StartButton.Enabled = true;
            StopButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count += 10;
            progressBar1.Value = count;
            if (count >= 100)
            {
                count = 0;
                progressBar1.Value = count;
                CheckResult result = DryRoofProcess.CheckConditions(config);

                HumiditytextBox.Text = result.WeatherData.humidity.ToString();
                TemperaturetextBox.Text = result.WeatherData.temperature.ToString();
                CloudtextBox.Text = result.WeatherData.cloud.ToString();
                WindtextBox.Text = result.WeatherData.wind.ToString();
                GusttextBox.Text = result.WeatherData.gust.ToString();
                RaintextBox.Text = result.WeatherData.rain.ToString();
                LighttextBox.Text = result.WeatherData.light.ToString();

                LogtextBox.AppendText(Environment.NewLine+String.Join(Environment.NewLine, result.Log));
                if (!String.IsNullOrEmpty(result.Error))
                {
                    timer1.Stop();
                    StopButton.Enabled = false;
                    StartButton.Enabled = true;
                    MessageBox.Show(result.Error);
                }
            }
        }
    }
}
