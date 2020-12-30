using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Add(AcademicCalendar academicCalendar)
        {
            _ctx.Add(academicCalendar);
            _ctx.SaveChanges();
        }

        public IQueryable<AcademicCalendar> GetAcademicCalendars()
        {
            return _ctx.AcademicCalendars;
        }
    }
}
