using Gateway.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gateway.API.Controllers
{
    [ApiController]
    [Route("/gateway")]
    [Authorize]
    public class DefaultController : ControllerBase
    {
        private readonly BusinessService businessService;
        public DefaultController(BusinessService businessService)
        {
            this.businessService = businessService;
        }
        [AllowAnonymous]
        [HttpGet("[action]")]
        [HttpGet("")]
        public async Task<string> Status()
        {
            return "Hello World!";
        }
        [HttpPost("[action]")]
        public async Task<string> Signin()
        {
            return "You are good to go!";        
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<WeatherForecast>> WeatherForecast()
        {
            return await businessService.GetWeatherForecasts();
        }
    }
}
