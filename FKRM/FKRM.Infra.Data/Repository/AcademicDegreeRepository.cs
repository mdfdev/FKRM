using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class AcademicDegreeRepository : Repository<AcademicDegree>, IAcademicDegreeRepository
    {
        public AcademicDegreeRepository(SchoolDBContext context) : base(context)
        {

        }
    }
}
