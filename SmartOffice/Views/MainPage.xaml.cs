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
        List<Entry> entries = new List<Entry>
        {
            new Entry(10)
            {
                Color = SKColor.Parse("#498C8A"),
                Label = "sample",
            },
            new Entry(20)
            {
                Color = SKColor.Parse("#498C8A"),
                Label = "sample",
            },
            new Entry(5)
            {
                Color = SKColor.Parse("#498C8A"),
                Label = "sample",
            }
        };

        public MainPage()
        {
            InitializeComponent();

            //NavigationPage.SetHasNavigationBar(this, false);
            MainChart.Chart = new LineChart { Entries = entries };

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