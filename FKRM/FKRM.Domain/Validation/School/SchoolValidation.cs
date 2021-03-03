﻿using FKRM.Domain.Commands.School;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.School
{
    public abstract class SchoolValidation<T> : AbstractValidator<T> where T : SchoolCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("نام مدرسه الزامی می باشد")
                .Length(2, 10).WithMessage("The name is between 2~10 characters");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
