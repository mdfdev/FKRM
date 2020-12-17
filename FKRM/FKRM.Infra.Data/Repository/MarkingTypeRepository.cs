using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class MarkingTypeRepository : IMarkingTypeRepository
    {
        private SchoolDBContext _ctx;
        public MarkingTypeRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<MarkingType> GetMarkingTypes()
        {
            return _ctx.MarkingTypes;
        }
    }
}
