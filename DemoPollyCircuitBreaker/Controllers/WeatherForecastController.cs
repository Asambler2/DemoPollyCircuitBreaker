using DemoPollyCircuitBreaker.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace DemoPollyCircuitBreaker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IRepositorio Repositorio;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRepositorio Repositorio)
        {
            this.Repositorio = Repositorio;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary =Repositorio.Get()[Random.Shared.Next(Repositorio.Get().Length)]
            })
            .ToArray();
        }
    }
}
