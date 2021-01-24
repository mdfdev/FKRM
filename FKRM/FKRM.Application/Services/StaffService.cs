using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Staff;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class StaffService : IStaffService
    {
        private IStaffRepository _staffRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public StaffService(IStaffRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _staffRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }
        public IEnumerable<StaffViewModel> GetAll()
        {
            return _staffRepository.GetAll().ProjectTo<StaffViewModel>(_autoMapper.ConfigurationProvider);
        }

        public StaffViewModel GetById(Guid id)
        {
            return _autoMapper.Map<StaffViewModel>(_staffRepository.GetById(id));
        }

        public void Register(StaffViewModel staffViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateStaffCommand>(staffViewModel));
        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteStaffCommand(id));
        }

        public void Update(StaffViewModel staffViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateStaffCommand>(staffViewModel));
        }


    }
}
