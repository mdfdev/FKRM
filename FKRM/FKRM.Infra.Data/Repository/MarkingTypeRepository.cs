using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System.Linq;

namespace FKRM.Infra.Data.Repository
{
    public class MarkingTypeRepository : IMarkingTypeRepository
    {
        private SchoolDBContext _ctx;
        public MarkingTypeRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public void Add(MarkingType markingType)
        {
            _ctx.Add(markingType);
            _ctx.SaveChanges();
        }

        public IQueryable<MarkingType> GetMarkingTypes()
        {
            return _ctx.MarkingTypes;
        }
    }
}
