using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Gender
{
    public class DeleteGenderCommandValidation : GenderValidation<DeleteGenderCommand>
    {
        public DeleteGenderCommandValidation()
        {
            ValidateId();
        }
    }
}
