using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FKRM.Domain.Interfaces
{
    public interface IAreaRepository : IRepository<Area>
    {
        IQueryable<Area> GetAllByBranchId(Guid id);
    }
}
