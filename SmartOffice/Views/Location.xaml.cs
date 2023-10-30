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
        private double startX, startY;
        private double offsetX, offsetY;
        private bool isMoving = false;
        public Location()
        {
            InitializeComponent();
            // Добавляем обработчики жестов
            var panGesture = new PanGestureRecognizer();
            panGesture.PanUpdated += OnImagePanUpdated;
            movableImage.GestureRecognizers.Add(panGesture);
        }

        private async void OnMain(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void OnLight(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new YeelightPage());
        }

        private void OnImagePanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Started:
                    if (movableImage.Bounds.Contains(e.TotalX, e.TotalY))
                    {
                        isMoving = true;
                        startX = e.TotalX;
                        startY = e.TotalY;
                        offsetX = movableImage.TranslationX;
                        offsetY = movableImage.TranslationY;
                    }
                    break;

                case GestureStatus.Running:
                    if (isMoving)
                    {
                        movableImage.TranslationX = offsetX + e.TotalX - startX;
                        movableImage.TranslationY = offsetY + e.TotalY - startY;
                    }
                    break;

                case GestureStatus.Completed:
                case GestureStatus.Canceled:
                    isMoving = false;
                    break;
            }
            // Добавьте отладочный вывод для проверки
            System.Diagnostics.Debug.WriteLine($"X: {movableImage.TranslationX}, Y: {movableImage.TranslationY}");
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
