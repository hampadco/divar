using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.IO;

using System.Threading.Tasks;

using DivarApp.Models;

namespace DivarApp.Models
{
    public class DivarServices
    {
        private static HttpClient client;

        public static List<City> CityList { get; set; }

        static DivarServices()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://192.168.1.50:5461/api/DivarAPI/");

            CityList = new List<City>();
        }

        public static async Task<List<City>> GetCitiesAsync()
        {
            var cities = await client.GetStringAsync("GetCities/");

            var serializer = new JsonSerializer();

            using (var textReader = new StringReader(cities))
            {
                using (var jsonReader = new JsonTextReader(textReader))
                {
                    var allCities = serializer.Deserialize<List<City>>(jsonReader);

                    return allCities;
                }
            }
        }

        public static async Task<List<Products>> Getproduct()
        {
            var cities = await client.GetStringAsync("GetProduct/");

            var serializer = new JsonSerializer();

            using (var textReader = new StringReader(cities))
            {
                using (var jsonReader = new JsonTextReader(textReader))
                {
                    var allCities = serializer.Deserialize<List<Products>>(jsonReader);

                    return allCities;
                }
            }
        }



        public static async Task<List<Advert>> GetAdvertsAsync(int id)
        {
            var adverts = await client.GetStringAsync("GetAdvertsByCityId/" + id);

            var serializer = new JsonSerializer();

            using (var textReader = new StringReader(adverts))
            {
                using (var jsonReader = new JsonTextReader(textReader))
                {
                    var advertsbyCity = serializer.Deserialize<List<Advert>>(jsonReader);

                    return advertsbyCity;
                }
            }
        }




        public static async Task<List<Gallery>> GetGalleriesAsync(int id)
        {
            var galleries = await client.GetStringAsync("GetAdvertsGalleries/" + id);

            var serializer = new JsonSerializer();

            using (var textReader = new StringReader(galleries))
            {
                using (var jsonReader = new JsonTextReader(textReader))
                {
                    var advertGalleries = serializer.Deserialize<List<Gallery>>(jsonReader);

                    return advertGalleries;
                }
            }
        }

        public static string GetUserMobile(int id)
        {
            var user = client.GetStringAsync("GetUserMobileNumber/" + id);

            return user.Result;
        }

    }
}
