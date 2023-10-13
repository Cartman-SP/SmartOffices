﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartOffice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRauth : ContentPage
    {
        public QRauth()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var userId = "ВашUserID";
            var currentTime = DateTime.UtcNow.ToString("o");
            var textToEncode = $"{userId}|{currentTime}";


        }
        private async void OnMain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
