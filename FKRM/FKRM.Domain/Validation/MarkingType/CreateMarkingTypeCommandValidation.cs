using FKRM.Domain.Commands.MarkingType;

namespace FKRM.Domain.Validation.MarkingType
{
    public class CreateMarkingTypeCommandValidation : MarkingTypeValidation<CreateMarkingTypeCommand>
    {
        public CreateMarkingTypeCommandValidation()
        {
            ValidateName();
        }
    }
}
