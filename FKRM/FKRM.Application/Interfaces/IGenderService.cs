using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IGenderService
    {
        GenderViewModel GetById(Guid id);
        void Register(GenderViewModel genderViewModel);
        IEnumerable<GenderViewModel> GetAll();
        IEnumerable<GenderViewModel> GetPagedResponse(int pageNumber, int pageSize);

        void Update(GenderViewModel genderViewModel);
        void Remove(Guid id);
    }
}
