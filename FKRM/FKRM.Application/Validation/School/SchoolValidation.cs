using FKRM.Application.Commands.School;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.School
{
    public abstract class SchoolValidation<T> : AbstractValidator<T> where T : SchoolCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("نام مدرسه الزامی می باشد")
                .Length(3, 30).WithMessage("طول نام باید بین 2~30  کاراکتر باشد");
        }
        protected void ValidateCode()
        {
            RuleFor(c => c.Code)
                .NotEmpty().WithMessage("کد مدرسه الزامی می باشد")
                .Length(3, 15).WithMessage("کد باید بین 3~15  کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
