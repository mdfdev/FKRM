using FKRM.Domain.Commands.Major;

namespace FKRM.Domain.Validation.Major
{
    public class CreateMajorCommandValidation : MajorValidation<CreateMajorCommand>
    {
        public CreateMajorCommandValidation()
        {
            ValidateName();
        }
    }
}
