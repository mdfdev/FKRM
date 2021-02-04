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
    public class UpdateStaffCommandHandler : IRequestHandler<UpdateStaffCommand, Response<int>>
    {
        private readonly IStaffRepository _staffRepository;
        public UpdateStaffCommandHandler(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }
        public Task<Response<int>> Handle(UpdateStaffCommand request, CancellationToken cancellationToken)
        {
            var entity = _staffRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.FirstName = request.FirstName;
                entity.LastName = request.LastName;
                entity.Mobile = request.Mobile;
                entity.Phone = request.Phone;
                entity.NationalCode = request.NationalCode;
                _staffRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
