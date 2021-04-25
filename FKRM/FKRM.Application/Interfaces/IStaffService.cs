﻿using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IStaffService
    {
        StaffViewModel GetById(Guid id);
        Task<Response<int>> Register(StaffViewModel staffViewModel);
        IEnumerable<StaffViewModel> GetAll();
        IEnumerable<StaffViewModel> GetPagedResponse(int pageNumber, int pageSize);
        Task<Response<int>> Update(StaffViewModel staffViewModel);
        Task<Response<int>> Remove(Guid id);

        Task<Response<IEnumerable<StaffViewModel>>>  GetAllData(Guid id);
        Task<Response<StaffViewModel>> GetAllDataById(Guid id);
        Task<Response<StaffViewModel>> GetAllDataByNid(string nid);
    }
}
