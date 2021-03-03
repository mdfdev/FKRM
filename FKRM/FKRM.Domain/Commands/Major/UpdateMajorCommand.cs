﻿using FKRM.Domain.Validation.Major;
using System;

namespace FKRM.Domain.Commands.Major
{
    public class UpdateMajorCommand : MajorCommand
    {
        public UpdateMajorCommand(Guid id, string name, string computerCode, int requiredCredit, int optionalElectiveCredit, int graduationCredits)
        {
            ID = id;
            Name = name;
            ComputerCode = computerCode;
            RequiredCredit = requiredCredit;
            OptionalElectiveCredit = optionalElectiveCredit;
            GraduationCredits = graduationCredits;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateMajorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
