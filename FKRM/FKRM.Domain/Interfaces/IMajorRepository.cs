using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Domain.Interfaces
{
    public interface IMajorRepository
    {
        IQueryable<Major> GetMajors();
        void Add(Major major);
        void Delete(Major major);
        void Update(Major major);
        IQueryable<Major> GetPagedReponse(int pageNumber, int pageSize);
    }
}
