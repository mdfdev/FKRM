using FKRM.Domain.Entities;
using System.Linq;

namespace FKRM.Domain.Interfaces
{
    public interface ISchoolRepository : IRepository<School>
    {
        IQueryable<School> GetAllWithCode();
    }
}
