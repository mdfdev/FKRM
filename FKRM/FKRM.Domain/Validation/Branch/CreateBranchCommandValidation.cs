using FKRM.Domain.Commands.Branch;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Branch
{
    class CreateBranchCommandValidation : BranchValidation<CreateBranchCommand>
    {
        public CreateBranchCommandValidation()
        {
            ValidateName();
        }
    }
}
