using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NasaAPI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DescriptionPage : ContentPage
    {
        public DescriptionPage(Asteroid a)
        {
            InitializeComponent();
            A_Name.Text = a.name;
            A_Date.Text = a.close_approach_data[0].close_approach_date_full;
            A_Hazardous.Text = a.is_potentially_hazardous_asteroid ? "Ano" : "Ne";
            A_Speed_kmps.Text = $"{a.close_approach_data[0].relative_velocity.kilometers_per_second} km/s";
            A_Speed_kmph.Text = $"{a.close_approach_data[0].relative_velocity.kilometers_per_hour} km/h";
            A_Speed_mph.Text = $"{a.close_approach_data[0].relative_velocity.miles_per_hour} mi/h";
            A_Diameter_km.Text = $"{a.estimated_diameter.kilometers.estimated_diameter_min} - {a.estimated_diameter.kilometers.estimated_diameter_max} km";
            A_Diameter_m.Text = $"{a.estimated_diameter.meters.estimated_diameter_min} - {a.estimated_diameter.meters.estimated_diameter_max} m";
            A_Diameter_mi.Text = $"{a.estimated_diameter.miles.estimated_diameter_min} - {a.estimated_diameter.miles.estimated_diameter_max} mi";
            A_Diameter_ft.Text = $"{a.estimated_diameter.feet.estimated_diameter_min} - {a.estimated_diameter.feet.estimated_diameter_max} ft (stopy)";
            A_Distance_km.Text = $"{a.close_approach_data[0].miss_distance.kilometers} km";
            A_Distance_au.Text = $"{a.close_approach_data[0].miss_distance.astronomical} au";
            A_Distance_mi.Text = $"{a.close_approach_data[0].miss_distance.miles} mi";
            A_Distance_LD.Text = $"{a.close_approach_data[0].miss_distance.lunar} LD";
        }
    }
}