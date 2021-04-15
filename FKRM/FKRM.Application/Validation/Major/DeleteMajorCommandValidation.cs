using FKRM.Application.Commands.Major;

namespace FKRM.Application.Validation.Major
{
    public class DeleteMajorCommandValidation : MajorValidation<DeleteMajorCommand>
    {
        public DeleteMajorCommandValidation()
        {
            ValidateId();
        }
    }
}
