using AutoMapper;
using FKRM.Application.ViewModels;
using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.AutoMapper
{
    public class DomainToViewModelProfile:Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Gender,GenderViewModel>();
        }
    }
}
