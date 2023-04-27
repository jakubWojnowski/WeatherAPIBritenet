using Newtonsoft.Json;
using WeatherAPI.Controllers;
using WeatherAPI.Exceptions;
using WeatherAPI.Models;

namespace WeatherAPI.Services;

public class WeatherService : IWeatherService
{
    private readonly HttpClient _httpClient;

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<SynoDto> GetById(int id)
    {
        var response = await _httpClient.GetAsync($"https://danepubliczne.imgw.pl/api/data/synop/id/{id}");
            response.EnsureSuccessStatusCode();
            if (response is null) throw new NotFoundException("Station not found");
            var responseBody = await response.Content.ReadAsStringAsync();
            var latestData = ParseData(responseBody);
            return latestData;
    }
    public async Task<SynoDto> GetByName(string stationName)
    {
        var response = await _httpClient.GetAsync($"https://danepubliczne.imgw.pl/api/data/synop/station/{stationName}");
        response.EnsureSuccessStatusCode();
        if (response is null) throw new NotFoundException("Station not found");
        var responseBody = await response.Content.ReadAsStringAsync();
        var latestData = ParseData(responseBody);
        return latestData;
    }
    
    private SynoDto ParseData(string responseBody)
    {
        var latestData = JsonConvert.DeserializeObject<SynoDto>(responseBody);
        return latestData;
    }
}


//https://danepubliczne.imgw.pl/api/data/synop