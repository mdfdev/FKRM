﻿using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Domain.Interfaces
{
    public interface IGroupRepository
    {
        IQueryable<Group> GetGroups();
        void Add(Group group);
    }
}
