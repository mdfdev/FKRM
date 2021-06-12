using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class AcademicMajorRepository :Repository<AcademicMajor>, IAcademicMajorRepository
    {
        public AcademicMajorRepository(SchoolDBContext context) : base(context)
        {

        }
    }
}
