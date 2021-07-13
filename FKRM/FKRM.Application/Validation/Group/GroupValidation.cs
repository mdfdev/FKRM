using FKRM.Application.Commands.Group;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.Group
{
    public abstract class GroupValidation<T> : AbstractValidator<T> where T : GroupCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithName("نام گروه")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(3, 40)
                .WithMessage("طول {PropertyName} باید بین 3~40 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
