using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestReactWebApp.Models;

namespace TestReactWebApp.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : BaseController
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        [HttpPost("[action]")]
        public JsonResult Login([FromBody] LoginForm form)
        {
            User user = null;
            try
            {
                user = UserService.AuthenticateCustomer(form.Username, form.Password);
                if (user != null)
                {
                    return new JsonResult(new
                    {
                        success = true,
                        message = $"Welcome {user.FirstName} {user.LastName}"
                    });
                }
            }
            catch (Exception ex)
            {
                // somethig went wrong and user cannot be authenticated
            }

            return new JsonResult(new
            {
                success = false,
                message = "We could not log you in. Sorry!"
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
