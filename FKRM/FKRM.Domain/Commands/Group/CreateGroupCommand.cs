﻿using FKRM.Domain.Validation.Group;
using System;

namespace FKRM.Domain.Commands.Group
{
    public class CreateGroupCommand : GroupCommand
    {
        public CreateGroupCommand(string name, Guid areaId)
        {
            Name = name;
            AreaId = areaId;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateGroupCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
