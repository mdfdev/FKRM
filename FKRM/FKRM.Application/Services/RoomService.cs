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
        public void Create(RoomViewModel roomViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateRoomCommand>(roomViewModel));
        }

        public IEnumerable<RoomViewModel> GetRooms()
        {
            return _roomRepository.GetRooms().ProjectTo<RoomViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
