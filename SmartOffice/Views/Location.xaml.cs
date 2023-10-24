using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
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
        private async void OnLight(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new YeelightPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!this.popuplayout.IsVisible)
            {
                this.popuplayout.IsVisible = !this.popuplayout.IsVisible;
                await Task.WhenAny<bool>
                  (
                    this.popuplayout.TranslateTo(0, 0, easing: Easing.SinIn)
                  );
                

            }
            else
            {
                
                await Task.WhenAny<bool>
                  (
                    this.popuplayout.TranslateTo(0, 500, easing: Easing.SinIn)
                  );
                this.popuplayout.IsVisible = !this.popuplayout.IsVisible;
            }
        }
    }
}
