using Microsoft.AspNetCore.Identity;


namespace FKRM.Infra.Identity.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
