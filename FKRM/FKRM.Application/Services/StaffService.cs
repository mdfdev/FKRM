using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class StaffService : IStaffService
    {
        private IStaffRepository _staffRepository;
        public StaffService(IStaffRepository repository)
        {
            _staffRepository = repository;
        }
        public StaffViewModel GetStaff()
        {
            return new StaffViewModel()
            {
                staffs = _staffRepository.GetStaffs()
            };
        }
    }
}
