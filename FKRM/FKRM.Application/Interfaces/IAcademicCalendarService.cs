using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IAcademicCalendarService
    {
        AcademicCalendarViewModel GetById(Guid id);
        void Register(AcademicCalendarViewModel academicCalendarViewModel);
        IEnumerable<AcademicCalendarViewModel> GetAll();
        void Update(AcademicCalendarViewModel academicCalendarViewModel);
        void Remove(Guid id);
    }
}
