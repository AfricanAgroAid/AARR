using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace IOC.Extensions;

public static class ServiceCollectionExtension
{
          public static void AddICOService(this IServiceCollection services, IConfiguration configuration)
          {
                    services.AddDbConfiguration(configuration);
          }
}
