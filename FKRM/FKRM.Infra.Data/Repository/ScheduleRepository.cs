using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
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
        public IEnumerable<Schedule> GetSchedules()
        {
            return _ctx.Schedules;
        }
    }
}
