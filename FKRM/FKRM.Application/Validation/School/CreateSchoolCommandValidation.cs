using FKRM.Application.Commands.School;

namespace FKRM.Application.Validation.School
{
    public class CreateSchoolCommandValidation : SchoolValidation<CreateSchoolCommand>
    {
        public CreateSchoolCommandValidation()
        {
            ValidateName();
        }
    }
}
