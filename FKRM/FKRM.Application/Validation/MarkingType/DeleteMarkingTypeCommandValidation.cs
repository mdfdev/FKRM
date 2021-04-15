using FKRM.Application.Commands.MarkingType;

namespace FKRM.Application.Validation.MarkingType
{
    public class DeleteMarkingTypeCommandValidation : MarkingTypeValidation<DeleteMarkingTypeCommand>
    {
        public DeleteMarkingTypeCommandValidation()
        {
            ValidateId();
        }
    }
}
