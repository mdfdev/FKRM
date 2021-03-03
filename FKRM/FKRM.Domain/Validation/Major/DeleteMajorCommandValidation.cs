using FKRM.Domain.Commands.Major;

namespace FKRM.Domain.Validation.Major
{
    public class DeleteMajorCommandValidation : MajorValidation<DeleteMajorCommand>
    {
        public DeleteMajorCommandValidation()
        {
            ValidateId();
        }
    }
}
