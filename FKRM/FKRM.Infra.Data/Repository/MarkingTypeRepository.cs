using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class MarkingTypeRepository : Repository<MarkingType>, IMarkingTypeRepository
    {
        public MarkingTypeRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
