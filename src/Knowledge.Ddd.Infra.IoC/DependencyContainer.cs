using Microsoft.Extensions.DependencyInjection;
using Knowledge.Ddd.Application.Interfaces;
using Knowledge.Ddd.Application.Services;
using Knowledge.Ddd.Domain.Interfaces;
using Knowledge.Ddd.Infra.Data.Repositories;
using Knowledge.Ddd.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Knowledge.Ddd.Domain.Core.Bus;
using Knowledge.Ddd.Bus;
using MediatR;
using Knowledge.Ddd.Domain.CommandHandlers;
using Knowledge.Ddd.Domain.Commands;

namespace Knowledge.Ddd.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IConfiguration configuration, IServiceCollection services)
        {
            RegisterDomainLayer(services);
            RegisterApplicationLayer(services);
            RegisterDomainInMemmoryMediatRLayer(services);
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

        private static void RegisterDomainLayer(IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();
        }

        private static void RegisterDomainInMemmoryMediatRLayer(IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, InMemoryBus>();
        }
    }
}
