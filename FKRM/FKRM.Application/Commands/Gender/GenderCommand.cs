﻿using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.Gender
{
    public abstract class GenderCommand : Command
    {
        public Guid ID { get; protected set; }
        public string Name { get; protected set; }
    }
}