using FKRM.Application.Commands.StaffEducationalBackground;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Application.CommandHandlers
{
    public class StaffEducationalBackgroundCommandHandler : CommandHandler,
        IRequestHandler<CreateStaffEducationalBackgroundCommand, Response<int>>
    {
        private readonly IStaffEducationalBackgroundRepository _staffEducationalBackgroundRepository;
        public StaffEducationalBackgroundCommandHandler(IStaffEducationalBackgroundRepository staffEducationalBackgroundRepository)
        {
            _staffEducationalBackgroundRepository = staffEducationalBackgroundRepository;
        }
        public Task<Response<int>> Handle(CreateStaffEducationalBackgroundCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var staffEducationalBackground = new Domain.Entities.StaffEducationalBackground()
            {
                StaffId = request.StaffId,
                AcademicDegreeId = request.AcademicDegreeId,
                AcademicMajorId = request.AcademicMajorId
            };
            _staffEducationalBackgroundRepository.Add(staffEducationalBackground);
            return Task.FromResult(new Response<int>(200));
        }
    }
}
