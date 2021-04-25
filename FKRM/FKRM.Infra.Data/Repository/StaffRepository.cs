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
        private readonly DbSet<Staff> _staffs;
        private readonly DbSet<WorkedFor> _workedFors;
        public StaffRepository(SchoolDBContext context) : base(context)
        {
            _staffs = context.Set<Staff>();
            _workedFors = context.Set<WorkedFor>();
        }

        public Staff Get(string ncode, Guid academicCalendarId)
        {
            return
                _staffs
                .Join(_workedFors, st => st.Id, w => w.StaffId, (st, w) => new { st, w })
                .Where(p => p.st.NationalCode.CompareTo(ncode) == 0 && p.w.AcademicCalendarId == academicCalendarId)
                .Select(p => p.st)
                .FirstOrDefault();
        }

        public Staff Get(string ncode)
        {
            return
               _staffs
               .Where(p => p.NationalCode.CompareTo(ncode) == 0)
               .Select(p => p)
               .FirstOrDefault();
        }
    }
}
