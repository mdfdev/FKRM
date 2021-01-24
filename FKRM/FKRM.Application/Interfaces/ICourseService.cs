﻿using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetById(Guid id);
        void Register(CourseViewModel courseViewModel);
        IEnumerable<CourseViewModel> GetAll();
        void Update(CourseViewModel courseViewModel);
        void Remove(Guid id);
    }
}
