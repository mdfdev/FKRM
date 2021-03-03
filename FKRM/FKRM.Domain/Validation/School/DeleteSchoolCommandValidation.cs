using FKRM.Domain.Commands.School;

namespace FKRM.Domain.Validation.School
{
    public class DeleteSchoolCommandValidation : SchoolValidation<DeleteSchoolCommand>
    {
        public DeleteSchoolCommandValidation()
        {
            ValidateId();
        }
    }
}
