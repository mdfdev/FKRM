using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Identity.Models
{
    public class ManageViewModel
    {
        public List<ManageUserRolesViewModel> manageUserRoles { get; set; }
        public ResetPasswordModel resetPasswordModel { get; set; }
    }
}
