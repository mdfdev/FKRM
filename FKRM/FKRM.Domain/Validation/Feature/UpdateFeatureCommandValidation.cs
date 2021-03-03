using FKRM.Domain.Commands.Feature;

namespace FKRM.Domain.Validation.Feature
{
    public class UpdateFeatureCommandValidation : FeatureValidation<UpdateFeatureCommand>
    {
        public UpdateFeatureCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
