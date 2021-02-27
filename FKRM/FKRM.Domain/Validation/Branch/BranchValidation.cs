using FKRM.Domain.Commands.Branch;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.Branch
{
    public abstract class BranchValidation<T> : AbstractValidator<T> where T : BranchCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("نام شاخه نمی تواند خالی باشد")
                .Length(3, 20).WithMessage("طول نام باشد بین 2~10 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
