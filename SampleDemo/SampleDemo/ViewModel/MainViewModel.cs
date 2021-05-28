using Newtonsoft.Json;
using SampleDemo.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace SampleDemo.ViewModel
{
    public class MainViewModel
    {
        private readonly HttpClient client;

        public ObservableCollection<User> Users { get; set; }

        public MainViewModel()
        {
            Users = new ObservableCollection<User>();
            client = new HttpClient();
            GetUsers();
        }

        private async void GetUsers()
        {
            try
            {
                var result = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsStringAsync();
                    Users = new ObservableCollection<User>(JsonConvert.DeserializeObject<IList<User>>(data));
                }
            }
            catch (System.Exception ex)
            {

            }
        }
    }
}
