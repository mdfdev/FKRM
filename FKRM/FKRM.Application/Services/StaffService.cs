using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Staff;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository _staffRepository;
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

        public Task<Response<int>> Register(StaffViewModel staffViewModel)
        {
             return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateStaffCommand>(staffViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
           return (Task<Response<int>>)_bus.SendCommand(new DeleteStaffCommand(id));
        }

        public Task<Response<int>> Update(StaffViewModel staffViewModel)
        {
           return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateStaffCommand>(staffViewModel));
        }

        public IEnumerable<StaffViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _staffRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<StaffViewModel>(_autoMapper.ConfigurationProvider);

        }
    }
}
