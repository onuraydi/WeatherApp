namespace WeatherApp
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
            this.grdpnlMain = new WeatherApp.GradientPanel();
            this.lblWeather = new System.Windows.Forms.Label();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFelt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblhumidText = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblWindText = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.pnlTop = new WeatherApp.GradientPanel();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grdpnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdpnlMain
            // 
            this.grdpnlMain.Angle = 50F;
            this.grdpnlMain.BottomColor = System.Drawing.Color.DarkBlue;
            this.grdpnlMain.Controls.Add(this.lblWeather);
            this.grdpnlMain.Controls.Add(this.ptbIcon);
            this.grdpnlMain.Controls.Add(this.label3);
            this.grdpnlMain.Controls.Add(this.lblFelt);
            this.grdpnlMain.Controls.Add(this.label2);
            this.grdpnlMain.Controls.Add(this.lblPrecip);
            this.grdpnlMain.Controls.Add(this.label1);
            this.grdpnlMain.Controls.Add(this.lblHumidity);
            this.grdpnlMain.Controls.Add(this.lblhumidText);
            this.grdpnlMain.Controls.Add(this.lblWind);
            this.grdpnlMain.Controls.Add(this.lblWindText);
            this.grdpnlMain.Controls.Add(this.lblTemp);
            this.grdpnlMain.Controls.Add(this.pnlTop);
            this.grdpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdpnlMain.ForeColor = System.Drawing.Color.DarkBlue;
            this.grdpnlMain.Location = new System.Drawing.Point(0, 0);
            this.grdpnlMain.Name = "grdpnlMain";
            this.grdpnlMain.Size = new System.Drawing.Size(400, 500);
            this.grdpnlMain.TabIndex = 1;
            this.grdpnlMain.TopColor = System.Drawing.Color.AliceBlue;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.BackColor = System.Drawing.Color.Transparent;
            this.lblWeather.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeather.ForeColor = System.Drawing.Color.Black;
            this.lblWeather.Location = new System.Drawing.Point(118, 80);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(194, 57);
            this.lblWeather.TabIndex = 17;
            this.lblWeather.Text = "weather";
            // 
            // ptbIcon
            // 
            this.ptbIcon.BackColor = System.Drawing.Color.Transparent;
            this.ptbIcon.Image = global::WeatherApp.Properties.Resources.kapalı;
            this.ptbIcon.ImageLocation = "";
            this.ptbIcon.Location = new System.Drawing.Point(12, 50);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(100, 100);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIcon.TabIndex = 16;
            this.ptbIcon.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 57);
            this.label3.TabIndex = 15;
            this.label3.Text = "Temp:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFelt
            // 
            this.lblFelt.AutoSize = true;
            this.lblFelt.BackColor = System.Drawing.Color.Transparent;
            this.lblFelt.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFelt.ForeColor = System.Drawing.Color.Black;
            this.lblFelt.Location = new System.Drawing.Point(104, 210);
            this.lblFelt.Name = "lblFelt";
            this.lblFelt.Size = new System.Drawing.Size(134, 57);
            this.lblFelt.TabIndex = 14;
            this.lblFelt.Text = "Felt: ";
            this.lblFelt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 57);
            this.label2.TabIndex = 13;
            this.label2.Text = "Felt: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecip
            // 
            this.lblPrecip.AutoSize = true;
            this.lblPrecip.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecip.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrecip.ForeColor = System.Drawing.Color.Black;
            this.lblPrecip.Location = new System.Drawing.Point(12, 324);
            this.lblPrecip.Name = "lblPrecip";
            this.lblPrecip.Size = new System.Drawing.Size(48, 57);
            this.lblPrecip.TabIndex = 12;
            this.lblPrecip.Text = "x";
            this.lblPrecip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 57);
            this.label1.TabIndex = 11;
            this.label1.Text = "Precipitation:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lblHumidity.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHumidity.ForeColor = System.Drawing.Color.Black;
            this.lblHumidity.Location = new System.Drawing.Point(208, 381);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(167, 57);
            this.lblHumidity.TabIndex = 10;
            this.lblHumidity.Text = "humad";
            this.lblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblhumidText
            // 
            this.lblhumidText.AutoSize = true;
            this.lblhumidText.BackColor = System.Drawing.Color.Transparent;
            this.lblhumidText.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhumidText.ForeColor = System.Drawing.Color.Black;
            this.lblhumidText.Location = new System.Drawing.Point(12, 381);
            this.lblhumidText.Name = "lblhumidText";
            this.lblhumidText.Size = new System.Drawing.Size(226, 57);
            this.lblhumidText.TabIndex = 9;
            this.lblhumidText.Text = "Humidity:";
            this.lblhumidText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.BackColor = System.Drawing.Color.Transparent;
            this.lblWind.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWind.ForeColor = System.Drawing.Color.Black;
            this.lblWind.Location = new System.Drawing.Point(138, 438);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(147, 57);
            this.lblWind.TabIndex = 8;
            this.lblWind.Text = "Wind:";
            this.lblWind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWindText
            // 
            this.lblWindText.AutoSize = true;
            this.lblWindText.BackColor = System.Drawing.Color.Transparent;
            this.lblWindText.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWindText.ForeColor = System.Drawing.Color.Black;
            this.lblWindText.Location = new System.Drawing.Point(12, 438);
            this.lblWindText.Name = "lblWindText";
            this.lblWindText.Size = new System.Drawing.Size(147, 57);
            this.lblWindText.TabIndex = 7;
            this.lblWindText.Text = "Wind:";
            this.lblWindText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTemp.ForeColor = System.Drawing.Color.Black;
            this.lblTemp.Location = new System.Drawing.Point(138, 153);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(116, 57);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "Tem";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.Angle = 50F;
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.BottomColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.lblCity);
            this.pnlTop.Controls.Add(this.lblDateTime);
            this.pnlTop.Controls.Add(this.lblTime);
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.Transparent;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(400, 30);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.TopColor = System.Drawing.Color.Transparent;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(101, 5);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 24);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "label1";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.ForeColor = System.Drawing.Color.Black;
            this.lblDateTime.Location = new System.Drawing.Point(230, 5);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(64, 24);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "label1";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(331, 5);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 24);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(11, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.grdpnlMain);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grdpnlMain.ResumeLayout(false);
            this.grdpnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GradientPanel grdpnlMain;
        private GradientPanel pnlTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblWindText;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblhumidText;
        private System.Windows.Forms.Label lblPrecip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFelt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.PictureBox ptbIcon;
    }
}

