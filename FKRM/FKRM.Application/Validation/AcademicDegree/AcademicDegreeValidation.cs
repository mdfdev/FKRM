using FKRM.Application.Commands.AcademicDegree;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.AcademicDegree
{
    public abstract class AcademicDegreeValidation<T> : AbstractValidator<T> where T : AcademicDegreeCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotNull()
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
