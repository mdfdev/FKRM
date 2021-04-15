using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IAcademicCalendarService
    {
        AcademicCalendarViewModel GetById(Guid id);
        Task<Response<int>> Register(AcademicCalendarViewModel academicCalendarViewModel);
        IEnumerable<AcademicCalendarViewModel> GetAll();
        IEnumerable<AcademicCalendarViewModel> GetAllWithTitle();

        IEnumerable<AcademicCalendarViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(AcademicCalendarViewModel academicCalendarViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
