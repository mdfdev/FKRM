using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface ISchoolService
    {
        IEnumerable<SchoolViewModel> GetSchools();
        void Create(SchoolViewModel schoolViewModel);
    }
}
