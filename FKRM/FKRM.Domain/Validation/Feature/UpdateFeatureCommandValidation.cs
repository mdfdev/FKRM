using FKRM.Domain.Commands.Feature;
using System;
using System.Collections.Generic;
using System.Text;

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
