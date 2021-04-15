using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
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

 
    }
}
