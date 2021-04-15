using FKRM.Application.Validation.JobTitle;
using System;

namespace FKRM.Application.Commands.JobTitle
{
    public class UpdateJobTitleCommand : JobTitleCommand
    {
        public UpdateJobTitleCommand(Guid id, string title)
        {
            ID = id;
            Title = title;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateJobTitleCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
