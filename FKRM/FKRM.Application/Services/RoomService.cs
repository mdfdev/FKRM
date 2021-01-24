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
            throw new NotImplementedException();
        }

        public void Register(RoomViewModel roomViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoomViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(RoomViewModel roomViewModel)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
