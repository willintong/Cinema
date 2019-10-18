using CinemaWAL.Domain;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace CinemaWAL.Helper
{
    class ApiHelper
    {

        public static T Get<T>(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://misapis.azurewebsites.net");

            var request = client.GetAsync(url).Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<T>(responseJson);

                return response;
            }

            return default(T);
        }

        public static T Post<T>(string url, Usuario usuario)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://misapis.azurewebsites.net");


            var json = JsonConvert.SerializeObject(usuario);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

            var request = client.PostAsync(url, stringContent).Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<T>(responseJson);

                return response;
            }

            return default(T);
        }
    }
}
