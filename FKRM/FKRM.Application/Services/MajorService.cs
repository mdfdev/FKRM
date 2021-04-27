using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Application.Commands.Major;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FKRM.Application.Queries.Major;

namespace FKRM.Application.Services
{
    public class MajorService : IMajorService
    {
        private readonly IMajorRepository _majorRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public MajorService(IMajorRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _majorRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public MajorViewModel GetById(Guid id)
        {
            return _autoMapper.Map<MajorViewModel>(_majorRepository.GetById(id));
        }

        public Task<Response<int>> Register(MajorViewModel majorViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateMajorCommand>(majorViewModel));
        }

        public IEnumerable<MajorViewModel> GetAll()
        {
            return _majorRepository.GetAll().ProjectTo<MajorViewModel>(_autoMapper.ConfigurationProvider);

        }

        public Task<Response<int>> Update(MajorViewModel majorViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateMajorCommand>(majorViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteMajorCommand(id));
        }

        public IEnumerable<MajorViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _majorRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<MajorViewModel>(_autoMapper.ConfigurationProvider);
        }

        public IEnumerable<MajorViewModel> GetByGroupId(Guid id)
        {
            return _majorRepository.GetAllByGroupId(id).ProjectTo<MajorViewModel>(_autoMapper.ConfigurationProvider);
        }

        public int Count()
        {
            return _majorRepository.Count();
        }

        public Task<Response<IEnumerable<ChartViewModel>>> GetMajorStatistics()
        {
            return _bus.Send(new GetMajorStatistics());

        }
    }
}
