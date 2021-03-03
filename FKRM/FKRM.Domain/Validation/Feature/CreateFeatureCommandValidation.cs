using FKRM.Domain.Commands.Feature;

namespace FKRM.Domain.Validation.Feature
{
    public class CreateFeatureCommandValidation : FeatureValidation<CreateFeatureCommand>
    {
        public CreateFeatureCommandValidation()
        {
            ValidateName();
        }
    }
}
