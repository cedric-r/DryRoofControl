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
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(33, 413);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(436, 413);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 1;
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
            this.label9.Location = new System.Drawing.Point(13, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sleep Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Min Light:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Max Light:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 293);
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
            this.URLtextBox.TabIndex = 27;
            this.URLtextBox.TextChanged += new System.EventHandler(this.URLtextBox_TextChanged);
            // 
            // MaxHumiditytextBox
            // 
            this.MaxHumiditytextBox.Location = new System.Drawing.Point(121, 35);
            this.MaxHumiditytextBox.Name = "MaxHumiditytextBox";
            this.MaxHumiditytextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxHumiditytextBox.TabIndex = 28;
            this.MaxHumiditytextBox.TextChanged += new System.EventHandler(this.MaxHumiditytextBox_TextChanged);
            // 
            // MinHumiditytextBox
            // 
            this.MinHumiditytextBox.Location = new System.Drawing.Point(121, 58);
            this.MinHumiditytextBox.Name = "MinHumiditytextBox";
            this.MinHumiditytextBox.Size = new System.Drawing.Size(100, 20);
            this.MinHumiditytextBox.TabIndex = 29;
            this.MinHumiditytextBox.TextChanged += new System.EventHandler(this.MinHumiditytextBox_TextChanged);
            // 
            // MaxTemperaturetextBox
            // 
            this.MaxTemperaturetextBox.Location = new System.Drawing.Point(121, 80);
            this.MaxTemperaturetextBox.Name = "MaxTemperaturetextBox";
            this.MaxTemperaturetextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxTemperaturetextBox.TabIndex = 30;
            this.MaxTemperaturetextBox.TextChanged += new System.EventHandler(this.MaxTemperaturetextBox_TextChanged);
            // 
            // MinTemperaturetextBox
            // 
            this.MinTemperaturetextBox.Location = new System.Drawing.Point(121, 103);
            this.MinTemperaturetextBox.Name = "MinTemperaturetextBox";
            this.MinTemperaturetextBox.Size = new System.Drawing.Size(100, 20);
            this.MinTemperaturetextBox.TabIndex = 31;
            this.MinTemperaturetextBox.TextChanged += new System.EventHandler(this.MinTemperaturetextBox_TextChanged);
            // 
            // MaxCloudtextBox
            // 
            this.MaxCloudtextBox.Location = new System.Drawing.Point(121, 127);
            this.MaxCloudtextBox.Name = "MaxCloudtextBox";
            this.MaxCloudtextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxCloudtextBox.TabIndex = 32;
            this.MaxCloudtextBox.TextChanged += new System.EventHandler(this.MaxCloudtextBox_TextChanged);
            // 
            // MinCloudtextBox
            // 
            this.MinCloudtextBox.Location = new System.Drawing.Point(121, 149);
            this.MinCloudtextBox.Name = "MinCloudtextBox";
            this.MinCloudtextBox.Size = new System.Drawing.Size(100, 20);
            this.MinCloudtextBox.TabIndex = 33;
            this.MinCloudtextBox.TextChanged += new System.EventHandler(this.MinCloudtextBox_TextChanged);
            // 
            // MaxWindtextBox
            // 
            this.MaxWindtextBox.Location = new System.Drawing.Point(121, 174);
            this.MaxWindtextBox.Name = "MaxWindtextBox";
            this.MaxWindtextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxWindtextBox.TabIndex = 34;
            this.MaxWindtextBox.TextChanged += new System.EventHandler(this.MaxWindtextBox_TextChanged);
            // 
            // MinWindtextBox
            // 
            this.MinWindtextBox.Location = new System.Drawing.Point(121, 197);
            this.MinWindtextBox.Name = "MinWindtextBox";
            this.MinWindtextBox.Size = new System.Drawing.Size(100, 20);
            this.MinWindtextBox.TabIndex = 35;
            this.MinWindtextBox.TextChanged += new System.EventHandler(this.MinWindtextBox_TextChanged);
            // 
            // MaxGusttextBox
            // 
            this.MaxGusttextBox.Location = new System.Drawing.Point(121, 219);
            this.MaxGusttextBox.Name = "MaxGusttextBox";
            this.MaxGusttextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxGusttextBox.TabIndex = 36;
            this.MaxGusttextBox.TextChanged += new System.EventHandler(this.MaxGusttextBox_TextChanged);
            // 
            // MinGusttextBox
            // 
            this.MinGusttextBox.Location = new System.Drawing.Point(121, 242);
            this.MinGusttextBox.Name = "MinGusttextBox";
            this.MinGusttextBox.Size = new System.Drawing.Size(100, 20);
            this.MinGusttextBox.TabIndex = 37;
            this.MinGusttextBox.TextChanged += new System.EventHandler(this.MinGusttextBox_TextChanged);
            // 
            // MaxRaintextBox
            // 
            this.MaxRaintextBox.Location = new System.Drawing.Point(121, 264);
            this.MaxRaintextBox.Name = "MaxRaintextBox";
            this.MaxRaintextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxRaintextBox.TabIndex = 38;
            this.MaxRaintextBox.TextChanged += new System.EventHandler(this.MaxRaintextBox_TextChanged);
            // 
            // MinRaintextBox
            // 
            this.MinRaintextBox.Location = new System.Drawing.Point(121, 290);
            this.MinRaintextBox.Name = "MinRaintextBox";
            this.MinRaintextBox.Size = new System.Drawing.Size(100, 20);
            this.MinRaintextBox.TabIndex = 39;
            this.MinRaintextBox.TextChanged += new System.EventHandler(this.MinRaintextBox_TextChanged);
            // 
            // MaxLighttextBox
            // 
            this.MaxLighttextBox.Location = new System.Drawing.Point(121, 314);
            this.MaxLighttextBox.Name = "MaxLighttextBox";
            this.MaxLighttextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxLighttextBox.TabIndex = 40;
            this.MaxLighttextBox.TextChanged += new System.EventHandler(this.MaxLighttextBox_TextChanged);
            // 
            // MinLighttextBox
            // 
            this.MinLighttextBox.Location = new System.Drawing.Point(121, 340);
            this.MinLighttextBox.Name = "MinLighttextBox";
            this.MinLighttextBox.Size = new System.Drawing.Size(100, 20);
            this.MinLighttextBox.TabIndex = 41;
            this.MinLighttextBox.TextChanged += new System.EventHandler(this.MinLighttextBox_TextChanged);
            // 
            // ProcesstextBox
            // 
            this.ProcesstextBox.Location = new System.Drawing.Point(411, 35);
            this.ProcesstextBox.Name = "ProcesstextBox";
            this.ProcesstextBox.Size = new System.Drawing.Size(100, 20);
            this.ProcesstextBox.TabIndex = 42;
            this.ProcesstextBox.TextChanged += new System.EventHandler(this.ProcesstextBox_TextChanged);
            // 
            // DometextBox
            // 
            this.DometextBox.Location = new System.Drawing.Point(411, 58);
            this.DometextBox.Name = "DometextBox";
            this.DometextBox.Size = new System.Drawing.Size(100, 20);
            this.DometextBox.TabIndex = 43;
            this.DometextBox.TextChanged += new System.EventHandler(this.DometextBox_TextChanged);
            // 
            // SleepTimetextBox
            // 
            this.SleepTimetextBox.Location = new System.Drawing.Point(121, 365);
            this.SleepTimetextBox.Name = "SleepTimetextBox";
            this.SleepTimetextBox.Size = new System.Drawing.Size(100, 20);
            this.SleepTimetextBox.TabIndex = 44;
            this.SleepTimetextBox.TextChanged += new System.EventHandler(this.SleepTimetextBox_TextChanged);
            // 
            // StartTimetextBox
            // 
            this.StartTimetextBox.Location = new System.Drawing.Point(411, 80);
            this.StartTimetextBox.Name = "StartTimetextBox";
            this.StartTimetextBox.Size = new System.Drawing.Size(100, 20);
            this.StartTimetextBox.TabIndex = 46;
            this.StartTimetextBox.TextChanged += new System.EventHandler(this.StartTimetextBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(283, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Start Time:";
            // 
            // EndTimetextBox
            // 
            this.EndTimetextBox.Location = new System.Drawing.Point(411, 103);
            this.EndTimetextBox.Name = "EndTimetextBox";
            this.EndTimetextBox.Size = new System.Drawing.Size(100, 20);
            this.EndTimetextBox.TabIndex = 48;
            this.EndTimetextBox.TextChanged += new System.EventHandler(this.EndTimetextBox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(283, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "End Time:";
            // 
            // WaitAfterExitcheckBox
            // 
            this.WaitAfterExitcheckBox.AutoSize = true;
            this.WaitAfterExitcheckBox.Location = new System.Drawing.Point(411, 127);
            this.WaitAfterExitcheckBox.Name = "WaitAfterExitcheckBox";
            this.WaitAfterExitcheckBox.Size = new System.Drawing.Size(93, 17);
            this.WaitAfterExitcheckBox.TabIndex = 50;
            this.WaitAfterExitcheckBox.Text = "Wait After Exit";
            this.WaitAfterExitcheckBox.UseVisualStyleBackColor = true;
            this.WaitAfterExitcheckBox.Click += new System.EventHandler(this.WaitAfterExitcheckBox_Click);
            // 
            // AutoOpencheckBox
            // 
            this.AutoOpencheckBox.AutoSize = true;
            this.AutoOpencheckBox.Location = new System.Drawing.Point(411, 149);
            this.AutoOpencheckBox.Name = "AutoOpencheckBox";
            this.AutoOpencheckBox.Size = new System.Drawing.Size(77, 17);
            this.AutoOpencheckBox.TabIndex = 52;
            this.AutoOpencheckBox.Text = "Auto Open";
            this.AutoOpencheckBox.UseVisualStyleBackColor = true;
            this.AutoOpencheckBox.Click += new System.EventHandler(this.AutoOpencheckBox_Click);
            // 
            // IgnoreCWUnsafecheckBox
            // 
            this.IgnoreCWUnsafecheckBox.AutoSize = true;
            this.IgnoreCWUnsafecheckBox.Location = new System.Drawing.Point(411, 172);
            this.IgnoreCWUnsafecheckBox.Name = "IgnoreCWUnsafecheckBox";
            this.IgnoreCWUnsafecheckBox.Size = new System.Drawing.Size(114, 17);
            this.IgnoreCWUnsafecheckBox.TabIndex = 53;
            this.IgnoreCWUnsafecheckBox.Text = "Ignore CW Unsafe";
            this.IgnoreCWUnsafecheckBox.UseVisualStyleBackColor = true;
            this.IgnoreCWUnsafecheckBox.Click += new System.EventHandler(this.IgnoreCWUnsafecheckBox_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(355, 413);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 54;
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
            this.StopButton.Location = new System.Drawing.Point(114, 413);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 55;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(195, 413);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(154, 23);
            this.progressBar1.TabIndex = 56;
            // 
            // LogtextBox
            // 
            this.LogtextBox.AcceptsReturn = true;
            this.LogtextBox.Location = new System.Drawing.Point(227, 222);
            this.LogtextBox.Multiline = true;
            this.LogtextBox.Name = "LogtextBox";
            this.LogtextBox.ReadOnly = true;
            this.LogtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogtextBox.Size = new System.Drawing.Size(284, 163);
            this.LogtextBox.TabIndex = 57;
            this.LogtextBox.WordWrap = false;
            // 
            // SafeClosecheckBox
            // 
            this.SafeClosecheckBox.AutoSize = true;
            this.SafeClosecheckBox.Location = new System.Drawing.Point(411, 195);
            this.SafeClosecheckBox.Name = "SafeClosecheckBox";
            this.SafeClosecheckBox.Size = new System.Drawing.Size(76, 17);
            this.SafeClosecheckBox.TabIndex = 58;
            this.SafeClosecheckBox.Text = "Safe close";
            this.SafeClosecheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
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
    }
}

