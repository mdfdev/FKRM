using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class OUTypeRepository :Repository<OUType>, IOUTypeRepository
    {
        public OUTypeRepository(SchoolDBContext context):base(context)
        {
        }
    }
}
