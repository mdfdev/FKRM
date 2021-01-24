﻿using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IMajorService
    {
        MajorViewModel GetById(Guid id);
        void Register(MajorViewModel majorViewModel);
        IEnumerable<MajorViewModel> GetAll();
        void Update(MajorViewModel majorViewModel);
        void Remove(Guid id);
    }
}
