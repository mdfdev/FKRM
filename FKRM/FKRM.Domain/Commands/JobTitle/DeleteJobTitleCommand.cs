using FKRM.Domain.Validation.JobTitle;
using System;

namespace FKRM.Domain.Commands.JobTitle
{
    public class DeleteJobTitleCommand : JobTitleCommand
    {
        public DeleteJobTitleCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteJobTitleCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
