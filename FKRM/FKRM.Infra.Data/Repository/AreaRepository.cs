using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class AreaRepository : Repository<Area>, IAreaRepository
    {
        public AreaRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
