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
    public partial class Loading : ContentPage
    {
        public Loading()
        {
            InitializeComponent();
            //FadeInImage(Hedge);
            //PulseImage(Hedge);
        }
        async void FadeInImage(Image Hedge)
        {
            
            Hedge.Opacity = 0;

            
            await Hedge.FadeTo(1, 2800); 
        }
        async void PulseImage(Image Hedge)
        {
            await Task.Delay(2800);
            while (true)
            {
                await Hedge.ScaleTo(1.1, 500);
                await Hedge.ScaleTo(1.0, 500);

            }
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            await Task.Delay(2000);

            //if (Application.Current.Properties.ContainsKey("IsLoggedIn") && (bool)Application.Current.Properties["IsLoggedIn"])
            //{
            //    await Navigation.PushAsync(new MainPage());
            //}
            //else
            //{
            //    await Navigation.PushAsync(new Login());
            //}
            ////Что бы при перезапуске приложения пользователю не пришлось авторизовываться по новой

            await Navigation.PushAsync(new Login());

        }

    }


}