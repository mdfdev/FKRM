﻿using FKRM.Domain.Commands.JobTitle;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.JobTitle
{
    public abstract class JobTitleValidation<T> : AbstractValidator<T> where T : JobTitleCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Title)
                .NotEmpty().NotNull().WithMessage("نام عنوان شغلی الزامی می باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}