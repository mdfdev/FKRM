using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class StaffEducationalBackgroundRepository : Repository<StaffEducationalBackground>, IStaffEducationalBackgroundRepository
    {
        public StaffEducationalBackgroundRepository(SchoolDBContext context) : base(context)
        {

        }
    }
}
