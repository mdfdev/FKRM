using FKRM.Application.Commands.District;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.District
{
    public abstract class DistrictValidation<T> : AbstractValidator<T> where T : DistrictCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithName("نام منطقه")
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
