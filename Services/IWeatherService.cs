using WeatherAPI.Models;

namespace WeatherAPI.Services;

public interface IWeatherService
{
    Task<SynoDto> GetById(int id);
    Task<SynoDto> GetByName(string stationName);
}