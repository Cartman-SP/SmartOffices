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
    public partial class Planned : ContentPage
    {
        public Planned()
        {
            InitializeComponent();
        }
        private async void OnMain(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}