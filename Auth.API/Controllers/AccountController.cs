using Auth.API.Models;
using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static IdentityModel.OidcConstants;

namespace Auth.API.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AccountController : ControllerBase
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] ClientSigninModel clientSignInModel)
        {
            HttpClient httpClient = new HttpClient();
            var tokenResponse = httpClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = "http://localhost:5000/connect/token",
                ClientId = clientSignInModel.ClientId,
                ClientSecret = clientSignInModel.ClientSecret,
                Scope = "gateway-api"
            }).GetAwaiter().GetResult();
            return Ok(JsonConvert.DeserializeObject(tokenResponse.Raw));
        }
    }

}
