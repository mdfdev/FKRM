using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class OUTypeRepository : IOUTypeRepository
    {
        private SchoolDBContext _ctx;
        public OUTypeRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public void Add(OUType oUType)
        {
            _ctx.Add(oUType);
            _ctx.SaveChanges();
        }

        public IQueryable<OUType> GetOUTypes()
        {
            return _ctx.OUTypes;
        }
    }
}
