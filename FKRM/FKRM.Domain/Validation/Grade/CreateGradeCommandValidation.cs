﻿using FKRM.Domain.Commands.Grade;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Grade
{
    public class CreateGradeCommandValidation:GradeValidation<CreateGradeCommand>
    {
        public CreateGradeCommandValidation()
        {
            ValidateName();
        }
    }
}
