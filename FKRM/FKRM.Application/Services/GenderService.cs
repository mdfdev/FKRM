using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class GenderService : IGenderService
    {
        private IGenderRepository _genderRepository;
        public GenderService(IGenderRepository repository)
        {
            _genderRepository = repository;
        }
        public GenderViewModel GetGenders()
        {
            return new GenderViewModel()
            {
                genders = _genderRepository.GetGenders()
            };
        }
    }
}
