using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YeelightAPI;

namespace SmartOffice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YeelightPage : ContentPage
    {
        public YeelightPage()
        {
            InitializeComponent();
        }

        private async void TurnOnButton_Clicked(object sender, EventArgs e)
        {
            string ipAddress = IPAddressEntry.Text; // Получаем IP-адрес из текстового поля
            var device = new YeelightAPI.Device(ipAddress);

            if (await device.Connect())
            {
                await device.SetPower(true);
                device.Disconnect();

            }
            else
            {
                await DisplayAlert("Ошибка", "Не удалось подключиться к устройству", "OK");
            }
        }

        private async void TurnOffButton_Clicked(object sender, EventArgs e)
        {
            string ipAddress = IPAddressEntry.Text; // Получаем IP-адрес из текстового поля
            var device = new YeelightAPI.Device(ipAddress);

            if (await device.Connect())
            {
                await device.SetPower(false);
                device.Disconnect();

            }
            else
            {
                await DisplayAlert("Ошибка", "Не удалось подключиться к устройству", "OK");
            }
        }
        private async void ChangeColorButton_Clicked(object sender, EventArgs e)
        {
            string ipAddress = IPAddressEntry.Text;
            YeelightAPI.Device device = new YeelightAPI.Device(ipAddress);

            if (await device.Connect())
            {
                // Здесь можно задать новый цвет
                await device.SetRGBColor(255, 0, 0);
                device.Disconnect();

            }
            else
            {
                await DisplayAlert("Ошибка", "Не удалось подключиться к устройству", "OK");
            }
        }
        private async void ChangeBrightnessButton_Clicked(object sender, EventArgs e)
        {
            string ipAddress = IPAddressEntry.Text;
            YeelightAPI.Device device = new YeelightAPI.Device(ipAddress);

            if (await device.Connect())
            {
                // Здесь можно задать новую яркость (от 1 до 100)
                await device.SetBrightness(100); // Например, половина максимальной яркости
                device.Disconnect();

            }
            else
            {
                await DisplayAlert("Ошибка", "Не удалось подключиться к устройству", "OK");
            }
        }
    }
}
