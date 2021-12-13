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
        public static Rootobject info;
        public static string infostring;
        public static string lastUpdate;
        public MainPage()
        {
            InitializeComponent();
            try
            {
                infostring = (string)App.Current.Properties["Data"];
                lastUpdate = (string)App.Current.Properties["LastUpdate"];
                GetInfo();
            }
            catch
            {
                Label_Updated.Text = "Žádná data nejsou k dispozici";
            }
            
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                Label_Connection.IsVisible = false;
                GetInfo();
            }
            else
            {
                Label_Connection.IsVisible = true;
            }

            AsteroidListView.RefreshCommand = new Command(() =>
            {
                current = Connectivity.NetworkAccess;
                if (current == NetworkAccess.Internet)
                {
                    Label_Connection.IsVisible = false;
                    GetInfo();
                }
                else
                {
                    Label_Connection.IsVisible = true;
                }
                AsteroidListView.IsRefreshing = false;
            });
        }
        private async void GetInfo()
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                DateTime dt = DateTime.Now;
                string API_key = "J4Yf2ueQxs6t8OeWtQOJzP5mH2y99gJIgGezfgVE";
                string url = $"https://api.nasa.gov/neo/rest/v1/feed?start_date={dt.Year}-{dt.Month}-{dt.Day}&end_date={dt.Year}-{dt.Month}-{dt.Day}&api_key={API_key}";
                API_Response data = await API_Caller.Get(url);

                if (data.Successuful)
                {
                    Regex reg = new Regex(@"\d{4}[-]\d{2}[-]\d{2}");
                    string database = reg.Replace(data.Response, "date", 1, 500);

                    info = JsonConvert.DeserializeObject<Rootobject>(database);
                    lastUpdate = dt.ToString();
                }
            }
            else
            {
                info = JsonConvert.DeserializeObject<Rootobject>(infostring);
            }
            if(info != null)
            {
                AsteroidList = new ObservableCollection<Asteroid>(info.near_earth_objects.asteroids);
                AsteroidListView.ItemsSource = AsteroidList;
                Label_Updated.Text = $"Naposledy aktualizováno: {lastUpdate}";
            }
        }

        private void viewCell_Tapped(object sender, EventArgs e)
        {
            ViewCell v = sender as ViewCell;
            Navigation.PushAsync(new DescriptionPage(v.BindingContext as Asteroid));
        }
        
        public void SaveData()
        {
            App.Current.Properties["Data"] = JsonConvert.SerializeObject(info);
            App.Current.Properties["LastUpdate"] = lastUpdate;
        }
    }
}