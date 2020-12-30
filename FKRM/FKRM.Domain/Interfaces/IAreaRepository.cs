using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Domain.Interfaces
{
    public interface IAreaRepository 
    {
        IQueryable<Area> GetAreas();
        void Add(Area area);
    }
}
