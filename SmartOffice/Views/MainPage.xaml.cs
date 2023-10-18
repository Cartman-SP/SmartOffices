using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartOffice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

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