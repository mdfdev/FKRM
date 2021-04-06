using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class WorkedForRepository : Repository<WorkedFor>, IWorkedForRepository
    {
        public WorkedForRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
