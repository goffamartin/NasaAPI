using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

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
            string url = "https://api.nasa.gov/neo/rest/v1/feed?start_date=2021-09-10end_date=2021-09-10&api_key=J4Yf2ueQxs6t8OeWtQOJzP5mH2y99gJIgGezfgVE";
            API_Response data = await API_Caller.Get(url);

            if (data.Successuful)
            {
                var info = JsonConvert.DeserializeObject<Rootobject>(data.Response);
                Console.WriteLine(info.links.next);
            }
        }
    }
}
