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
                new CarouselItem { ImageSource = "https://avatars.mds.yandex.net/i?id=91743fdd0c5306a3103e9e5b15d14dc7d6e73bb8-10934180-images-thumbs&n=13" },
                new CarouselItem { ImageSource = "https://avatars.mds.yandex.net/i?id=aa4aa525c6b9cafe23ddf51eeff33078fdfd2a4c-9843030-images-thumbs&n=13" },
                new CarouselItem { ImageSource = "https://i.pinimg.com/originals/ed/76/5b/ed765be802204933f04f710dbc96c9df.jpg" }
            };

            imageCarousel.ItemsSource = carouselItems;

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