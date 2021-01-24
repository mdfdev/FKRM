using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class SchoolRepository :Repository<School>,  ISchoolRepository
    {
        public SchoolRepository(SchoolDBContext context):base(context)
        {
        }
    }
}
