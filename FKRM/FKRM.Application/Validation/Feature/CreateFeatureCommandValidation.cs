using FKRM.Application.Commands.Feature;

namespace FKRM.Application.Validation.Feature
{
    public class CreateFeatureCommandValidation : FeatureValidation<CreateFeatureCommand>
    {
        public CreateFeatureCommandValidation()
        {
            ValidateName();
        }
    }
}
