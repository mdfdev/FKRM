using FKRM.Application.Commands.Grade;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.Grade
{
    public abstract class GradeValidation<T> : AbstractValidator<T> where T : GradeCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithName("نام پایه")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(2, 10)
                .WithMessage("طول {PropertyName} باید بین 2~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
