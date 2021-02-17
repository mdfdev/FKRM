﻿using FKRM.Domain.Commands.Grade;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Grade
{
    public abstract class GradeValidation<T> : AbstractValidator<T> where T : GradeCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Name cannot be empty")
                .Length(2, 10).WithMessage("The name is between 2~10 characters");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
