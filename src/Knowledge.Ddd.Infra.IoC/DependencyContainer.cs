using Microsoft.Extensions.DependencyInjection;
using Knowledge.Ddd.Application.Interfaces;
using Knowledge.Ddd.Application.Services;
using Knowledge.Ddd.Domain.Interfaces;
using Knowledge.Ddd.Infra.Data.Repositories;
using Knowledge.Ddd.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Knowledge.Ddd.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IConfiguration configuration, IServiceCollection services)
        {
            RegisterApplicationLayer(services);
            RegisterInfraDataLayer(configuration, services);
        }

        private static void RegisterApplicationLayer(IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseService>();
        }

        private static void RegisterInfraDataLayer(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<UniversityDBContext>(p =>
            {
                p.UseSqlServer(configuration.GetConnectionString("UniversityDbConnection"));
            });

            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
