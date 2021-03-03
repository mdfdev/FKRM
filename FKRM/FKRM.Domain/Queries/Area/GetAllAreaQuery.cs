using FKRM.Domain.Core.Wrappers;
using MediatR;
using System.Linq;

namespace FKRM.Domain.Queries.Area
{
    public class GetAllAreaQuery : IRequest<Response<IQueryable<Entities.Area>>>
    {
        public GetAllAreaQuery()
        {

        }
    }
}
