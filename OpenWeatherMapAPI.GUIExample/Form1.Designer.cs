
namespace OpenWeatherMap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboQueryType = new System.Windows.Forms.ComboBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pctWeatherIcon = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFeelsLike = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCityID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblWindDirection = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblClouds = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSunset = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboQueryType);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.btnGetWeather);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 52);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            this.toolTip.SetToolTip(this.groupBox1, "City, St, Country Code\r\nScottsbluff, NE, US");
            // 
            // cboQueryType
            // 
            this.cboQueryType.FormattingEnabled = true;
            this.cboQueryType.Location = new System.Drawing.Point(23, 18);
            this.cboQueryType.Name = "cboQueryType";
            this.cboQueryType.Size = new System.Drawing.Size(53, 21);
            this.cboQueryType.TabIndex = 22;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(86, 18);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(143, 20);
            this.txtLocation.TabIndex = 21;
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(239, 17);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(117, 23);
            this.btnGetWeather.TabIndex = 23;
            this.btnGetWeather.Text = "Get Weather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.BtnGetWeather_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pctWeatherIcon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblFeelsLike);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.lblPressure);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblCityID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCity);
            this.groupBox2.Controls.Add(this.lblWindDirection);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblWindSpeed);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblClouds);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblSunset);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblSunrise);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblCountry);
            this.groupBox2.Controls.Add(this.lblLongitude);
            this.groupBox2.Controls.Add(this.lblLatitude);
            this.groupBox2.Controls.Add(this.lblHumidity);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblTemperature);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 321);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Weather";
            // 
            // pctWeatherIcon
            // 
            this.pctWeatherIcon.BackColor = System.Drawing.SystemColors.Window;
            this.pctWeatherIcon.InitialImage = null;
            this.pctWeatherIcon.Location = new System.Drawing.Point(256, 21);
            this.pctWeatherIcon.Name = "pctWeatherIcon";
            this.pctWeatherIcon.Size = new System.Drawing.Size(100, 100);
            this.pctWeatherIcon.TabIndex = 59;
            this.pctWeatherIcon.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Like:";
            // 
            // lblFeelsLike
            // 
            this.lblFeelsLike.Location = new System.Drawing.Point(79, 78);
            this.lblFeelsLike.Name = "lblFeelsLike";
            this.lblFeelsLike.Size = new System.Drawing.Size(75, 13);
            this.lblFeelsLike.TabIndex = 57;
            this.lblFeelsLike.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(259, 124);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(97, 23);
            this.lblDescription.TabIndex = 56;
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPressure
            // 
            this.lblPressure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPressure.Location = new System.Drawing.Point(83, 196);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(112, 23);
            this.lblPressure.TabIndex = 53;
            this.lblPressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Pressure:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(239, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "ID:";
            // 
            // lblCityID
            // 
            this.lblCityID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCityID.Location = new System.Drawing.Point(261, 288);
            this.lblCityID.Name = "lblCityID";
            this.lblCityID.Size = new System.Drawing.Size(64, 23);
            this.lblCityID.TabIndex = 50;
            this.lblCityID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "City:";
            // 
            // lblCity
            // 
            this.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCity.Location = new System.Drawing.Point(261, 164);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(112, 23);
            this.lblCity.TabIndex = 48;
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWindDirection
            // 
            this.lblWindDirection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWindDirection.Location = new System.Drawing.Point(83, 165);
            this.lblWindDirection.Name = "lblWindDirection";
            this.lblWindDirection.Size = new System.Drawing.Size(112, 23);
            this.lblWindDirection.TabIndex = 47;
            this.lblWindDirection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Wind Direction:";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWindSpeed.Location = new System.Drawing.Point(83, 134);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(112, 23);
            this.lblWindSpeed.TabIndex = 45;
            this.lblWindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Wind Speed:";
            // 
            // lblClouds
            // 
            this.lblClouds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClouds.Location = new System.Drawing.Point(83, 289);
            this.lblClouds.Name = "lblClouds";
            this.lblClouds.Size = new System.Drawing.Size(112, 23);
            this.lblClouds.TabIndex = 43;
            this.lblClouds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Cloudiness:";
            // 
            // lblSunset
            // 
            this.lblSunset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSunset.Location = new System.Drawing.Point(83, 258);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(112, 23);
            this.lblSunset.TabIndex = 41;
            this.lblSunset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Sunset:";
            // 
            // lblSunrise
            // 
            this.lblSunrise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSunrise.Location = new System.Drawing.Point(83, 227);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(112, 23);
            this.lblSunrise.TabIndex = 39;
            this.lblSunrise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Sunrise:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Country:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Longitude:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Latitude:";
            // 
            // lblCountry
            // 
            this.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountry.Location = new System.Drawing.Point(261, 195);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(64, 23);
            this.lblCountry.TabIndex = 34;
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLongitude
            // 
            this.lblLongitude.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLongitude.Location = new System.Drawing.Point(261, 257);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(64, 23);
            this.lblLongitude.TabIndex = 33;
            this.lblLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLatitude
            // 
            this.lblLatitude.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLatitude.Location = new System.Drawing.Point(261, 226);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(64, 23);
            this.lblLatitude.TabIndex = 32;
            this.lblLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHumidity
            // 
            this.lblHumidity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHumidity.Location = new System.Drawing.Point(83, 103);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(112, 23);
            this.lblHumidity.TabIndex = 31;
            this.lblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Humidity:";
            // 
            // lblTemperature
            // 
            this.lblTemperature.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTemperature.Location = new System.Drawing.Point(65, 33);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(96, 28);
            this.lblTemperature.TabIndex = 28;
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGetWeather;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Current Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctWeatherIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboQueryType;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblSunrise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSunset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblClouds;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWindDirection;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCityID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblFeelsLike;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pctWeatherIcon;
    }
}

