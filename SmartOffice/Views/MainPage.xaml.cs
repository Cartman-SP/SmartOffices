using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microcharts;
using SkiaSharp;
using SmartOffice.Models;
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
                Color = SKColor.Parse("#FE0034"),
                Label = "9:00",
                ValueLabel = "7",
            },
            new Entry(9)
            {
                Color = SKColor.Parse("#FE0034"),
                Label = "10:00",
                ValueLabel = "9",
            },
            new Entry(6)
            {
                Color = SKColor.Parse("#FE0034"),
                Label = "11:00",
                ValueLabel = "6",
            },
            new Entry(18)
            {
                Color = SKColor.Parse("#FE0034"),
                Label = "12:00",
                ValueLabel = "18",
            },
            new Entry(0)
            {
                Color = SKColor.Parse("#FE0034"),
                Label = "13:00",
                ValueLabel = "0",
            },
            new Entry(12)
            {
                Color = SKColor.Parse("#FE0034"),
                Label = "14:00",
                ValueLabel = "12",
            }
        };

        public MainPage()
        {
            InitializeComponent();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(App.CurrentUser.firstname + App.CurrentUser.secondname);
            Console.WriteLine("----------------------------------------------------");

            username.Text = App.CurrentUser.firstname + " " + App.CurrentUser.secondname;
            //NavigationPage.SetHasNavigationBar(this, false);
            //MainChart.Chart = new LineChart { Entries = now, LabelTextSize = 30, Typeface = SKTypeface.FromFamilyName("MontserratBold"), BackgroundColor = SKColor.Parse("#00000f00"), LineSize = 7, PointSize = 20, LabelColor = SKColor.Parse("#2C2F34"), LineAreaAlpha = 0 };
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
        private async void onStories(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stories());
        }
        private async void onPlanned(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Planned());
        }
        private async void onStatistics(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Statistics());
        }
        private async void onTodos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Todos());
        }

    }
}