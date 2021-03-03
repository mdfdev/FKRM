using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetById(Guid id);
        Task<Response<int>> Register(CourseViewModel courseViewModel);
        IEnumerable<CourseViewModel> GetAll();
        IEnumerable<CourseViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(CourseViewModel courseViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}
