using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class UnitTypeRepository : IUnitTypeRepository
    {
        private SchoolDBContext _ctx;
        public UnitTypeRepository(SchoolDBContext context)
        {
            _ctx = context;
        }

        public void Add(UnitType unitType)
        {
            _ctx.Add(unitType);
            _ctx.SaveChanges();
        }

        public IQueryable<UnitType> GetUnitTypes()
        {
            return _ctx.UnitTypes;
        }
    }
}
