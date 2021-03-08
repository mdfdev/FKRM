using FKRM.Domain.Entities;
using System;
using System.Linq;

namespace FKRM.Domain.Interfaces
{
    public interface IGroupRepository : IRepository<Group>
    {
        IQueryable<Group> GetAllByAreaId(Guid id);

    }
}
