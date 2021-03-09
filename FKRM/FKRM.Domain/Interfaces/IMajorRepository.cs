using FKRM.Domain.Entities;
using System;
using System.Linq;

namespace FKRM.Domain.Interfaces
{
    public interface IMajorRepository : IRepository<Major>
    {
        IQueryable<Major> GetAllByGroupId(Guid id);

    }
}
