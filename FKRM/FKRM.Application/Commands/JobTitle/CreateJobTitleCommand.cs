using FKRM.Application.Validation.JobTitle;

namespace FKRM.Application.Commands.JobTitle
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
