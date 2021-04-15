using FKRM.Application.Commands.Staff;
using FluentValidation;
using System;


namespace FKRM.Application.Validation.Staff
{
    public class StaffValidation<T> : AbstractValidator<T> where T : StaffCommand
    {
        protected void ValidateFirstName()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty().WithMessage("نام الزامی می باشد")
                .Length(2, 20).WithMessage("طول نام باید بین 2~20 کاراکتر باشد");
        }
        protected void ValidateLastName()
        {
            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("نام خانوادگی الزامی می باشد")
                .Length(2, 20).WithMessage("طول نام باید بین 2~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
