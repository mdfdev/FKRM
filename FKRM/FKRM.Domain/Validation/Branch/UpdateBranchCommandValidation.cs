using FKRM.Domain.Commands.Branch;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Branch
{
    public class UpdateBranchCommandValidation : BranchValidation<UpdateBranchCommand>
    {
        public UpdateBranchCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
