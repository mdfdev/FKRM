using FKRM.Application.Commands.School;

namespace FKRM.Application.Validation.School
{
    public class DeleteSchoolCommandValidation : SchoolValidation<DeleteSchoolCommand>
    {
        public DeleteSchoolCommandValidation()
        {
            ValidateId();
        }
    }
}
