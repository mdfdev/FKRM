using FKRM.Domain.Entities;
using System.Linq;

namespace FKRM.Domain.Interfaces
{
    public interface IAcademicCalendarRepository : IRepository<AcademicCalendar>
    {
        IQueryable<AcademicCalendar> GetAllWithTitle();
    }
}
