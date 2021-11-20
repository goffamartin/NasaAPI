using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;
using Xamarin.Essentials;

namespace NasaAPI
{
    public partial class MainPage : ContentPage
    {
        public static ObservableCollection<Asteroid> AsteroidList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                GetInfo();
            }
            else
            {

            }

            AsteroidListView.RefreshCommand = new Command(() =>
            {
                current = Connectivity.NetworkAccess;
                if (current == NetworkAccess.Internet)
                {
                    GetInfo();                
                }
                AsteroidListView.IsRefreshing = false;
            });
        }
        private async void GetInfo()
        {
            DateTime dt = DateTime.Now;
            string API_key = "J4Yf2ueQxs6t8OeWtQOJzP5mH2y99gJIgGezfgVE";
            string url = $"https://api.nasa.gov/neo/rest/v1/feed?start_date={dt.Year}-{dt.Month}-{dt.Day}&end_date={dt.Year}-{dt.Month}-{dt.Day}&api_key={API_key}";
            API_Response data = await API_Caller.Get(url);

            if (data.Successuful)
            {
                Regex reg = new Regex(@"\d{4}[-]\d{2}[-]\d{2}");
                string database = reg.Replace(data.Response, "date",1,500);

                var info = JsonConvert.DeserializeObject<Rootobject>(database);

                AsteroidList = new ObservableCollection<Asteroid>(info.near_earth_objects.asteroids);
                AsteroidListView.ItemsSource = AsteroidList;

                Label_Updated.Text = $"Naposledy aktualizováno: {dt}";
            }
        }

        private void viewCell_Tapped(object sender, EventArgs e)
        {
            ViewCell v = sender as ViewCell;
            Navigation.PushAsync(new DescriptionPage(v.BindingContext as Asteroid));
        }
    }
}