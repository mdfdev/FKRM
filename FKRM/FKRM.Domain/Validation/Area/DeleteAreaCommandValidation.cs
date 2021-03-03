using FKRM.Domain.Commands.Area;

namespace FKRM.Domain.Validation.Area
{
    public class DeleteAreaCommandValidation : AreaValidation<DeleteAreaCommand>
    {
        public DeleteAreaCommandValidation()
        {
            ValidateName();
        }
    }
}
