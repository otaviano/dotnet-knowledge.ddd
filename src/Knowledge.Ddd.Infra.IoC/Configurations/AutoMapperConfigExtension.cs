using AutoMapper;
using Knowledge.Ddd.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Knowledge.Ddd.Infra.IoC.Configurations
{
    public static class AutoMapperConfigExtension
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}
