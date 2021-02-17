using FKRM.Domain.Commands.Branch;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Branch
{
    public class DeleteBranchCommandValidation : BranchValidation<DeleteBranchCommand>
    {
        public DeleteBranchCommandValidation()
        {
            ValidateId();
        }
    }
}
