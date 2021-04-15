using FKRM.Application.Commands.Major;

namespace FKRM.Application.Validation.Major
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
