using Application.Interfaces;
using Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence;

public static class PersistenceServiceRegisteration
{
    public static void AddDbConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("AARRConnectionString");
        services.AddDbContext<ApplicationContext>(option => 
        option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        services.AddScoped<IFarmRepository, FarmRepository>();
        services.AddScoped<IFarmerRepository, FarmerRepository>();
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
    }
}
