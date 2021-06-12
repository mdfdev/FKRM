using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class AcademicDegreeRepository : Repository<AcademicDegree>, IAcademicDegreeRepository
    {
        public AcademicDegreeRepository(SchoolDBContext context) : base(context)
        {

        }
    }
}
