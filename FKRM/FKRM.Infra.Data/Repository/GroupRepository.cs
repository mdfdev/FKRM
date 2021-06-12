using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Linq;

namespace FKRM.Infra.Data.Repository
{
    public class GroupRepository : Repository<Group>, IGroupRepository
    {
        public GroupRepository(SchoolDBContext context) : base(context)
        {
        }

        public IQueryable<Group> GetAllByAreaId(Guid id)
        {
            return DbSet.Where(p => p.AreaId == id);
        }
    }
}
