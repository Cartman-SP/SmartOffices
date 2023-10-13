using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace SmartOffice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRauth : ContentPage
    {
        public QRauth()
        {
            InitializeComponent();
        }


        public ZXingBarcodeImageView GenerateQRCode(string userId)
        {
            var currentTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
            var content = $"UserID:{userId}|Time:{currentTime}";

            var barcode = new ZXingBarcodeImageView
            {
                HorizontalOptions = Xamarin.Forms.LayoutOptions.FillAndExpand,
                VerticalOptions = Xamarin.Forms.LayoutOptions.FillAndExpand,
            };


        }
        private async void OnMain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

            barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            barcode.BarcodeOptions.Width = 300;
            barcode.BarcodeOptions.Height = 300;
            barcode.BarcodeValue = content;

            return barcode;
        }

        protected override void OnAppearing()
        {
            qrCodeImage.Source = GenerateQRCode("1").Source;
        }

    }
}
