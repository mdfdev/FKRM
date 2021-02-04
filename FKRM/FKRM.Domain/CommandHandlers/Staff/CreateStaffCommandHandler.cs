using FKRM.Domain.Commands.Staff;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers.Staff
{
    public class CreateStaffCommandHandler : IRequestHandler<CreateStaffCommand, Response<int>>
    {
        private readonly IStaffRepository _staffRepository;
        public CreateStaffCommandHandler(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public Task<Response<int>> Handle(CreateStaffCommand request, CancellationToken cancellationToken)
        {
            var staff = new Entities.Staff()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Phone = request.Phone,
                Mobile = request.Mobile,
                NationalCode = request.NationalCode
            };
            _staffRepository.Add(staff);
            return Task.FromResult(new Response<int>(200));
        }
    }
}
