using FKRM.Application.Commands.Major;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.Major
{
    public abstract class MajorValidation<T> : AbstractValidator<T> where T : MajorCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithName("عنوان شغلی")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(3, 30)
                .WithMessage("طول {PropertyName} باید بین 3~30 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
