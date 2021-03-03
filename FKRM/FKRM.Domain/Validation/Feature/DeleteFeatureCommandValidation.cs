using FKRM.Domain.Commands.Feature;

namespace FKRM.Domain.Validation.Feature
{
    public class DeleteFeatureCommandValidation : FeatureValidation<DeleteFeatureCommand>
    {
        public DeleteFeatureCommandValidation()
        {
            ValidateId();
        }
    }
}
