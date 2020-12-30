using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class ScheduleRepository : IScheduleRepository
    {
        private SchoolDBContext _ctx;
        public ScheduleRepository(SchoolDBContext context)
        {
            _ctx = context;
        }

        public void Add(Schedule schedule)
        {
            _ctx.Add(schedule);
            _ctx.SaveChanges();
        }

        public IQueryable<Schedule> GetSchedules()
        {
            return _ctx.Schedules;
        }
    }
}
