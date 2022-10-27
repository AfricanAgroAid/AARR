using Application.JSONResponseModel.OpenWeatherMapServiceResponseModels;

namespace Application.Interfaces.Services.GatewayServices;

public interface IOpenWeatherMapService
{
    Task<GeocodingResponseModels> GetCityCoordinates(string cityName, int responseLimit = 1,string countryCode = "ng");
    Task<DaysClimaticForecastResponseModel> GetDaysClimaticForecast(decimal lat, decimal lon, int daysCount = 7);
    Task<CurrentWeatherForecastResponseModel> GetCurrentWeatherForecast(decimal lat, decimal lon, string countryCode = "ng");
}
