using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKRM.Mvc.Helper
{
    public class PersianIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = nameof(PasswordTooShort),
                Description = $"طول کلمه عبور باید حداقل {length} کاراکتر باشد."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = "کلمه عبور باید شامل حداقل یک کاراکتر حرفی یا عددی باشد."
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresDigit),
                Description = "کلمه عبور باید شامل حداقل یک عدد باشد ('0'-'9')."
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresLower),
                Description = "کلمه عبور باید شامل حداقل یک حرف کوچک باشد ('a'-'z')."
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUpper),
                Description = "کلمه عبور باید شامل حداقل یک حرف بزرگ باشد ('A'-'Z')."
            };
        }

    }
}
