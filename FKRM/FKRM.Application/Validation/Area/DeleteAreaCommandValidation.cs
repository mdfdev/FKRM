using FKRM.Application.Commands.Area;

namespace FKRM.Application.Validation.Area
{
    public class DeleteAreaCommandValidation : AreaValidation<DeleteAreaCommand>
    {
        public DeleteAreaCommandValidation()
        {
            ValidateName();
        }
    }
}
