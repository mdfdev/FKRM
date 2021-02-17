using FKRM.Domain.Commands.Staff;
using FluentValidation;
using System;


namespace FKRM.Domain.Validation.Staff
{
    public class StaffValidation<T> : AbstractValidator<T> where T : StaffCommand
    {
        protected void ValidateFirstName()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty().WithMessage("FirstName cannot be empty")
                .Length(2, 10).WithMessage("The name is between 2~10 characters");
        }
        protected void ValidateLastName()
        {
            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("LastName cannot be empty")
                .Length(2, 10).WithMessage("The name is between 2~10 characters");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
