using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartOffice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Location : ContentPage
    {
        private double maxY = 0;
        public Location()
        {
            InitializeComponent();
            var panGesture = new PanGestureRecognizer();
            panGesture.PanUpdated += OnPanUpdated;
            DraggableContainer.GestureRecognizers.Add(panGesture);
        }

        private async void OnMain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void OnLight(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new YeelightPage());
        }
        private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Started:
                    // Сохраняем начальное положение элемента
                    maxY = DraggableContainer.TranslationY;
                    break;
                case GestureStatus.Running:
                    // Обработка перетаскивания в реальном времени.
                    double newY = maxY + e.TotalY;

                    // Задаем максимальную длину перетаскивания
                    double maxDragDistance = 300; // Измените на желаемое значение.

                    // Проверяем, не превышает ли перемещение максимальное значение.
                    if (Math.Abs(newY) <= maxDragDistance)
                    {
                        DraggableContainer.TranslationY = newY;
                    }
                    break;
                case GestureStatus.Completed:
                    // Действия, выполняемые после завершения перетаскивания (если требуется).
                    break;
            }
        }
    }
}