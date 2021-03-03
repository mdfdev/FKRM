using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class MajorRepository : Repository<Major>, IMajorRepository
    {
        public MajorRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
