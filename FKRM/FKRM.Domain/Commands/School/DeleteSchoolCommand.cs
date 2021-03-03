using FKRM.Domain.Validation.School;
using System;

namespace FKRM.Domain.Commands.School
{
    public class DeleteSchoolCommand : SchoolCommand
    {
        public DeleteSchoolCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteSchoolCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
