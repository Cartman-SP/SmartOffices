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
    public partial class Location : ContentPage
    {
        public Location()
        {
            InitializeComponent();
        }

        private async void OnMain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}