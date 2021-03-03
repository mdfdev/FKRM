using FKRM.Domain.Commands.Major;

namespace FKRM.Domain.Validation.Major
{
    public class UpdateMajorCommandValidation : MajorValidation<UpdateMajorCommand>
    {
        public UpdateMajorCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
