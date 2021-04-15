using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FKRM.Infra.Data.Repository
{
    public class AcademicCalendarRepository : Repository<AcademicCalendar>, IAcademicCalendarRepository
    {
        private readonly DbSet<AcademicCalendar> _academicCalendars;
        public AcademicCalendarRepository(SchoolDBContext context) : base(context)
        {
            _academicCalendars = context.Set<AcademicCalendar>();

        }
        public IQueryable<AcademicCalendar> GetAllWithTitle()
        {
            return _academicCalendars.Select(p => new AcademicCalendar()
            {
                Id = p.Id,
                AcademicYear = p.AcademicYear + " - " + p.AcademicQuarter
            });
        }
    }
}
