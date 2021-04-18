using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FKRM.Domain.Interfaces
{
    public interface IStaffRepository : IRepository<Staff>
    {
        Staff Get(string ncode,Guid academicCalendarId);
    }
}
