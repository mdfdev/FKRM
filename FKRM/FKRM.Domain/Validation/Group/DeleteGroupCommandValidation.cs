using FKRM.Domain.Commands.Group;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Group
{
    public class DeleteGroupCommandValidation : GroupValidation<DeleteGroupCommand>
    {
        public DeleteGroupCommandValidation()
        {
            ValidateId();
        }
    }
}
