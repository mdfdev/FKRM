using FKRM.Domain.Commands.Staff;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers.Staff
{
    public class DeleteStaffCommandHandler : IRequestHandler<DeleteStaffCommand, Response<int>>
    {
        private readonly IStaffRepository _staffRepository;
        public DeleteStaffCommandHandler(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }
        public Task<Response<int>> Handle(DeleteStaffCommand request, CancellationToken cancellationToken)
        {
            var entity = _staffRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _staffRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }
    }
}
