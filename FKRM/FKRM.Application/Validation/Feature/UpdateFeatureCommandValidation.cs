using FKRM.Application.Commands.Feature;

namespace FKRM.Application.Validation.Feature
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
