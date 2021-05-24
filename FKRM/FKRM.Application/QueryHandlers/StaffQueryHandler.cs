using FKRM.Application.Extension;
using FKRM.Application.Queries.Staff;
using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Application.QueryHandlers
{
    public class StaffQueryHandler : 
        IRequestHandler<GetStaffAllData, Response<IEnumerable<StaffViewModel>>>,
        IRequestHandler<GetAllDataById,Response< StaffViewModel>>,
         IRequestHandler<GetAllDataByNid, Response<StaffViewModel>>
    {
        private readonly IStaffRepository _staffRepository;
        private readonly IWorkedForRepository _workedForRepository;
        private readonly ISchoolRepository _schoolRepository;
        private readonly IAcademicCalendarRepository _academicCalendarRepository;
        public StaffQueryHandler(IStaffRepository staffRepository,
            IWorkedForRepository workedForRepository,
            ISchoolRepository schoolRepository,
            IAcademicCalendarRepository academicCalendarRepository)
        {
            _staffRepository = staffRepository;
            _workedForRepository = workedForRepository;
            _schoolRepository = schoolRepository;
            _academicCalendarRepository = academicCalendarRepository;
        }

        public Task<Response<IEnumerable<StaffViewModel>>> Handle(GetStaffAllData request, CancellationToken cancellationToken)
        {
            var staffs = _staffRepository.GetAll();
            var workedFors = _workedForRepository.GetAll();
            var schools = _schoolRepository.GetAll();
            var academicCalendars = _academicCalendarRepository.GetAll();
            return Task.FromResult(new Response<IEnumerable<StaffViewModel>>(
                staffs
                .Join(workedFors, st => st.Id, w => w.StaffId, (st, w) => new { st, w })
                .Join(schools, p => p.w.SchoolId, sc => sc.Id, (p, sc) => new { p, sc })
                .Join(academicCalendars.Where(n => n.Id == request.Id), p => p.p.w.AcademicCalendarId, ac => ac.Id, (p, ac) => new { p, ac })
                .Select(p => new StaffViewModel
                {
                    Id = p.p.p.st.Id,
                    FirstName = p.p.p.st.FirstName,
                    LastName = p.p.p.st.LastName,
                    School = p.p.sc.Name,
                    AcademicCalendar = p.ac.AcademicQuarter + " " + p.ac.AcademicYear,
                    JobTitle = p.p.p.st.JobTitle.Title,
                    Mobile = p.p.p.st.Mobile,
                    Phone = p.p.p.st.Phone,
                    BirthDate = p.p.p.st.BirthDate.ToPersianDate(),
                    HiringDate = p.p.p.st.HiringDate.ToPersianDate(),
                    NationalCode = p.p.p.st.NationalCode
                })));
        }

        public Task<Response<StaffViewModel>> Handle(GetAllDataById request, CancellationToken cancellationToken)
        {
            var staffs = _staffRepository.GetAll();
            var workedFors = _workedForRepository.GetAll();
            var schools = _schoolRepository.GetAll();
            var academicCalendars = _academicCalendarRepository.GetAll();
            return Task.FromResult(new Response<StaffViewModel>(
                staffs.Where(p => p.Id == request.Id)
                .Join(workedFors, st => st.Id, w => w.StaffId, (st, w) => new { st, w })
                .Join(schools, p => p.w.SchoolId, sc => sc.Id, (p, sc) => new { p, sc })
                .Join(academicCalendars, p => p.p.w.AcademicCalendarId, ac => ac.Id, (p, ac) => new { p, ac })
                .Select(p => new StaffViewModel
                {
                    Id = p.p.p.w.Id,
                    FirstName = p.p.p.st.FirstName,
                    LastName = p.p.p.st.LastName,
                    School = p.p.sc.Name,
                    AcademicCalendar = p.ac.AcademicQuarter + " " + p.ac.AcademicYear,
                    JobTitle = p.p.p.st.JobTitle.Title,
                    Mobile = p.p.p.st.Mobile,
                    Phone = p.p.p.st.Phone,
                    NationalCode = p.p.p.st.NationalCode,
                    BirthDate = p.p.p.st.BirthDate.ToPersianDate(),
                    HiringDate = p.p.p.st.HiringDate.ToPersianDate(),
                    Bio = p.p.p.st.Bio,
                    Email = p.p.p.st.Email,
                    Age = DateTime.Now.Subtract(p.p.p.st.BirthDate).ToPersianString()
                }).FirstOrDefault()));
            
        }

        public Task<Response<StaffViewModel>> Handle(GetAllDataByNid request, CancellationToken cancellationToken)
        {
            var staffs = _staffRepository.GetAll();
            var workedFors = _workedForRepository.GetAll();
            var schools = _schoolRepository.GetAll();
            var academicCalendars = _academicCalendarRepository.GetAll();
            return Task.FromResult(new Response<StaffViewModel>(
                staffs.Where(p => p.NationalCode == request.NId)
                .Join(workedFors, st => st.Id, w => w.StaffId, (st, w) => new { st, w })
                .Join(schools, p => p.w.SchoolId, sc => sc.Id, (p, sc) => new { p, sc })
                .Join(academicCalendars, p => p.p.w.AcademicCalendarId, ac => ac.Id, (p, ac) => new { p, ac })
                .OrderByDescending(p => p.p.p.w.Id)
                .Select(p => new StaffViewModel
                {
                    Id = p.p.p.w.Id,
                    FirstName = p.p.p.st.FirstName,
                    LastName = p.p.p.st.LastName,
                    School = p.p.sc.Name,
                    AcademicCalendar = p.ac.AcademicQuarter + " " + p.ac.AcademicYear,
                    JobTitle = p.p.p.st.JobTitle.Title,
                    Mobile = p.p.p.st.Mobile,
                    Phone = p.p.p.st.Phone,
                    NationalCode = p.p.p.st.NationalCode,
                    BirthDate = p.p.p.st.BirthDate.ToPersianDate(),
                    HiringDate = p.p.p.st.HiringDate.ToPersianDate(),
                    Bio = p.p.p.st.Bio,
                    Email = p.p.p.st.Email
                }).FirstOrDefault()));
        }
    }
}
