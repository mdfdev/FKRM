using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class StaffRepository : IStaffRepository
    {
        private SchoolDBContext _ctx;
        public StaffRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Staff> GetStaffs()
        {
            return _ctx.Staffs;
        }
    }
}
