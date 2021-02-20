using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IGradeService
    {


        GradeViewModel GetById(Guid id);
        void Register(GradeViewModel gradeViewModel);
        IEnumerable<GradeViewModel> GetAll();
        IEnumerable<GradeViewModel> GetPagedResponse(int pageNumber, int pageSize);

        void Update(GradeViewModel gradeViewModel);
        void Remove(Guid id);
    }
}
