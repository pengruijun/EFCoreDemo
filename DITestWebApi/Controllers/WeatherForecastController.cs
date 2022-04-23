using DITestWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DITestWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IPersonService _personService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IPersonService personService)
    {
        _logger = logger;
        _personService = personService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }

    [HttpGet("[Action]")]
    public IActionResult DITest()
    {
        var person = new Person()
        {
            Firstname = "Ruijun",
            Surname = "Peng"
        };
        _personService.ChangeName(person);
        return Ok(person);
    }
}