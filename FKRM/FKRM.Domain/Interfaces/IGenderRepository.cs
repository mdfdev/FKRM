using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Domain.Interfaces
{
    public interface IGenderRepository
    {
        Gender GetById(int id);
        IQueryable<Gender> GetGenders();
        void Add(Gender gender);
        void Delete(Gender gender);
        void Update(Gender gender);
        IQueryable<Gender> GetPagedReponse(int pageNumber, int pageSize);
    }
}
