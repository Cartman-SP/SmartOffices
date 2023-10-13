using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartOffice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
        }



        private async void ChangeImage_Clicked(object sender, EventArgs e)
        {
            // Здесь добавьте код для выбора нового изображения и установки его в элемент Image (UserProfileImage)
            try
            {
                var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium
                });

                if (file != null)
                {
                    UserProfileImage.Source = ImageSource.FromStream(() =>
                    {
                        var stream = file.GetStream();
                        return stream;
                    });
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибки, если возникнет проблема с выбором изображения
                await DisplayAlert("Ошибка", "Не удалось выбрать изображение: " + ex.Message, "OK");
            }
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            string surname = surnameEntry.Text;
            string email = emailEntry.Text;
            string phone = phoneEntry.Text;
            // Здесь вы можете сохранить новые данные в переменные или отправить на сервер, в зависимости от вашей логики.
            // Здесь будет отправляться запрос на сервер
            DisplayAlert("Успех", "Профиль успешно обновлен", "ОК");
        }
    }
}
