using FKRM.Domain.Commands.MarkingType;

namespace FKRM.Domain.Validation.MarkingType
{
    public class DeleteMarkingTypeCommandValidation : MarkingTypeValidation<DeleteMarkingTypeCommand>
    {
        public DeleteMarkingTypeCommandValidation()
        {
            ValidateId();
        }
    }
}
