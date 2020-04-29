using Gateway.API.Config;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gateway.API.Clients
{
    public class BusinessApiClient
    {

        private readonly HttpClient client;
        public BusinessApiClient(HttpClient client)
        {          
            this.client = client;
        }

        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecasts()
        {
            try
            {
                var res = await client.GetAsync("/WeatherForecast");
                if (res.IsSuccessStatusCode)
                {
                    var jsonString = await res.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(jsonString);
                }
                else
                {
                    // TODO: do some logging
                    throw new Exception(res.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                // TODO: do some logging
                throw;
            }
        }
    }
}
