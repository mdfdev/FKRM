using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class AreaRepository : IAreaRepository
    {
        private SchoolDBContext _ctx;
        public AreaRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public void Add(Area area)
        {
            _ctx.Add(area);
            _ctx.SaveChanges();
        }

        public IQueryable<Area> GetAreas()
        {
            return _ctx.Areas;
        }
    }
}
