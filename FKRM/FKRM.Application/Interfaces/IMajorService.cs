using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IMajorService
    {
        IEnumerable<MajorViewModel> GetMajors();
        void Create(MajorViewModel majorViewModel);
    }
}
