using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class GenderRepository : Repository<Gender>, IGenderRepository
    {
        public GenderRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
