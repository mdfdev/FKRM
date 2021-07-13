using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Commands.StaffEducationalBackground;
using FKRM.Application.Interfaces;
using FKRM.Application.Queries.StaffEducationalBackground;
using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class StaffEducationalBackgroundService: IStaffEducationalBackgroundService
    {
        private readonly IStaffEducationalBackgroundRepository _staffEducationalBackgroundRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public StaffEducationalBackgroundService(IStaffEducationalBackgroundRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _staffEducationalBackgroundRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public IEnumerable<StaffEducationalBackgroundViewModel> GetAll()
        {
            return _staffEducationalBackgroundRepository.GetAll().ProjectTo<StaffEducationalBackgroundViewModel>(_autoMapper.ConfigurationProvider);
        }

        public Task<Response<IEnumerable<StaffEducationalBackgroundViewModel>>> GetAllDataByStaffId(Guid id)
        {
            return _bus.Send(new GetStaffEducationalBackgroundById(id));
        }

        public StaffEducationalBackgroundViewModel GetById(Guid id)
        {
            return _autoMapper.Map<StaffEducationalBackgroundViewModel>(_staffEducationalBackgroundRepository.GetById(id));
        }

        public IEnumerable<StaffEducationalBackgroundViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _staffEducationalBackgroundRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<StaffEducationalBackgroundViewModel>(_autoMapper.ConfigurationProvider);
        }

        public Task<Response<int>> Register(StaffEducationalBackgroundViewModel staffEducationalBackgroundViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateStaffEducationalBackgroundCommand>(staffEducationalBackgroundViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<int>> Update(StaffEducationalBackgroundViewModel staffEducationalBackgroundViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
