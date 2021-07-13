using FKRM.Application.Commands.Staff;
using FKRM.Application.Extension;
using FluentValidation;
using System;


namespace FKRM.Application.Validation.Staff
{
    public class StaffValidation<T> : AbstractValidator<T> where T : StaffCommand
    {
        protected void ValidateFirstName()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty()
                .WithName("نام")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(2, 20)
                .WithMessage("طول {PropertyName} باید بین 2~20 کاراکتر باشد");
        }
        protected void ValidateLastName()
        {
            RuleFor(c => c.LastName)
                .NotEmpty()
                .WithName("نام خانوادگی")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(2, 20)
                .WithMessage("طول {PropertyName} باید بین 2~20 کاراکتر باشد");
        }
        protected void ValidateNationalID()
        {
            RuleFor(c => c.NationalCode)
                .NotEmpty()
                .WithName("کد ملی")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(10)
                .WithMessage("طول {PropertyName} باید 10 کاراکتر باشد")
                .Must(p=>p.CheckNationId())
                .WithMessage("{PropertyName} وارد شده معتبر نمی باشد");
        }
        protected void ValidateMobile()
        {
            RuleFor(c => c.Mobile)
                .NotEmpty()
                .WithName("شماره موبایل")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(11)
                .WithMessage("طول {PropertyName} باید 11 کاراکتر باشد")
                .Matches("09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}")
                .WithMessage("{PropertyName} صحیح نمی باشد");
        }
        protected void ValidatePhone()
        {
            RuleFor(c => c.Phone)
                .Length(11)
                .WithName("شماره ثابت")
                .WithMessage("طول {PropertyName} باید 11 کاراکتر باشد")
                .Matches("^0[0-9]{2,}[0-9]{7,}$")
                .WithMessage("{PropertyName} صحیح نمی باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
        protected void ValidateEmail()
        {
            RuleFor(c => c.Email)
                .EmailAddress();
        }
        protected void ValidateBirthDate()
        {
            RuleFor(c => c.BirthDate)
                .NotEmpty()
                .WithName("تاریخ تولد")
                .WithMessage("{PropertyName} الزامی می باشد");
        }
        protected void ValidateHiringDate()
        {
            RuleFor(c => c.HiringDate)
                .NotEmpty()
                .WithName("تاریخ اشتغال به کار")
                .WithMessage("{PropertyName}  الزامی می باشد");
        }
    }
}
