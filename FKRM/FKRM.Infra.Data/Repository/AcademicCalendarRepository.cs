using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class AcademicCalendarRepository : IAcademicCalendarRepository
    {
        private SchoolDBContext _ctx;
        public AcademicCalendarRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<AcademicCalendar> GetAcademicCalendars()
        {
            return _ctx.AcademicCalendars;
        }
    }
}
