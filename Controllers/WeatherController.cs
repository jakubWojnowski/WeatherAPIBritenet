using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Services;

namespace WeatherAPI.Controllers;
[Route("api/weather")]
[ApiController]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet("GetByIdWeather/{stationId}")]
    public async Task<IActionResult> GetWeatherById(int stationId)
    {
        var data = await _weatherService.GetById(stationId);
        return Ok(data);
    }
    [HttpGet("GetByNameWeather/{name}")]
    public async Task<IActionResult> GetWeatherById(string name)
    {
        var data = await _weatherService.GetByName(name);
        return Ok(data);
    }

}