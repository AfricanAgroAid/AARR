using Application.JSONResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gateway.Services
{
    public class CityService : ICityService
    {
        public async Task<IList<City>> GetAllCitiesAsync()
        {
            var cityList = new List<City>();

            string text = await File.ReadAllTextAsync(@"D:\staa99\Desktop\AARR\Gateway\Services\Cities.json");
            var countries = JsonSerializer.Deserialize<IList<City>>(text);
            foreach (City country in countries)
            {
                cityList.Add(country);
            }

            return cityList;
        }
    }
}
