using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using WeatherApp.Properties;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            lblTime.Text = DateTime.Now.ToShortTimeString();
            lblDateTime.Text = DateTime.Now.ToShortDateString();
            
            
            string ApiKey = "929977310ebe0e7f3b4335cff2c8184a";// You should write your own api key here  

            string ConnectionIstanbul = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + ApiKey;
            XDocument xDocument = XDocument.Load(ConnectionIstanbul);

            lblCity.Text = xDocument.Descendants("city").ElementAt(0).Attribute("name").Value;
            lblTemp.Text = xDocument.Descendants("temperature").ElementAt(0).Attribute("value").Value + " °C";
            lblWind.Text = xDocument.Descendants("speed").ElementAt(0).Attribute("value").Value + " m/s";
            lblHumidity.Text = xDocument.Descendants("humidity").ElementAt(0).Attribute("value").Value + " %";
            
            if(xDocument.Descendants("precipitation").ElementAt(0).Attribute("mode").Value == "no")
            {
                lblPrecip.Text = "0 %";
            }
            else
            {
                lblPrecip.Text = xDocument.Descendants("precipitation").ElementAt(0).Attribute("value").Value + " %" +
                    " "+xDocument.Descendants("precipitation").ElementAt(0).Attribute("mode").Value;

            }

            lblFelt.Text = xDocument.Descendants("feels_like").ElementAt(0).Attribute("value").Value + " °C";

            var weather = xDocument.Descendants("weather").ElementAt(0).Attribute("value").Value;

            lblWeather.Text = weather.ToUpper();

            if(weather == "açık")
            {
                ptbIcon.Image = Resources.günesli;
            }
            else if(weather == "yağmurlu")
            {
                ptbIcon.Image = Resources.yagmurlu;
            }
            else if (weather == "gök gürültülü")
            {
                ptbIcon.Image = Resources.gokgurultulu;
            }
            else if (weather == "sisli")
            {
                ptbIcon.Image = Resources.sisli;
            }
            else if (weather == "parçalı bulutlu")
            {
                ptbIcon.Image = Resources.parçalıbulutlu;
            }
            else if (weather == "karlı")
            {
                ptbIcon.Image = Resources.karlı;
            }
            else if (weather == "kapalı")
            {
                ptbIcon.Image = Resources.kapalı;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit the application?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }
    }
}
