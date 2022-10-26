using System.Text.Json.Serialization;

namespace Application.JSONResponseModel.OpenWeatherMapServiceResponseModels;

public class CurrentWeatherForecastResponseModel
{
    [JsonPropertyName("coord")]
    public Coordinates Coordinates { get; set; }


}

public class Coordinates
{
    [JsonPropertyName("lon")]
    public string Longitude { get; set; }
    [JsonPropertyName("lat")]
    public string Latitude { get; set; }
}

public class WeatherInformation
{

}