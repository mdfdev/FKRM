using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class RoomService : IRoomService
    {
        private IRoomRepository _roomRepository;
        public RoomService(IRoomRepository repository)
        {
            _roomRepository = repository;
        }
        public RoomViewModel GetRooms()
        {
            return new RoomViewModel()
            {
                rooms=_roomRepository.GetRooms()
            };
        }
    }
}
