﻿using FKRM.Application.Validation.Grade;
using System;

namespace FKRM.Application.Commands.Grade
{
    public class DeleteGradeCommand : GradeCommand
    {
        public DeleteGradeCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteGradeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}