using SmartOffice.Models;
using SmartOffice.Views;
using Xamarin.Forms;

namespace SmartOffice
{
    public partial class App : Application
    {
        public static User CurrentUser { get; set; }
        public App()
        {
            InitializeComponent();
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
