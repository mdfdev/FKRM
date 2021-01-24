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
        void Update(GradeViewModel gradeViewModel);
        void Remove(Guid id);
    }
}
