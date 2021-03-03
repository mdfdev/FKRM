
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Entities;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using FKRM.Domain.Queries.Area;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.QueryHandlers
{
    public class AreaQueryHandler :
        IRequestHandler<GetAllAreaQuery, Response<IQueryable<Area>>>,
        IRequestHandler<GetAreaByIdQuery, Response<Area>>
    {
        private readonly IAreaRepository _areaRepository;

        public AreaQueryHandler(IAreaRepository areaRepository)
        {
            _areaRepository = areaRepository;
        }
        public Task<Response<IQueryable<Area>>> Handle(GetAllAreaQuery request, CancellationToken cancellationToken)
        {
            var areas = _areaRepository.GetAll();
            if (areas == null) throw new ApiException($"Area Not Found.");
            return Task.FromResult(new Response<IQueryable<Area>>(areas));
        }

        public Task<Response<Area>> Handle(GetAreaByIdQuery request, CancellationToken cancellationToken)
        {
            var area = _areaRepository.GetById(request.Id);
            if (area == null) throw new ApiException($"Area Not Found.");
            return Task.FromResult(new Response<Area>(area));
        }
    }
}
