using DessignPattern.Application.Services;
using DessignPattern.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DessignPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IConfigurationService _configurationService;

        public CustomerController(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        [HttpGet]
        public void Get(string name)
        {
            _configurationService.GetValue(name);

        }

    }
}
