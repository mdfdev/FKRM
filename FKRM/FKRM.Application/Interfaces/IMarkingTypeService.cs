using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IMarkingTypeService
    {
        MarkingTypeViewModel GetById(Guid id);
        void Register(MarkingTypeViewModel markingTypeViewModel);
        IEnumerable<MarkingTypeViewModel> GetAll();
        IEnumerable<MarkingTypeViewModel> GetPagedResponse(int pageNumber, int pageSize);

        void Update(MarkingTypeViewModel markingTypeViewModel);
        void Remove(Guid id);
    }
}
