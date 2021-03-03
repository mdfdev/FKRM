using FKRM.Domain.Commands.School;

namespace FKRM.Domain.Validation.School
{
    public class UpdateSchoolCommandValidation : SchoolValidation<UpdateSchoolCommand>
    {
        public UpdateSchoolCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
