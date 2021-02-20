using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface ISchoolService
    {
        SchoolViewModel GetById(Guid id);
        void Register(SchoolViewModel schoolViewModel);
        IEnumerable<SchoolViewModel> GetAll();
        IEnumerable<SchoolViewModel> GetPagedResponse(int pageNumber, int pageSize);

        void Update(SchoolViewModel schoolViewModel);
        void Remove(Guid id);
    }
}
