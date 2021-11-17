using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace NasaAPI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetInfo();
            
        }
        private async void GetInfo()
        {
            string url = "https://api.nasa.gov/neo/rest/v1/feed?start_date=2021-09-10&end_date=2021-09-10&api_key=J4Yf2ueQxs6t8OeWtQOJzP5mH2y99gJIgGezfgVE";
            API_Response data = await API_Caller.Get(url);

            if (data.Successuful)
            {
                Regex reg = new Regex(@"\d{4}[-]\d{2}[-]\d{2}");
                string database = reg.Replace(data.Response, "date",1,500);
                var info = JsonConvert.DeserializeObject<Rootobject>(database);
                Console.WriteLine(info.near_earth_objects.asteroids[0].close_approach_data[0].close_approach_date);
            }
        }
    }
}
