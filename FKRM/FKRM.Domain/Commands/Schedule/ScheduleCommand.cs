﻿using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Schedule
{
    public abstract class ScheduleCommand:Command
    {
        public string Name { get; protected set; }
    }
}