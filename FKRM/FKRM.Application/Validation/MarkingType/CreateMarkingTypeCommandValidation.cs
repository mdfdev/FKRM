using FKRM.Application.Commands.MarkingType;

namespace FKRM.Application.Validation.MarkingType
{
    public class CreateMarkingTypeCommandValidation : MarkingTypeValidation<CreateMarkingTypeCommand>
    {
        public CreateMarkingTypeCommandValidation()
        {
            ValidateName();
        }
    }
}
