using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class GroupRepository : IGroupRepository
    {
        private SchoolDBContext _ctx;
        public GroupRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public void Add(Group group)
        {
            _ctx.Add(group);
            _ctx.SaveChanges();
        }

        public IQueryable<Group> GetGroups()
        {
            return _ctx.Groups;
        }
    }
}
