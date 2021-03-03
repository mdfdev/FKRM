using FKRM.Domain.Commands.School;

namespace FKRM.Domain.Validation.School
{
    public class CreateSchoolCommandValidation : SchoolValidation<CreateSchoolCommand>
    {
        public CreateSchoolCommandValidation()
        {
            ValidateName();
        }
    }
}
