using FKRM.Domain.Validation.School;
using System;

namespace FKRM.Domain.Commands.School
{
    public class UpdateSchoolCommand : SchoolCommand
    {
        public UpdateSchoolCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateSchoolCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
