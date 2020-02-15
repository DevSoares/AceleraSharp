using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EntityFrameworkPractice.Controllers.Infrastructure;
using EntityFrameworkPractice.Controllers.Models;
using EntityFrameworkPractice.Services;

namespace EntityFrameworkPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IService<Vendedor> VendedorService;

        public WeatherForecastController(IService<Vendedor> vendedorService)
        {
            VendedorService = vendedorService;
        }

        public ActionResult<IEnumerable<string>> Get()
        {
            Vendedor vendedor = new Vendedor("Zé das Ovelhas", DateTime.Parse("10/10/1990"));
            VendedorService.Add(vendedor);

            return new string[] { "", "" };
        }

        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{


        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
