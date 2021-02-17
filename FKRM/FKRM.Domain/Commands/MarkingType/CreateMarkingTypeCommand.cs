using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Validation.MarkingType;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.MarkingType
{
    public class CreateMarkingTypeCommand: MarkingTypeCommand
    {
        public CreateMarkingTypeCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateMarkingTypeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
