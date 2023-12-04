using DessignPattern.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DessignPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfigurationService _configuration;

        public ValuesController(IConfigurationService configuration)
        {
            _configuration = configuration;
        }



        [HttpGet]
        public void Get(string name)
        {
            _configuration.GetValue(name);
        }
    }
}
