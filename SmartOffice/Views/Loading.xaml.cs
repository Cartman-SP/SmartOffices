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
            await Navigation.PushAsync(new Login());
        }

    }


}