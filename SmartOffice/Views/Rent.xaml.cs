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
    public partial class Rent : ContentPage
    {
        public Rent()
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
    }
}