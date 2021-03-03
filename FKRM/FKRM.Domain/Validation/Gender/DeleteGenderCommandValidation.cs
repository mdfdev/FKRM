using FKRM.Domain.Commands.Gender;

namespace FKRM.Domain.Validation.Gender
{
    public class DeleteGenderCommandValidation : GenderValidation<DeleteGenderCommand>
    {
        public DeleteGenderCommandValidation()
        {
            ValidateId();
        }
    }
}
