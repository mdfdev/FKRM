using AutoMapper;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.AutoMapper
{
    public class ViewModelToDomainProfile:Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<GenderViewModel, CreateGenderCommand>()
                .ConstructUsing(c => new CreateGenderCommand(c.Name));
        }
    }
}
