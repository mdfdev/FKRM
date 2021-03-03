using FKRM.Domain.Commands.Gender;

namespace FKRM.Domain.Validation.Gender
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
