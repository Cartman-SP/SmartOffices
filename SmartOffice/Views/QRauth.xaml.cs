using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;
using static System.Net.WebRequestMethods;

namespace SmartOffice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRauth : ContentPage
    {
        public QRauth()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(App.CurrentUser.firstname + App.CurrentUser.secondname);
            Console.WriteLine("----------------------------------------------------");
            InitializeComponent();
            QRCodeView.BarcodeValue = "http://daniilcv.beget.tech/qr_scan/" + App.CurrentUser.id + "/";
        }

        private async void OnMain(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
