using FKRM.Domain.Validation.JobTitle;

namespace FKRM.Domain.Commands.JobTitle
{
    public class CreateJobTitleCommand : JobTitleCommand
    {
        public CreateJobTitleCommand(string title)
        {
            Title = title;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateJobTitleCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
