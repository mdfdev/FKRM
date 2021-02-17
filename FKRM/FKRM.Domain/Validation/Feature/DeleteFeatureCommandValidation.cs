using FKRM.Domain.Commands.Feature;
using System;
using System.Collections.Generic;
using System.Text;

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
