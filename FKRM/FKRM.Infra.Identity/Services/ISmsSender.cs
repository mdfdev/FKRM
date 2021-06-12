using System.Threading.Tasks;

namespace FKRM.Infra.Identity.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
