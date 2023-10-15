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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void OnSign(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sign());
        }
        private async void OnMain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void OnHelp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Help());
        }
    }
}