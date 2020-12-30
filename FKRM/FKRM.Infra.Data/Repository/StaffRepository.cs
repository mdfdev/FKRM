using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System.Linq;

namespace FKRM.Infra.Data.Repository
{
    public class StaffRepository : IStaffRepository
    {
        private SchoolDBContext _ctx;
        public StaffRepository(SchoolDBContext context)
        {
            _ctx = context;
        }

        public void Add(Staff staff)
        {
            _ctx.Add(staff);
            _ctx.SaveChanges();
        }

        public IQueryable<Staff> GetStaffs()
        {
            return _ctx.Staffs;
        }
    }
}
