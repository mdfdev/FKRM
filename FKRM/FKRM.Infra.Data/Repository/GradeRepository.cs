﻿using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class GradeRepository :Repository<Grade>, IGradeRepository
    {
        
        public GradeRepository(SchoolDBContext context):base(context)
        {
        }
    }
}
