using FKRM.Application.Commands.JobTitle;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.JobTitle
{
    public abstract class JobTitleValidation<T> : AbstractValidator<T> where T : JobTitleCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Title)
                .NotEmpty()
                .NotNull()
                .WithName("عنوان شغلی")
                .WithMessage("{PropertyName} الزامی می باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
