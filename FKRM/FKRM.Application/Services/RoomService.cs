using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Room;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class RoomService : IRoomService
    {
        private IRoomRepository _roomRepository;
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

        public void Register(RoomViewModel roomViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateRoomCommand>(roomViewModel));
        }

        public IEnumerable<RoomViewModel> GetAll()
        {
            return _roomRepository.GetAll().ProjectTo<RoomViewModel>(_autoMapper.ConfigurationProvider);
        }

        public void Update(RoomViewModel roomViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateRoomCommand>(roomViewModel));

        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteRoomCommand(id));
        }

        public IEnumerable<RoomViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _roomRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<RoomViewModel>(_autoMapper.ConfigurationProvider);

        }
    }
}
