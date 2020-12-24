using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class GenderService : IGenderService
    {
        private readonly IGenderRepository _genderRepository;
        private readonly IMediatorHandler _bus; 
        public GenderService(IGenderRepository repository,IMediatorHandler bus)
        {
            _genderRepository = repository;
            _bus = bus;
        }

        public void Create(GenderViewModel genderViewModel)
        {
            var createGenderCommand = new CreateGenderCommand(genderViewModel.Name);
            _bus.SendCommand(createGenderCommand);
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
