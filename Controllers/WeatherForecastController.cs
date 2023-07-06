using Microsoft.AspNetCore.Mvc;

namespace dotnet_api_template.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "PEWFreezingLOL", "PEWBracingLOL", "PEWChillyLOL", "PEWCoolLOL", "PEWMildLOL", "PEWWarmLOL", "PEWBalmyLOL", "PEWHotLOL", "PEWSwelteringLOL", "PEWScorchingLOL"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
