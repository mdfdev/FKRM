﻿using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Area
{
    public abstract class AreaCommand : Command
    {
        public string Name { get; protected set; }
    }
}