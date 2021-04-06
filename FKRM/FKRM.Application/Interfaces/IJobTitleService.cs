﻿using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IJobTitleService
    {
        JobTitleViewModel GetById(Guid id);
        Task<Response<int>> Register(JobTitleViewModel jobTitleViewModel);
        IEnumerable<JobTitleViewModel> GetAll();
        IEnumerable<JobTitleViewModel> GetPagedResponse(int pageNumber, int pageSize);

        Task<Response<int>> Update(JobTitleViewModel jobTitleViewModel);
        Task<Response<int>> Remove(Guid id);
    }
}