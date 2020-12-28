using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _autoMapper;
        public GenderService(IGenderRepository repository,IMediatorHandler bus,IMapper mapper)
        {
            _genderRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public void Create(GenderViewModel genderViewModel)
        {
            _bus.SendCommand(_autoMapper.Map< CreateGenderCommand>(genderViewModel));
        }

        public IEnumerable<GenderViewModel> GetGenders()
        {
            return _genderRepository.GetGenders().ProjectTo<GenderViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
