using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FKRM.Infra.Data.Repository
{
    public class AreaRepository : Repository<Area>, IAreaRepository
    {
        public AreaRepository(SchoolDBContext context) : base(context)
        {
        }

        public IQueryable<Area> GetAllByBranchId(Guid id)
        {
            return DbSet.Where(p => p.BranchId == id);
        }
    }
}
