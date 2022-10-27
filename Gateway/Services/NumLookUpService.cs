using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces.Services.GatewayServices;
using Microsoft.Extensions.Configuration;

namespace Gateway.Services
{
          public class NumLookUpService : INumLookUpService
          {
            public IConfiguration _configuration;
            public HttpClient _httpClient;
            public string _apiKey;
            public NumLookUpService(IConfiguration configuration)
            {
                _configuration = configuration.GetSection("NumLookUpService");
                _httpClient = new HttpClient();
                _apiKey = _configuration.GetSection("NumLookUpKey").Value;
                
            }
            public async Task<bool> VerifyPhoneNumber(string phoneNumber)
            {
              var link = $"https://api.numlookupapi.com/v1/validate/{phoneNumber}?apikey={_apiKey}";
              _httpClient.BaseAddress = new Uri(link);
              var response = await _httpClient.GetAsync(link);
              return (response.IsSuccessStatusCode);
            }
          }
}