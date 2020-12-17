using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
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
        public IEnumerable<Group> GetGroups()
        {
            return _ctx.Groups;
        }
    }
}
