using SmartOffice.Models;
using SmartOffice.Views;
using Xamarin.Forms;

[assembly: ExportFont("Montserrat_Regular.ttf", Alias = "MontserratRegular")]
[assembly: ExportFont("Montserrat_Bold.ttf", Alias = "MontserratBold")]

namespace SmartOffice
{
    public partial class App : Application
    {
        public static User CurrentUser { get; set; }
        public App()
        {
            InitializeComponent();

            var regularFont = Font.SystemFontOfSize(20);
            var boldFont = Font.SystemFontOfSize(20, FontAttributes.Bold);

            MainPage = new NavigationPage(new Loading());
        }



        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
