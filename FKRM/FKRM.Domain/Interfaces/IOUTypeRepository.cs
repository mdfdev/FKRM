﻿using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Interfaces
{
    public interface IOUTypeRepository
    {
        IEnumerable<OUType> GetOUTypes();
    }
}
