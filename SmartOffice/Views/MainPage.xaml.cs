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

            var carouselItems = new List<CarouselItem>
            {
                new CarouselItem { ImageSource = "https://avatars.mds.yandex.net/i?id=f62e3591eb2b823056f532e88b2eb60890c9d4bf-9052192-images-thumbs&n=13" },
                new CarouselItem { ImageSource = "https://avatars.mds.yandex.net/i?id=aa4aa525c6b9cafe23ddf51eeff33078fdfd2a4c-9843030-images-thumbs&n=13" },
                new CarouselItem { ImageSource = "https://avatars.mds.yandex.net/i?id=c06f4a3bc130dee88a1e39024acf9a330b0f9b7b-5232019-images-thumbs&n=13" }
            };

            imageCarousel.ItemsSource = carouselItems;


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
    public class CarouselItem
    {
        public string ImageSource { get; set; }
    }



}