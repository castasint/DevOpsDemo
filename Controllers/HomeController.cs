using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevOpsDemo.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
        {
        private IConfiguration configuration;

        public HomeController(IConfiguration configuration)
            {
            this.configuration = configuration;
            }
     
        [HttpGet]
        public IActionResult Get()
            {
        
            var defaultLogLevel = this.configuration["Logging:LogLevel:Default"];
            var environment = this.configuration["Environment"];
            var firstName = this.configuration["Admin:FirstName"];
            var lastName = this.configuration["Admin:LastName"];


            return Content(
                           $"Default Log Level: {defaultLogLevel} \n" +
                           $"Environemt: {environment} \n" +
                           $"First Name: {firstName} \n" +
                            $"Last Name: {lastName} \n" );
            }

        }
    }
