using FKRM.Domain.Commands.Group;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Group
{
    public class UpdateGroupCommandValidation : GroupValidation<UpdateGroupCommand>
    {
        public UpdateGroupCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
