using FKRM.Application.Commands.Major;

namespace FKRM.Application.Validation.Major
{
    public class CreateMajorCommandValidation : MajorValidation<CreateMajorCommand>
    {
        public CreateMajorCommandValidation()
        {
            ValidateName();
        }
    }
}
