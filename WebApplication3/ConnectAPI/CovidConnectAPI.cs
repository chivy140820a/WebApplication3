using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ConnectAPI
{
    public class CovidConnectAPI : ICovidConnectAPI
    {
        public async Task<List<APICoronavirusCountry>> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUri = "https://corona.lmao.ninja/v3/covid-19/countries?sort=cases";

                HttpResponseMessage apiResponse = await client.GetAsync(requestUri);

                string jsonResponse = await apiResponse.Content.ReadAsStringAsync();

                List<APICoronavirusCountry> apiCountries = JsonSerializer.Deserialize<List<APICoronavirusCountry>>(jsonResponse, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var list = apiCountries;
                return list;
            }
        }

        public async Task<List<LatLongCountry>> GetAllLG()
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUri = "https://corona.lmao.ninja/v3/covid-19/countries?sort=cases";

                HttpResponseMessage apiResponse = await client.GetAsync(requestUri);

                string jsonResponse = await apiResponse.Content.ReadAsStringAsync();

                List<LatLongCountry> apiCountries = JsonSerializer.Deserialize<List<LatLongCountry>>(jsonResponse, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var list = apiCountries;
                return list;


            }
        }
    }
}
