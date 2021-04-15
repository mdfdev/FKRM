using FKRM.Application.Commands.Gender;

namespace FKRM.Application.Validation.Gender
{
    public class DeleteGenderCommandValidation : GenderValidation<DeleteGenderCommand>
    {
        public DeleteGenderCommandValidation()
        {
            ValidateId();
        }
    }
}
