using FKRM.Application.Commands.Gender;

namespace FKRM.Application.Validation.Gender
{
    public class CreateGenderCommandValidation : GenderValidation<CreateGenderCommand>
    {
        public CreateGenderCommandValidation()
        {
            ValidateName();
        }
    }
}
