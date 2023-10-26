using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.ChartEntry;

namespace SmartOffice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        List<Entry> now = new List<Entry>
        {
            new Entry(7)
            {
                Color = SKColor.Parse("#ffffff"),
                Label = "9:00",
                ValueLabel = "7",
            },
            new Entry(9)
            {
                Color = SKColor.Parse("#ffffff"),
                Label = "10:00",
                ValueLabel = "9",
            },
            new Entry(6)
            {
                Color = SKColor.Parse("#ffffff"),
                Label = "11:00",
                ValueLabel = "6",
            },
            new Entry(18)
            {
                Color = SKColor.Parse("#ffffff"),
                Label = "12:00",
                ValueLabel = "18",
            },
            new Entry(0)
            {
                Color = SKColor.Parse("#ffffff"),
                Label = "13:00",
                ValueLabel = "0",
            },
            new Entry(12)
            {
                Color = SKColor.Parse("#ffffff"),
                Label = "14:00",
                ValueLabel = "12",
            }
        };

        public MainPage()
        {
            InitializeComponent();

            //NavigationPage.SetHasNavigationBar(this, false);
            MainChart.Chart = new LineChart { Entries = now, LabelTextSize = 30, Typeface = SKTypeface.FromFamilyName("MontserratBold"), BackgroundColor = SKColor.Parse("#00000f00"), LineSize = 7, PointSize = 20, LabelColor = SKColor.Parse("#000000"), LineAreaAlpha = 0 };
        }

        private async void OnNotify(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Notification());
        }
        private async void OnProfile(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile());
        }
        private async void OnQRauth(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QRauth());
        }
        private async void OnLocation(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Location());
        }
        private async void OnRent(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Rent());
        }
        private async void OnHelp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Help());
        }
    }
}