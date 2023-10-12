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
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(2000);
            /*
            if (Application.Current.Properties.ContainsKey("IsLoggedIn")&& (bool)Application.Current.Properties["IsLoggedIn"])
            {
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await Navigation.PushAsync(new Login());
            }
            Что бы при перезапуске приложения пользователю не пришлось авторизовываться по новой*/ 
            await Navigation.PushAsync(new Login());

        }

    }


}