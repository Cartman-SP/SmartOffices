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
        double x, y;
        public Location()
        {
            InitializeComponent();
        }

        private async void OnMain(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void OnLight(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new YeelightPage());
        }

        private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            double x = movableImage.TranslationX + e.TotalX;
            double y = movableImage.TranslationY + e.TotalY;

            // Ограничение перемещения по горизонтали до ±200 пикселей
            if (x < -400)
                x = -400;
            else if (x > 200)
                x = 200;

            // Ограничение перемещения по вертикали до ±200 пикселей
            if (y < -50)
                y = -50;
            else if (y > 50)
                y = 50;

            // Установка нового положения изображения
            movableImage.TranslationX = x;
            movableImage.TranslationY = y;
        }

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    if (!this.popuplayout.IsVisible)
        //    {
        //        this.popuplayout.IsVisible = !this.popuplayout.IsVisible;
        //        await Task.WhenAny<bool>
        //          (
        //            this.popuplayout.TranslateTo(0, 0, easing: Easing.CubicOut)
        //          );


        //    }
        //    else
        //    {

        //        await Task.WhenAny<bool>
        //          (
        //            this.popuplayout.TranslateTo(0, 500, easing: Easing.CubicOut)
        //          );
        //        this.popuplayout.IsVisible = !this.popuplayout.IsVisible;
        //    }
        //}
    }
}
