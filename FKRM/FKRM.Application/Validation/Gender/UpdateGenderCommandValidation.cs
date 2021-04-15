using FKRM.Application.Commands.Gender;

namespace FKRM.Application.Validation.Gender
{
    public class UpdateGenderCommandValidation : GenderValidation<UpdateGenderCommand>
    {
        public UpdateGenderCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
