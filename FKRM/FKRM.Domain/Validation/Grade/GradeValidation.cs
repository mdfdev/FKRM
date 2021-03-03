using FKRM.Domain.Commands.Grade;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.Grade
{
    public abstract class GradeValidation<T> : AbstractValidator<T> where T : GradeCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("نام پایه الزامی می باشد")
                .Length(2, 10).WithMessage("طول نام باید بین 2~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
