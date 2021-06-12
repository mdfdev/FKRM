using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class WorkedForRepository : Repository<WorkedFor>, IWorkedForRepository
    {
        public WorkedForRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
