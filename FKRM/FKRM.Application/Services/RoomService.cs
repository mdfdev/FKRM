using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Room;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public RoomService(IRoomRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _roomRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public RoomViewModel GetById(Guid id)
        {
            return _autoMapper.Map<RoomViewModel>(_roomRepository.GetById(id));
        }

        public Task<Response<int>> Register(RoomViewModel roomViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateRoomCommand>(roomViewModel));
        }

        public IEnumerable<RoomViewModel> GetAll()
        {
            return _roomRepository.GetAll().ProjectTo<RoomViewModel>(_autoMapper.ConfigurationProvider);
        }

        public Task<Response<int>> Update(RoomViewModel roomViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateRoomCommand>(roomViewModel));

        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteRoomCommand(id));
        }

        public IEnumerable<RoomViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _roomRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<RoomViewModel>(_autoMapper.ConfigurationProvider);

        }
    }
}
