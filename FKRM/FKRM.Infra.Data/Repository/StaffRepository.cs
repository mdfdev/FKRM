using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FKRM.Infra.Data.Repository
{
    public class StaffRepository : Repository<Staff>, IStaffRepository
    {
        private readonly DbSet<WorkedFor> _workedFors;
        public StaffRepository(SchoolDBContext context) : base(context)
        {
            _workedFors = context.Set<WorkedFor>();
        }

        public Staff Get(string ncode, Guid academicCalendarId)
        {
            return
                DbSet
                .Join(_workedFors, st => st.Id, w => w.StaffId, (st, w) => new { st, w })
                .Where(p => p.st.NationalCode.CompareTo(ncode) == 0 && p.w.AcademicCalendarId == academicCalendarId)
                .Select(p => p.st)
                .FirstOrDefault();
        }

        public Staff Get(string ncode)
        {
            return
               DbSet
               .Where(p => p.NationalCode.CompareTo(ncode) == 0)
               .Select(p => p)
               .FirstOrDefault();
        }
    }
}
