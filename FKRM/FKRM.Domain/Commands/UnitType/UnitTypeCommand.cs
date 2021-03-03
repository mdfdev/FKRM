﻿using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Domain.Commands.UnitType
{
    public abstract class UnitTypeCommand : Command
    {
        public Guid ID { get; protected set; }
        public string Name { get; protected set; }
    }
}
