using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces.Repositories
{
    public interface IAreaRepository 
    {
        IEnumerable<Area> GetAreas();
    }
}
