using FKRM.Application.Commands.MarkingType;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.MarkingType
{
    public abstract class MarkingTypeValidation<T> : AbstractValidator<T> where T : MarkingTypeCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithName("عنوان شغلی")
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
