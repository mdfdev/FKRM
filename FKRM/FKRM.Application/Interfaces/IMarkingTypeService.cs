using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IMarkingTypeService
    {
        IEnumerable<MarkingTypeViewModel> GetMarkingTypes();
        void Create(MarkingTypeViewModel markingTypeViewModel);
    }
}
