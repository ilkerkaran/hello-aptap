using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Gateway.API.Controllers
{
    [ApiController]
    [Route("/gateway")]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        [HttpGet("")]
        public async Task<string> Status()
        {
            return "Hello World!";
        }
    }
}
