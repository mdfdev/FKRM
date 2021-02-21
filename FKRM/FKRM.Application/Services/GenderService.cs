using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;

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

        public IEnumerable<GenderViewModel> GetAll()
        {
            return _genderRepository.GetAll().ProjectTo<GenderViewModel>(_autoMapper.ConfigurationProvider);
        }

        public GenderViewModel GetById(Guid id)
        {
            return _autoMapper.Map<GenderViewModel>(_genderRepository.GetById(id));
        }

        public void Register(GenderViewModel genderViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateGenderCommand>(genderViewModel));
        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteGenderCommand(id));
        }

        public void Update(GenderViewModel genderViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateGenderCommand>(genderViewModel));
        }
        public IEnumerable<GenderViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _genderRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<GenderViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
