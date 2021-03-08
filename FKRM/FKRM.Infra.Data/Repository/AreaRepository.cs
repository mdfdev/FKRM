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
        private readonly DbSet<Area> _areas;
        public AreaRepository(SchoolDBContext context) : base(context)
        {
            _areas = context.Set<Area>();
        }

        public IQueryable<Area> GetAllByBranchId(Guid id)
        {
            return _areas.Where(p => p.BranchId == id);
        }
    }
}
