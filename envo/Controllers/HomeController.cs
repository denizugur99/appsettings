using Microsoft.AspNetCore.Mvc;

namespace envo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;
      

        public HomeController(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
           
        }

        [HttpGet]

        public IActionResult Index()
        {
            return Ok(new
            {
                Environment = _environment.EnvironmentName,
                lang=_configuration.GetValue<string>("language"),
                link=$"www.google.com.{_configuration.GetValue<string>("lang")}"              
            });
        }
    }
}
