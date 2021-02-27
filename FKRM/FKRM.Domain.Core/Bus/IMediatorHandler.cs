using FKRM.Domain.Core.Commands;
using FKRM.Domain.Core.Queries;
using FKRM.Domain.Core.Wrappers;
using System.Threading.Tasks;

namespace FKRM.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;

        //Task<Response<TReturn>> SendQuery<T,TReturn>(T query) where T : Query<T> where TReturn : class, new();

    }
}
