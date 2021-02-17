using FKRM.Domain.Commands.Area;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Area
{
    public class UpdateAreaCommandValidation : AreaValidation<UpdateAreaCommand>
    {
        public UpdateAreaCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
