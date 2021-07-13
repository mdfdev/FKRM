using FKRM.Application.Commands.Staff;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using FKRM.Application.Extension;

namespace FKRM.Application.CommandHandlers
{
    public class StaffCommandHandler : CommandHandler,
        IRequestHandler<CreateStaffCommand, Response<int>>,
        IRequestHandler<DeleteStaffCommand, Response<int>>,
        IRequestHandler<UpdateStaffCommand, Response<int>>
    {
        private readonly IStaffRepository _staffRepository;
        private readonly IWorkedForRepository _workedForRepository;
        public StaffCommandHandler(IStaffRepository staffRepository, IWorkedForRepository workedForRepository)
        {
            _staffRepository = staffRepository;
            _workedForRepository = workedForRepository;
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
                entity.JobTitleId = request.JobTitleId;
                entity.BirthDate = request.BirthDate.PersianToEnglish().ToGeorgianDate();
                entity.HiringDate = request.HiringDate.PersianToEnglish().ToGeorgianDate();
                entity.Email = request.Email;
                entity.Bio = request.Email;
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
            if (_staffRepository.Get(request.NationalCode, request.AcademicCalendarId) != null)
            {
                return Task.FromResult(new Response<int>(400, new List<string>() { "ثبت اطلاعات تکراری!!!" }));
            }
            else if (_staffRepository.Get(request.NationalCode) != null)
            {
                var st = _staffRepository.Get(request.NationalCode);
                _workedForRepository.Add(new Domain.Entities.WorkedFor()
                {
                    StaffId = st.Id,
                    AcademicCalendarId = request.AcademicCalendarId,
                    SchoolId = request.SchoolId
                });
            }
            else
            {
                var staff = new Domain.Entities.Staff()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    JobTitleId = request.JobTitleId,
                    Phone = request.Phone,
                    Mobile = request.Mobile,
                    NationalCode = request.NationalCode,
                    ModifiedDate = request.ModifiedDate,
                    AddedDate = request.AddedDate,
                    BirthDate = request.BirthDate.PersianToEnglish().ToGeorgianDate(),
                    HiringDate = request.HiringDate.PersianToEnglish().ToGeorgianDate(),
                    Email = request.Email,
                    Bio = request.Bio,
                    WorkedFors = new List<Domain.Entities.WorkedFor>
                    {
                        new Domain.Entities.WorkedFor {
                            SchoolId=request.SchoolId,
                            AcademicCalendarId = request.AcademicCalendarId
                        }
                    }
                };
                _staffRepository.Add(staff);
            }
            return Task.FromResult(new Response<int>(200));
        }
    }
}
