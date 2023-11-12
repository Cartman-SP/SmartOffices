using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SmartOffice.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Runtime.InteropServices;

namespace SmartOffice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sign : ContentPage
    {
        public Sign()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            var username1 = usernameEntry.Text;
            var password1 = passwordEntry.Text;

            var user = await AuthenticateUser(username1, password1);

            if (user != null)
            {
                App.CurrentUser = user;
                Application.Current.Properties["IsLoggedIn"] = true;
                await Application.Current.SavePropertiesAsync();
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                // Отобразите сообщение об ошибке пользователю
                await DisplayAlert("Ошибка", "Неверное имя пользователя или пароль", "OK");
            }
        }

        public async Task<User> AuthenticateUser(string username1, string password1)
        {
            var client = new HttpClient();
            var requestData = new { username = username1, password = password1 };
            var json = JsonConvert.SerializeObject(requestData);
            Console.WriteLine(json + '\n' + Convert.ToString(json));
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://hedgeoffice.ru/authenticate/", content);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();

                // Простая обработка вложенного JSON
                var userTokenObject = JsonConvert.DeserializeAnonymousType(jsonResponse, new { user = new User(), token = "" });

                // Теперь у вас есть доступ к объекту User и токену
                Console.WriteLine($"ID пользователя: {userTokenObject.user.id}");
                Console.WriteLine($"Имя пользователя: {userTokenObject.user.username}");

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(jsonResponse);
                Console.WriteLine("----------------------------------------------------");

                return userTokenObject.user;
            }

            return null;
        }
    }
}
