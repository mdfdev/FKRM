﻿using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Room
{
    public abstract class RoomCommand:Command
    {
        public string Name { get; protected set; }
    }
}