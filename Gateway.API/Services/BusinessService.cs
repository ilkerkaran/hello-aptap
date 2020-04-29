using Gateway.API.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gateway.API.Services
{
    public class BusinessService
    {
        BusinessApiClient busApiClient;
        public BusinessService(BusinessApiClient busApiClient)
        {
            this.busApiClient = busApiClient;
        }        


        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecasts()
        {
            return await busApiClient.GetWeatherForecasts();
        }
    }
}
