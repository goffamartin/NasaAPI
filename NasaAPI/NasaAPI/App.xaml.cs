using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NasaAPI
{
    public partial class App : Application
    {
        MainPage mp;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(mp = new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#555555") 
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            mp.SaveData();
        }

        protected override void OnResume()
        {
        }
    }
}
