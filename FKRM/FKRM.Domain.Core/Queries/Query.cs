using FKRM.Domain.Core.Wrappers;
using MediatR;

namespace FKRM.Domain.Core.Queries
{
    public abstract class Query<T> : IRequest<Response<T>>
    {

    }
}
