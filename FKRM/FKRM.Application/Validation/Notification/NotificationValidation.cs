using FKRM.Application.Commands.Notification;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Validation.Notification
{
    public abstract class NotificationValidation<T> : AbstractValidator<T> where T : NotificationCommand
    {
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
        protected void ValidateBody()
        {
            RuleFor(c => c.Body)
                .NotEmpty()
                .WithName("متن پیام")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(5, 500)
                .WithMessage("طول {PropertyName} باید بین 5~500 کاراکتر باشد");
        }
        protected void ValidateSubject()
        {
            RuleFor(c => c.Subject)
                .NotEmpty()
                .WithName("عنوان پیام")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(5, 100)
                .WithMessage("طول {PropertyName} باید بین 5~100 کاراکتر باشد");
        }
    }
}
