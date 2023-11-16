using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RobertinhoDinamiteController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<RobertinhoDinamiteController> _logger;

        public RobertinhoDinamiteController(ILogger<RobertinhoDinamiteController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "AloWeatherForecast")]
        public IEnumerable<RomeluLukaku> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new RomeluLukaku
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}