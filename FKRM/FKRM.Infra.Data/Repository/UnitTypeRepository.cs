using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class UnitTypeRepository : Repository<UnitType>, IUnitTypeRepository
    {
        public UnitTypeRepository(SchoolDBContext context):base(context)
        {
        }
    }
}
