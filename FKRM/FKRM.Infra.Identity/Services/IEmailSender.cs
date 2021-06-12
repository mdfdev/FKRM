using System.Threading.Tasks;

namespace FKRM.Infra.Identity.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
