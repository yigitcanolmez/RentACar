using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        //in memory for local  tests.
        //services.AddDbContext<BaseDbContext>(opt =>
        //{
        //    opt.UseInMemoryDatabase("rentACar");
        //});

        services.AddDbContext<BaseDbContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("rentACar"));
        });
        services.AddScoped<IBrandRepository, BrandRepository>();
        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<IFuelRepository, FuelRepository>();
        services.AddScoped<IModelRepository, ModelRepository>();
        services.AddScoped<ITransmissionRepository, TransmissionRepository>();


        return services;
    }

}
