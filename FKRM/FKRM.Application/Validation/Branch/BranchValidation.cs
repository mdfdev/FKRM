using FKRM.Application.Commands.Branch;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.Branch
{
    public abstract class BranchValidation<T> : AbstractValidator<T> where T : BranchCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithName("نام شاخه")
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
