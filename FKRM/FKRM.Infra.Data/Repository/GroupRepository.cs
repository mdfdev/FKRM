using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FKRM.Infra.Data.Repository
{
    public class GroupRepository : Repository<Group>, IGroupRepository
    {
        private readonly DbSet<Group> _groups;
        public GroupRepository(SchoolDBContext context) : base(context)
        {
            _groups = context.Set<Group>();
        }

        public IQueryable<Group> GetAllByAreaId(Guid id)
        {
            return _groups.Where(p => p.AreaId == id);
        }
    }
}
