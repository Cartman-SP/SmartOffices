using SmartOffice.Models;
using SmartOffice.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
