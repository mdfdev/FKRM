using FKRM.Domain.Commands.Feature;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Feature
{
    public class CreateFeatureCommandValidation:FeatureValidation<CreateFeatureCommand>
    {
        public CreateFeatureCommandValidation()
        {
            ValidateName();
        }
    }
}
