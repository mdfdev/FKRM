﻿using AutoMapper;

namespace FKRM.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToViewModelProfile());
                cfg.AddProfile(new ViewModelToDomainProfile());
            });
        }
    }
}
