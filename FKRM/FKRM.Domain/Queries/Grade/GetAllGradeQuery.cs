using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.Queries.Grade
{
    public class GetAllGradeQuery:IRequest<Response<IQueryable<Entities.Grade>>>
    {
        public GetAllGradeQuery()
        {

        }
    }
    public class GetAllGradeQueryHandler : IRequestHandler<GetAllGradeQuery, Response<IQueryable<Entities.Grade>>>
    {
        private readonly IGradeRepository _gradeRepository;
        public GetAllGradeQueryHandler(IGradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }
        public Task<Response<IQueryable<Entities.Grade>>> Handle(GetAllGradeQuery request, CancellationToken cancellationToken)
        {
            var grade = _gradeRepository.GetAll();
            if (grade == null) throw new ApiException($"Product Not Found.");
            return Task.FromResult(new Response<IQueryable<Entities.Grade>>(grade));
        }
    }
}
