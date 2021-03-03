using FKRM.Domain.Commands.Gender;

namespace FKRM.Domain.Validation.Gender
{
    public class CreateGenderCommandValidation : GenderValidation<CreateGenderCommand>
    {
        public CreateGenderCommandValidation()
        {
            ValidateName();
        }
    }
}
