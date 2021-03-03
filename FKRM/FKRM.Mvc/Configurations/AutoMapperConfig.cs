using AutoMapper;
using FKRM.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace FKRM.Mvc.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}
