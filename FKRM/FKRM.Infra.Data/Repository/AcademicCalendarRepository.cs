using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FKRM.Infra.Data.Repository
{
    public class AcademicCalendarRepository : Repository<AcademicCalendar>, IAcademicCalendarRepository
    {
        public AcademicCalendarRepository(SchoolDBContext context) : base(context)
        {

        }
        public IQueryable<AcademicCalendar> GetAllWithTitle()
        {
            return DbSet.Select(p => new AcademicCalendar()
            {
                Id = p.Id,
                AcademicYear = p.AcademicQuarter + " " + p.AcademicYear
            });
        }

        public AcademicCalendar GetByYear(string year)
        {
            return DbSet.Where(p=>p.AcademicYear.EndsWith(year)).FirstOrDefault();
        }
    }
}
