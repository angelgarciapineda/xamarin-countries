using Countries.Cross.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Cross.Services
{
    public static class CountryService
    {
        private static readonly HttpClient client = CrearHttpClient();

        private static HttpClient CrearHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }

        public async static Task<List<Country>> GetCountries()
        {
            try
            {
                var response = await client.GetAsync($"https://restcountries.eu/rest/v2/all?fields=name;flag");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Country>>(json);
                }
            }
            catch (Exception ex)
            {
            }

            return default;
        }

    }
}
