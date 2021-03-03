using AutoMapper;
using FKRM.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace FKRM.Api.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(FKRM.Application.AutoMapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}
