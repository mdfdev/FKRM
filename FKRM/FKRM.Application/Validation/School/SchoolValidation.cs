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
                .Length(5, 100).WithMessage("طول نام باید بین 5~100 کاراکتر باشد");
        }
        protected void ValidateCode()
        {
            RuleFor(c => c.Code)
                .NotEmpty().WithMessage("کد مدرسه الزامی می باشد")
                .Length(8).WithMessage("طول کد باید 8 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
