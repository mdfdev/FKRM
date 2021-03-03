using FKRM.Domain.Commands.MarkingType;

namespace FKRM.Domain.Validation.MarkingType
{
    public class UpdateMarkingTypeCommandValidation : MarkingTypeValidation<UpdateMarkingTypeCommand>
    {
        public UpdateMarkingTypeCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
