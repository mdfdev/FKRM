﻿using FKRM.Domain.Commands.Staff;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
namespace FKRM.Domain.CommandHandlers
{
    public class StaffCommandHandler : CommandHandler,
        IRequestHandler<CreateStaffCommand, Response<int>>,
        IRequestHandler<DeleteStaffCommand, Response<int>>,
        IRequestHandler<UpdateStaffCommand, Response<int>>
    {
        private readonly IStaffRepository _staffRepository;
        public StaffCommandHandler(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }
        public Task<Response<int>> Handle(UpdateStaffCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
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
                entity.ModifiedDate = request.ModifiedDate;
                _staffRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
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
        public Task<Response<int>> Handle(CreateStaffCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var staff = new Entities.Staff()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Phone = request.Phone,
                Mobile = request.Mobile,
                NationalCode = request.NationalCode,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _staffRepository.Add(staff);
            return Task.FromResult(new Response<int>(200));
        }
    }
}
