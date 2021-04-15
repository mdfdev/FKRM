using FKRM.Application.Commands.Feature;

namespace FKRM.Application.Validation.Feature
{
    public class DeleteFeatureCommandValidation : FeatureValidation<DeleteFeatureCommand>
    {
        public DeleteFeatureCommandValidation()
        {
            ValidateId();
        }
    }
}
