﻿using FKRM.Application.Commands.AcademicMajor;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.AcademicMajor
{
    public abstract class AcademicMajorValidation<T> : AbstractValidator<T> where T : AcademicMajorCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotNull()
                .NotEmpty()
                .WithName("رشته دانشگاهی")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(3, 20)
                .WithMessage("طول {PropertyName} باید بین 3~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
