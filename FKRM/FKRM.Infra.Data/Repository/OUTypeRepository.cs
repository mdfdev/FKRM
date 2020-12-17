using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
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
        public IEnumerable<OUType> GetOUTypes()
        {
            return _ctx.OUTypes;
        }
    }
}
