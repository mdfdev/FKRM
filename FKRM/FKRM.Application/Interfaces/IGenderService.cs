using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IGenderService
    {
        IEnumerable<GenderViewModel> GetGenders();
        void Create(GenderViewModel genderViewModel);
    }
}
