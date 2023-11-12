using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SmartOffice.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
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
            var username = usernameEntry.Text;
            var password = passwordEntry.Text;

            var user = await AuthenticateUser(username, password);

            if (user != null)
            {
                App.CurrentUser = user;
                Application.Current.Properties["IsLoggedIn"] = true;
                await Application.Current.SavePropertiesAsync();
                await Navigation.PushAsync(new MainPage());
            }

        }
        public async Task<User> AuthenticateUser(string username, string password)
        {
            var client = new HttpClient();
            var requestData = new { username = username, password = password };
            var json = JsonConvert.SerializeObject(requestData);
            Console.WriteLine(json + '\n' + Convert.ToString(json));
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://hedgeoffice.ru/authenticate/", content);
            Console.WriteLine(Convert.ToString(response));
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<User>(jsonResponse);
                Console.WriteLine(response.Content);
                return user;
            }
            return null;
        }
    }
}