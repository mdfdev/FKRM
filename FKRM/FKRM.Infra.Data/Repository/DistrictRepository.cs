using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class DistrictRepository : Repository<District>, IDistrictRepository
    {
        public DistrictRepository(SchoolDBContext context) : base(context)
        {

        }
    }
}
