using System;
using System.Threading.Tasks;
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

        private async void PowerSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            string ipAddress = IPAddressEntry.Text; // Получаем IP-адрес из текстового поля
            var device = new YeelightAPI.Device(ipAddress);

            if (await device.Connect())
            {
                await device.SetPower(e.Value); // Используем значение переключателя для включения/выключения
                device.Disconnect();
            }
            else
            {
                await DisplayAlert("Ошибка", "Не удалось подключиться к устройству", "OK");
            }
        }
        private async void SetColorRed_Clicked(object sender, EventArgs e)
        {
            await SetColor(255, 0, 0); // Красный цвет
        }

        private async void SetColorOrange_Clicked(object sender, EventArgs e)
        {
            await SetColor(255, 165, 0); // Оранжевый цвет
        }

        private async void SetColorYellow_Clicked(object sender, EventArgs e)
        {
            await SetColor(255, 255, 0); // Желтый цвет
        }

        private async void SetColorGreen_Clicked(object sender, EventArgs e)
        {
            await SetColor(0, 128, 0); // Зеленый цвет
        }

        private async void SetColorBlue_Clicked(object sender, EventArgs e)
        {
            await SetColor(0, 0, 255); // Голубой цвет
        }

        private async void SetColorPurple_Clicked(object sender, EventArgs e)
        {
            await SetColor(128, 0, 128); // Фиолетовый цвет
        }

        private async Task SetColor(int red, int green, int blue)
        {
            string ipAddress = IPAddressEntry.Text;
            var device = new YeelightAPI.Device(ipAddress);

            if (await device.Connect())
            {
                await device.SetRGBColor(red, green, blue);
                device.Disconnect();
            }
            else
            {
                await DisplayAlert("Ошибка", "Не удалось подключиться к устройству", "OK");
            }
        }


        private async void SetBrightness20_Clicked(object sender, EventArgs e)
        {
            await SetBrightness(20);
        }

        private async void SetBrightness40_Clicked(object sender, EventArgs e)
        {
            await SetBrightness(40);
        }

        private async void SetBrightness60_Clicked(object sender, EventArgs e)
        {
            await SetBrightness(60);
        }

        private async void SetBrightness80_Clicked(object sender, EventArgs e)
        {
            await SetBrightness(80);
        }

        private async void SetBrightness100_Clicked(object sender, EventArgs e)
        {
            await SetBrightness(100);
        }

        private async Task SetBrightness(int brightness)
        {
            string ipAddress = IPAddressEntry.Text;
            var device = new YeelightAPI.Device(ipAddress);

            if (await device.Connect())
            {
                await device.SetBrightness(brightness);
                device.Disconnect();
            }
            else
            {
                await DisplayAlert("Ошибка", "Не удалось подключиться к устройству", "OK");
            }
        }
        private bool isColorFlowRunning = false;
        private async void StartColorFlow_Clicked(object sender, EventArgs e)
        {
            if (isColorFlowRunning)
            {
                isColorFlowRunning = false;
            }
            else
            {
                isColorFlowRunning = true;
                await StartColorFlow();
            }
        }

        private async Task StartColorFlow()
        {
            string ipAddress = IPAddressEntry.Text;
            var device = new YeelightAPI.Device(ipAddress);

            if (await device.Connect())
            {
                isColorFlowRunning = true;

                while (isColorFlowRunning)
                {
                    // Генерируйте случайные значения для RGB цвета
                    Random random = new Random();
                    int red = random.Next(256);
                    int green = random.Next(256);
                    int blue = random.Next(256);

                    await device.SetRGBColor(red, green, blue);

                    // Задержка между сменой цвета
                    await Task.Delay(1000); // Задержка в 1 секунду
                }

                device.Disconnect();
            }
            else
            {
                await DisplayAlert("Ошибка", "Не удалось подключиться к устройству", "OK");
            }
        }

    }
}
