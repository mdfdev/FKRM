using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.Queries.Gender
{
    public class GetGenderByIdQueryHandler : IRequestHandler<GetGenderByIdQuery, Response<Entities.Gender>>
    {
        private readonly IGenderRepository _genderRepository;
        public GetGenderByIdQueryHandler(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }

        public Task<Response<Entities.Gender>> Handle(GetGenderByIdQuery request, CancellationToken cancellationToken)
        {
            var gender = _genderRepository.GetById(request.Id);
            if (gender == null) throw new ApiException($"Product Not Found.");
            return Task.FromResult(new Response<Entities.Gender>(gender));
        }
    }
}
