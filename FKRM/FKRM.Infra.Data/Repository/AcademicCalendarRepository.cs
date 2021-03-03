﻿using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class AcademicCalendarRepository : Repository<AcademicCalendar>, IAcademicCalendarRepository
    {
        public AcademicCalendarRepository(SchoolDBContext context) : base(context)
        {
        }
    }
}
