using FKRM.Application.Commands.School;

namespace FKRM.Application.Validation.School
{
    public class UpdateSchoolCommandValidation : SchoolValidation<UpdateSchoolCommand>
    {
        public UpdateSchoolCommandValidation()
        {
            ValidateId();
            ValidateName();
            ValidateCode();
        }
    }
}
