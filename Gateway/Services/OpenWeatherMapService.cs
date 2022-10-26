using Application.Interfaces.Services.GatewayServices;
using Application.JSONResponseModel.OpenWeatherMapServiceResponseModels;
using Gateway.Extensions;
using Microsoft.Extensions.Configuration;

namespace Gateway.Services;

public class OpenWeatherMapService : IOpenWeatherMapService
{
    private readonly HttpClient _client;
    private readonly IConfigurationSection _configuration;
    private readonly string  _apiKey;

    public OpenWeatherMapService(IConfigurationSection configuration)
    {
        _client = new HttpClient();
        _configuration = configuration.GetSection("OpenWeatherMapService");
        _apiKey = _configuration.GetSection("ApiKey").Value;
    }

    public async Task<GeocodingResponseModels> GetCityCoordinates(string cityName, int responseLimit = 1, string countryCode = "ng")
    {
        
       _client.BaseAddress = new Uri($"https://api.openweathermap.org/geo/1.0/direct?q={cityName},{countryCode}&limit={responseLimit}&appid={_apiKey}");
       var response = await _client.GetAsync($"https://api.openweathermap.org/geo/1.0/direct?q={cityName},{countryCode}&limit={responseLimit}&appid={_apiKey}");
       if(!response.IsSuccessStatusCode) throw new Exception($"The City Coordinates For The City Location:{cityName} Could Not Be Recovered"); 
       var responseReturned = await response.ReadContentAs<GeocodingResponseModels>();
       return responseReturned;
    }

    public Task<CurrentWeatherForecastResponseModel> GetCurrentWeatherForecast(decimal lat, decimal lon, string countryCode = "ng")
    {
        throw new NotImplementedException();
    }

    public Task<DaysClimaticForecastResponseModel> GetDaysClimaticForecast(decimal lat, decimal lon, int daysCount = 7)
    {
        throw new NotImplementedException();
    }
}
