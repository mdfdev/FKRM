using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private SchoolDBContext _ctx;
        public RoomRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Room> GetRooms()
        {
            return _ctx.Rooms;
        }
    }
}
