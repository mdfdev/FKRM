using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Gender
{
    public class CreateGenderCommandValidation : GenderValidation<CreateGenderCommand>
    {
        public CreateGenderCommandValidation()
        {
            ValidateName();
        }
    }
}
