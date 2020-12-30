using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Add(Room room)
        {
            _ctx.Add(room);
            _ctx.SaveChanges();
        }

        public IQueryable<Room> GetRooms()
        {
            return _ctx.Rooms;
        }
    }
}
