using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class StaffRepository : Repository<Staff>, IStaffRepository
    {
        public StaffRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
