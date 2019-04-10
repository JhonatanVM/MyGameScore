using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyGameScore.Application.Interfaces;
using MyGameScore.Application.Services.AppMatch;
using MyGameScore.Data.Context;
using MyGameScore.Data.Repository;
using MyGameScore.Domain.Interfaces.Domain;
using MyGameScore.Domain.Interfaces.Repository;
using MyGameScore.Domain.Services;

namespace MyGameScore.IoC
{
    public static class IoCConfigure
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureDomain(services);
            ConfigureData(services, configuration);
            ConfigureApplication(services);
        }

        private static void ConfigureApplication(IServiceCollection services)
        {
            services.AddScoped<IMatchApplicationService, MatchApplicationService>();
        }

        private static void ConfigureData(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyGameScoreContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IMatchRepository, MatchRepository>();
        }

        private static void ConfigureDomain(IServiceCollection services)
        {
            services.AddScoped<IMatchDomainService, MatchDomainService>();
        }
    }
}
