namespace DryRoofControlUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.URLtextBox = new System.Windows.Forms.TextBox();
            this.MaxHumiditytextBox = new System.Windows.Forms.TextBox();
            this.MinHumiditytextBox = new System.Windows.Forms.TextBox();
            this.MaxTemperaturetextBox = new System.Windows.Forms.TextBox();
            this.MinTemperaturetextBox = new System.Windows.Forms.TextBox();
            this.MaxCloudtextBox = new System.Windows.Forms.TextBox();
            this.MinCloudtextBox = new System.Windows.Forms.TextBox();
            this.MaxWindtextBox = new System.Windows.Forms.TextBox();
            this.MinWindtextBox = new System.Windows.Forms.TextBox();
            this.MaxGusttextBox = new System.Windows.Forms.TextBox();
            this.MinGusttextBox = new System.Windows.Forms.TextBox();
            this.MaxRaintextBox = new System.Windows.Forms.TextBox();
            this.MinRaintextBox = new System.Windows.Forms.TextBox();
            this.MaxLighttextBox = new System.Windows.Forms.TextBox();
            this.MinLighttextBox = new System.Windows.Forms.TextBox();
            this.ProcesstextBox = new System.Windows.Forms.TextBox();
            this.DometextBox = new System.Windows.Forms.TextBox();
            this.SleepTimetextBox = new System.Windows.Forms.TextBox();
            this.StartTimetextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.EndTimetextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.WaitAfterExitcheckBox = new System.Windows.Forms.CheckBox();
            this.AutoOpencheckBox = new System.Windows.Forms.CheckBox();
            this.IgnoreCWUnsafecheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StopButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LogtextBox = new System.Windows.Forms.TextBox();
            this.SafeClosecheckBox = new System.Windows.Forms.CheckBox();
            this.LighttextBox = new System.Windows.Forms.TextBox();
            this.RaintextBox = new System.Windows.Forms.TextBox();
            this.GusttextBox = new System.Windows.Forms.TextBox();
            this.WindtextBox = new System.Windows.Forms.TextBox();
            this.CloudtextBox = new System.Windows.Forms.TextBox();
            this.TemperaturetextBox = new System.Windows.Forms.TextBox();
            this.HumiditytextBox = new System.Windows.Forms.TextBox();
            this.SerialPorttextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.HowFartextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(16, 577);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 27;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(436, 577);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 30;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CloudWatcher URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Humidity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min Humidity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Max Temperature:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Min Temperature:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max Cloud Temp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Min Cloud Temp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Max Wind Speed:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sleep Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Min Light:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Max Light:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Min Rain Rate:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Max Rain Rate:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Min Gust Speed:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Max Gust Speed:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Min Wind Speed:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(283, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Dome ASCOM Name:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(283, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 19;
            this.label23.Text = "Process Name:";
            // 
            // URLtextBox
            // 
            this.URLtextBox.Location = new System.Drawing.Point(121, 13);
            this.URLtextBox.Name = "URLtextBox";
            this.URLtextBox.Size = new System.Drawing.Size(390, 20);
            this.URLtextBox.TabIndex = 1;
            this.URLtextBox.TextChanged += new System.EventHandler(this.URLtextBox_TextChanged);
            // 
            // MaxHumiditytextBox
            // 
            this.MaxHumiditytextBox.Location = new System.Drawing.Point(121, 35);
            this.MaxHumiditytextBox.Name = "MaxHumiditytextBox";
            this.MaxHumiditytextBox.Size = new System.Drawing.Size(48, 20);
            this.MaxHumiditytextBox.TabIndex = 2;
            this.MaxHumiditytextBox.TextChanged += new System.EventHandler(this.MaxHumiditytextBox_TextChanged);
            // 
            // MinHumiditytextBox
            // 
            this.MinHumiditytextBox.Location = new System.Drawing.Point(121, 58);
            this.MinHumiditytextBox.Name = "MinHumiditytextBox";
            this.MinHumiditytextBox.Size = new System.Drawing.Size(48, 20);
            this.MinHumiditytextBox.TabIndex = 3;
            this.MinHumiditytextBox.TextChanged += new System.EventHandler(this.MinHumiditytextBox_TextChanged);
            // 
            // MaxTemperaturetextBox
            // 
            this.MaxTemperaturetextBox.Location = new System.Drawing.Point(121, 80);
            this.MaxTemperaturetextBox.Name = "MaxTemperaturetextBox";
            this.MaxTemperaturetextBox.Size = new System.Drawing.Size(48, 20);
            this.MaxTemperaturetextBox.TabIndex = 4;
            this.MaxTemperaturetextBox.TextChanged += new System.EventHandler(this.MaxTemperaturetextBox_TextChanged);
            // 
            // MinTemperaturetextBox
            // 
            this.MinTemperaturetextBox.Location = new System.Drawing.Point(121, 103);
            this.MinTemperaturetextBox.Name = "MinTemperaturetextBox";
            this.MinTemperaturetextBox.Size = new System.Drawing.Size(48, 20);
            this.MinTemperaturetextBox.TabIndex = 5;
            this.MinTemperaturetextBox.TextChanged += new System.EventHandler(this.MinTemperaturetextBox_TextChanged);
            // 
            // MaxCloudtextBox
            // 
            this.MaxCloudtextBox.Location = new System.Drawing.Point(121, 127);
            this.MaxCloudtextBox.Name = "MaxCloudtextBox";
            this.MaxCloudtextBox.Size = new System.Drawing.Size(48, 20);
            this.MaxCloudtextBox.TabIndex = 6;
            this.MaxCloudtextBox.TextChanged += new System.EventHandler(this.MaxCloudtextBox_TextChanged);
            // 
            // MinCloudtextBox
            // 
            this.MinCloudtextBox.Location = new System.Drawing.Point(121, 149);
            this.MinCloudtextBox.Name = "MinCloudtextBox";
            this.MinCloudtextBox.Size = new System.Drawing.Size(48, 20);
            this.MinCloudtextBox.TabIndex = 7;
            this.MinCloudtextBox.TextChanged += new System.EventHandler(this.MinCloudtextBox_TextChanged);
            // 
            // MaxWindtextBox
            // 
            this.MaxWindtextBox.Location = new System.Drawing.Point(121, 174);
            this.MaxWindtextBox.Name = "MaxWindtextBox";
            this.MaxWindtextBox.Size = new System.Drawing.Size(48, 20);
            this.MaxWindtextBox.TabIndex = 8;
            this.MaxWindtextBox.TextChanged += new System.EventHandler(this.MaxWindtextBox_TextChanged);
            // 
            // MinWindtextBox
            // 
            this.MinWindtextBox.Location = new System.Drawing.Point(121, 197);
            this.MinWindtextBox.Name = "MinWindtextBox";
            this.MinWindtextBox.Size = new System.Drawing.Size(48, 20);
            this.MinWindtextBox.TabIndex = 9;
            this.MinWindtextBox.TextChanged += new System.EventHandler(this.MinWindtextBox_TextChanged);
            // 
            // MaxGusttextBox
            // 
            this.MaxGusttextBox.Location = new System.Drawing.Point(121, 219);
            this.MaxGusttextBox.Name = "MaxGusttextBox";
            this.MaxGusttextBox.Size = new System.Drawing.Size(48, 20);
            this.MaxGusttextBox.TabIndex = 10;
            this.MaxGusttextBox.TextChanged += new System.EventHandler(this.MaxGusttextBox_TextChanged);
            // 
            // MinGusttextBox
            // 
            this.MinGusttextBox.Location = new System.Drawing.Point(121, 242);
            this.MinGusttextBox.Name = "MinGusttextBox";
            this.MinGusttextBox.Size = new System.Drawing.Size(48, 20);
            this.MinGusttextBox.TabIndex = 11;
            this.MinGusttextBox.TextChanged += new System.EventHandler(this.MinGusttextBox_TextChanged);
            // 
            // MaxRaintextBox
            // 
            this.MaxRaintextBox.Location = new System.Drawing.Point(121, 264);
            this.MaxRaintextBox.Name = "MaxRaintextBox";
            this.MaxRaintextBox.Size = new System.Drawing.Size(48, 20);
            this.MaxRaintextBox.TabIndex = 12;
            this.MaxRaintextBox.TextChanged += new System.EventHandler(this.MaxRaintextBox_TextChanged);
            // 
            // MinRaintextBox
            // 
            this.MinRaintextBox.Location = new System.Drawing.Point(121, 286);
            this.MinRaintextBox.Name = "MinRaintextBox";
            this.MinRaintextBox.Size = new System.Drawing.Size(48, 20);
            this.MinRaintextBox.TabIndex = 13;
            this.MinRaintextBox.TextChanged += new System.EventHandler(this.MinRaintextBox_TextChanged);
            // 
            // MaxLighttextBox
            // 
            this.MaxLighttextBox.Location = new System.Drawing.Point(121, 310);
            this.MaxLighttextBox.Name = "MaxLighttextBox";
            this.MaxLighttextBox.Size = new System.Drawing.Size(48, 20);
            this.MaxLighttextBox.TabIndex = 14;
            this.MaxLighttextBox.TextChanged += new System.EventHandler(this.MaxLighttextBox_TextChanged);
            // 
            // MinLighttextBox
            // 
            this.MinLighttextBox.Location = new System.Drawing.Point(121, 336);
            this.MinLighttextBox.Name = "MinLighttextBox";
            this.MinLighttextBox.Size = new System.Drawing.Size(48, 20);
            this.MinLighttextBox.TabIndex = 15;
            this.MinLighttextBox.TextChanged += new System.EventHandler(this.MinLighttextBox_TextChanged);
            // 
            // ProcesstextBox
            // 
            this.ProcesstextBox.Location = new System.Drawing.Point(411, 35);
            this.ProcesstextBox.Name = "ProcesstextBox";
            this.ProcesstextBox.Size = new System.Drawing.Size(100, 20);
            this.ProcesstextBox.TabIndex = 17;
            this.ProcesstextBox.TextChanged += new System.EventHandler(this.ProcesstextBox_TextChanged);
            // 
            // DometextBox
            // 
            this.DometextBox.Location = new System.Drawing.Point(411, 58);
            this.DometextBox.Name = "DometextBox";
            this.DometextBox.Size = new System.Drawing.Size(100, 20);
            this.DometextBox.TabIndex = 18;
            this.DometextBox.TextChanged += new System.EventHandler(this.DometextBox_TextChanged);
            // 
            // SleepTimetextBox
            // 
            this.SleepTimetextBox.Location = new System.Drawing.Point(121, 361);
            this.SleepTimetextBox.Name = "SleepTimetextBox";
            this.SleepTimetextBox.Size = new System.Drawing.Size(48, 20);
            this.SleepTimetextBox.TabIndex = 16;
            this.SleepTimetextBox.TextChanged += new System.EventHandler(this.SleepTimetextBox_TextChanged);
            // 
            // StartTimetextBox
            // 
            this.StartTimetextBox.Location = new System.Drawing.Point(411, 129);
            this.StartTimetextBox.Name = "StartTimetextBox";
            this.StartTimetextBox.Size = new System.Drawing.Size(100, 20);
            this.StartTimetextBox.TabIndex = 21;
            this.StartTimetextBox.TextChanged += new System.EventHandler(this.StartTimetextBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(283, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Start Time:";
            // 
            // EndTimetextBox
            // 
            this.EndTimetextBox.Location = new System.Drawing.Point(411, 152);
            this.EndTimetextBox.Name = "EndTimetextBox";
            this.EndTimetextBox.Size = new System.Drawing.Size(100, 20);
            this.EndTimetextBox.TabIndex = 22;
            this.EndTimetextBox.TextChanged += new System.EventHandler(this.EndTimetextBox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(283, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "End Time:";
            // 
            // WaitAfterExitcheckBox
            // 
            this.WaitAfterExitcheckBox.AutoSize = true;
            this.WaitAfterExitcheckBox.Location = new System.Drawing.Point(411, 176);
            this.WaitAfterExitcheckBox.Name = "WaitAfterExitcheckBox";
            this.WaitAfterExitcheckBox.Size = new System.Drawing.Size(93, 17);
            this.WaitAfterExitcheckBox.TabIndex = 23;
            this.WaitAfterExitcheckBox.Text = "Wait After Exit";
            this.WaitAfterExitcheckBox.UseVisualStyleBackColor = true;
            this.WaitAfterExitcheckBox.Click += new System.EventHandler(this.WaitAfterExitcheckBox_Click);
            // 
            // AutoOpencheckBox
            // 
            this.AutoOpencheckBox.AutoSize = true;
            this.AutoOpencheckBox.Location = new System.Drawing.Point(411, 198);
            this.AutoOpencheckBox.Name = "AutoOpencheckBox";
            this.AutoOpencheckBox.Size = new System.Drawing.Size(77, 17);
            this.AutoOpencheckBox.TabIndex = 24;
            this.AutoOpencheckBox.Text = "Auto Open";
            this.AutoOpencheckBox.UseVisualStyleBackColor = true;
            this.AutoOpencheckBox.Click += new System.EventHandler(this.AutoOpencheckBox_Click);
            // 
            // IgnoreCWUnsafecheckBox
            // 
            this.IgnoreCWUnsafecheckBox.AutoSize = true;
            this.IgnoreCWUnsafecheckBox.Location = new System.Drawing.Point(411, 221);
            this.IgnoreCWUnsafecheckBox.Name = "IgnoreCWUnsafecheckBox";
            this.IgnoreCWUnsafecheckBox.Size = new System.Drawing.Size(114, 17);
            this.IgnoreCWUnsafecheckBox.TabIndex = 25;
            this.IgnoreCWUnsafecheckBox.Text = "Ignore CW Unsafe";
            this.IgnoreCWUnsafecheckBox.UseVisualStyleBackColor = true;
            this.IgnoreCWUnsafecheckBox.Click += new System.EventHandler(this.IgnoreCWUnsafecheckBox_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(353, 577);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.Text = "Save Config";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(97, 577);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 28;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(178, 577);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(169, 23);
            this.progressBar1.TabIndex = 56;
            // 
            // LogtextBox
            // 
            this.LogtextBox.AcceptsReturn = true;
            this.LogtextBox.Location = new System.Drawing.Point(16, 387);
            this.LogtextBox.Multiline = true;
            this.LogtextBox.Name = "LogtextBox";
            this.LogtextBox.ReadOnly = true;
            this.LogtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogtextBox.Size = new System.Drawing.Size(495, 173);
            this.LogtextBox.TabIndex = 57;
            this.LogtextBox.WordWrap = false;
            // 
            // SafeClosecheckBox
            // 
            this.SafeClosecheckBox.AutoSize = true;
            this.SafeClosecheckBox.Location = new System.Drawing.Point(411, 244);
            this.SafeClosecheckBox.Name = "SafeClosecheckBox";
            this.SafeClosecheckBox.Size = new System.Drawing.Size(76, 17);
            this.SafeClosecheckBox.TabIndex = 26;
            this.SafeClosecheckBox.Text = "Safe close";
            this.SafeClosecheckBox.UseVisualStyleBackColor = true;
            // 
            // LighttextBox
            // 
            this.LighttextBox.Enabled = false;
            this.LighttextBox.Location = new System.Drawing.Point(216, 310);
            this.LighttextBox.Name = "LighttextBox";
            this.LighttextBox.Size = new System.Drawing.Size(48, 20);
            this.LighttextBox.TabIndex = 71;
            // 
            // RaintextBox
            // 
            this.RaintextBox.Enabled = false;
            this.RaintextBox.Location = new System.Drawing.Point(216, 264);
            this.RaintextBox.Name = "RaintextBox";
            this.RaintextBox.Size = new System.Drawing.Size(48, 20);
            this.RaintextBox.TabIndex = 69;
            // 
            // GusttextBox
            // 
            this.GusttextBox.Enabled = false;
            this.GusttextBox.Location = new System.Drawing.Point(216, 219);
            this.GusttextBox.Name = "GusttextBox";
            this.GusttextBox.Size = new System.Drawing.Size(48, 20);
            this.GusttextBox.TabIndex = 67;
            // 
            // WindtextBox
            // 
            this.WindtextBox.Enabled = false;
            this.WindtextBox.Location = new System.Drawing.Point(216, 174);
            this.WindtextBox.Name = "WindtextBox";
            this.WindtextBox.Size = new System.Drawing.Size(48, 20);
            this.WindtextBox.TabIndex = 65;
            // 
            // CloudtextBox
            // 
            this.CloudtextBox.Enabled = false;
            this.CloudtextBox.Location = new System.Drawing.Point(216, 127);
            this.CloudtextBox.Name = "CloudtextBox";
            this.CloudtextBox.Size = new System.Drawing.Size(48, 20);
            this.CloudtextBox.TabIndex = 63;
            // 
            // TemperaturetextBox
            // 
            this.TemperaturetextBox.Enabled = false;
            this.TemperaturetextBox.Location = new System.Drawing.Point(216, 80);
            this.TemperaturetextBox.Name = "TemperaturetextBox";
            this.TemperaturetextBox.Size = new System.Drawing.Size(48, 20);
            this.TemperaturetextBox.TabIndex = 61;
            // 
            // HumiditytextBox
            // 
            this.HumiditytextBox.Enabled = false;
            this.HumiditytextBox.Location = new System.Drawing.Point(216, 35);
            this.HumiditytextBox.Name = "HumiditytextBox";
            this.HumiditytextBox.Size = new System.Drawing.Size(48, 20);
            this.HumiditytextBox.TabIndex = 59;
            // 
            // SerialPorttextBox
            // 
            this.SerialPorttextBox.Location = new System.Drawing.Point(411, 80);
            this.SerialPorttextBox.Name = "SerialPorttextBox";
            this.SerialPorttextBox.Size = new System.Drawing.Size(100, 20);
            this.SerialPorttextBox.TabIndex = 19;
            this.SerialPorttextBox.TextChanged += new System.EventHandler(this.SerialPorttextBox_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(283, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 72;
            this.label19.Text = "Serial port:";
            // 
            // HowFartextBox
            // 
            this.HowFartextBox.Location = new System.Drawing.Point(411, 103);
            this.HowFartextBox.Name = "HowFartextBox";
            this.HowFartextBox.Size = new System.Drawing.Size(76, 20);
            this.HowFartextBox.TabIndex = 20;
            this.HowFartextBox.TextChanged += new System.EventHandler(this.HowFartextBox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(283, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 74;
            this.label20.Text = "Open distance:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(175, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 75;
            this.label21.Text = "%";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(175, 61);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 13);
            this.label24.TabIndex = 76;
            this.label24.Text = "%";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(175, 83);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 13);
            this.label25.TabIndex = 77;
            this.label25.Text = "C";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(175, 106);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(14, 13);
            this.label26.TabIndex = 78;
            this.label26.Text = "C";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(175, 130);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 13);
            this.label27.TabIndex = 79;
            this.label27.Text = "C";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(175, 153);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 80;
            this.label28.Text = "C";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(175, 177);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 13);
            this.label29.TabIndex = 81;
            this.label29.Text = "km/h";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(175, 200);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(32, 13);
            this.label30.TabIndex = 82;
            this.label30.Text = "km/h";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(175, 222);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 13);
            this.label31.TabIndex = 83;
            this.label31.Text = "km/h";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(175, 245);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(32, 13);
            this.label32.TabIndex = 84;
            this.label32.Text = "km/h";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(175, 267);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(34, 13);
            this.label33.TabIndex = 85;
            this.label33.Text = "mm/h";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(175, 289);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(34, 13);
            this.label34.TabIndex = 86;
            this.label34.Text = "mm/h";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(175, 364);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(12, 13);
            this.label35.TabIndex = 87;
            this.label35.Text = "s";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(496, 106);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(15, 13);
            this.label36.TabIndex = 88;
            this.label36.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 612);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.HowFartextBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.SerialPorttextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.LighttextBox);
            this.Controls.Add(this.RaintextBox);
            this.Controls.Add(this.GusttextBox);
            this.Controls.Add(this.WindtextBox);
            this.Controls.Add(this.CloudtextBox);
            this.Controls.Add(this.TemperaturetextBox);
            this.Controls.Add(this.HumiditytextBox);
            this.Controls.Add(this.SafeClosecheckBox);
            this.Controls.Add(this.LogtextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.IgnoreCWUnsafecheckBox);
            this.Controls.Add(this.AutoOpencheckBox);
            this.Controls.Add(this.WaitAfterExitcheckBox);
            this.Controls.Add(this.EndTimetextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.StartTimetextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.SleepTimetextBox);
            this.Controls.Add(this.DometextBox);
            this.Controls.Add(this.ProcesstextBox);
            this.Controls.Add(this.MinLighttextBox);
            this.Controls.Add(this.MaxLighttextBox);
            this.Controls.Add(this.MinRaintextBox);
            this.Controls.Add(this.MaxRaintextBox);
            this.Controls.Add(this.MinGusttextBox);
            this.Controls.Add(this.MaxGusttextBox);
            this.Controls.Add(this.MinWindtextBox);
            this.Controls.Add(this.MaxWindtextBox);
            this.Controls.Add(this.MinCloudtextBox);
            this.Controls.Add(this.MaxCloudtextBox);
            this.Controls.Add(this.MinTemperaturetextBox);
            this.Controls.Add(this.MaxTemperaturetextBox);
            this.Controls.Add(this.MinHumiditytextBox);
            this.Controls.Add(this.MaxHumiditytextBox);
            this.Controls.Add(this.URLtextBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "DryRoofControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox URLtextBox;
        private System.Windows.Forms.TextBox MaxHumiditytextBox;
        private System.Windows.Forms.TextBox MinHumiditytextBox;
        private System.Windows.Forms.TextBox MaxTemperaturetextBox;
        private System.Windows.Forms.TextBox MinTemperaturetextBox;
        private System.Windows.Forms.TextBox MaxCloudtextBox;
        private System.Windows.Forms.TextBox MinCloudtextBox;
        private System.Windows.Forms.TextBox MaxWindtextBox;
        private System.Windows.Forms.TextBox MinWindtextBox;
        private System.Windows.Forms.TextBox MaxGusttextBox;
        private System.Windows.Forms.TextBox MinGusttextBox;
        private System.Windows.Forms.TextBox MaxRaintextBox;
        private System.Windows.Forms.TextBox MinRaintextBox;
        private System.Windows.Forms.TextBox MaxLighttextBox;
        private System.Windows.Forms.TextBox MinLighttextBox;
        private System.Windows.Forms.TextBox ProcesstextBox;
        private System.Windows.Forms.TextBox DometextBox;
        private System.Windows.Forms.TextBox SleepTimetextBox;
        private System.Windows.Forms.TextBox StartTimetextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox EndTimetextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox WaitAfterExitcheckBox;
        private System.Windows.Forms.CheckBox AutoOpencheckBox;
        private System.Windows.Forms.CheckBox IgnoreCWUnsafecheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox LogtextBox;
        private System.Windows.Forms.CheckBox SafeClosecheckBox;
        private System.Windows.Forms.TextBox LighttextBox;
        private System.Windows.Forms.TextBox RaintextBox;
        private System.Windows.Forms.TextBox GusttextBox;
        private System.Windows.Forms.TextBox WindtextBox;
        private System.Windows.Forms.TextBox CloudtextBox;
        private System.Windows.Forms.TextBox TemperaturetextBox;
        private System.Windows.Forms.TextBox HumiditytextBox;
        private System.Windows.Forms.TextBox SerialPorttextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox HowFartextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
    }
}

