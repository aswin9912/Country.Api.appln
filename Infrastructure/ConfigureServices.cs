using Domain.Interface;
using Domain.Interface.IQueries;
using Infrastructure.Data;
using Infrastructure.QueryRepository;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection Infraservices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CountryDb>(options => options.UseSqlServer(configuration.GetConnectionString("CountryConnection")));
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<IStateRepository, StateRepository>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<ICountry, CountryQuery>();
            services.AddTransient<IState, StateQuery>();
            services.AddTransient<ICity, CityQuery>();
            return services;
        }
    }
}
