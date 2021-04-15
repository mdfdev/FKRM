using FKRM.Application.Commands.MarkingType;

namespace FKRM.Application.Validation.MarkingType
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
