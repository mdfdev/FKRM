using FKRM.Application.Validation.School;
using System;

namespace FKRM.Application.Commands.School
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
