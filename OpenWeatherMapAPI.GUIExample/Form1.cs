using System;
using System.Windows.Forms;

namespace OpenWeatherMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Query code string array to pass to API
        // q: Use cityname or
        //    cityname, country code or
        //    cityname, statecode, countrycode
        //    q also returns unique city ID
        // zip: Use zipcode (US Zip Codes by default) or zipcode, countrycode
        // id: OpenWeatherMap unique City ID
        // The array is parallel to the combobox
        private readonly string[] QueryCodes = { "q", "zip", "id", };
        
        // Base url to build the query string
        private const string iconUrl = "http://openweathermap.org/img/wn/";

        // OpenWeatherMap API key object
        private const string apiKey = "Your API Code Here";

        private void BtnGetWeather_Click(object sender, EventArgs e)
        {
            try
            {
                // Create webclient from API to request html data from OpenWeatherMap
                var client = new OpenWeatherMapAPI.API(apiKey);
                
                // Get the location info from the user
                string location = txtLocation.Text;

                // Return the querytype based on the comboBox selection: q, zip, id
                string queryType = QueryCodes[cboQueryType.SelectedIndex];

                // Weather data from OpenWeatherMapAPI query
                var results = client.Query(location, queryType);

                // Fahrenheit temperature
                lblTemperature.Text = results.Main.Temperature.FahrenheitCurrent.ToString("n1") + "°F";
                
                // Air pressure in inches of mercury
                lblPressure.Text = (results.Main.PressureInchesOfMercury.ToString("n1") + " in");
                
                // Display weather description in Title Case
                lblDescription.Text = results.Weathers[0].DescriptionTitleCase.ToString();
        
                // OpenWeatherMap.org icons
                pctWeatherIcon.ImageLocation = iconUrl + results.Weathers[0].Icon + "@2x.png";
            }
            catch (Exception)
            {
                // Let the user know something went wrong
                MessageBox.Show("That didn't work. \nPlease try another entry.");
                // Prepare for next entry
                txtLocation.Focus();
                txtLocation.SelectAll();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add location query items to list
            // This order should match the query code array
            cboQueryType.Items.Add("City");
            cboQueryType.Items.Add("Zip");
            cboQueryType.Items.Add("City ID");

            // Set ZIP as initial location query choice
            cboQueryType.SelectedIndex = 1;

            // Set focus on Location text box
            txtLocation.Focus();
            txtLocation.SelectAll();
        }
    }
}
