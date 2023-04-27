using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WeatherAPI.Models;

public class SynoDto
{
    [JsonProperty("id_stacji")]
    public string? Id { get; set; }
    [JsonProperty("stacja")]
    public string? Name { get; set; }
    [JsonProperty("data_pomiaru")]
    public string? Date { get; set; }
    [JsonProperty("godzina_pomiaru")]
    public string? Hour { get; set; }
    [JsonProperty("temperatura")]
    public string? Temperature { get; set; }
    [JsonProperty("predkosc_wiatru")]
    public string? SpeedOfWind { get; set; }
    [JsonProperty("kierunek_wiatru")]
    public string? DirectionOfWind { get; set; }
    [JsonProperty("wilgotnosc_wzgledna")]
    public string? Moisture { get; set; }
    [JsonProperty("suma_opadu")]
    public string? Precipitation { get; set; }
    [JsonProperty("cisnienie")]
    public string? Pressure { get; set; }
}