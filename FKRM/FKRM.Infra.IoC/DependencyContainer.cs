using FKRM.Application.Interfaces;
using FKRM.Application.Services;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ISchoolService,SchoolService>();
            services.AddScoped<IGenderService, GenderService>();

            //Infra.Data.Layer
            services.AddScoped<ISchoolRepository,SchoolRepository>();
            services.AddScoped<IGenderRepository, GenderRepository>();
        }
    }
}
