using FKRM.Application.Queries.StaffEducationalBackground;
using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Application.QueryHandlers
{
    public class StaffEducationalBackgroundQueryHandler : IRequestHandler<GetStaffEducationalBackgroundById, Response<IEnumerable<StaffEducationalBackgroundViewModel>>>
    {
        private readonly IStaffEducationalBackgroundRepository _staffEducationalBackgroundRepository;
        private readonly IAcademicMajorRepository _academicMajorRepository;
        private readonly IAcademicDegreeRepository _academicDegreeRepository;
        private readonly IStaffRepository _staffRepository;
        public StaffEducationalBackgroundQueryHandler(IStaffEducationalBackgroundRepository staffEducationalBackgroundRepository,
            IAcademicMajorRepository academicMajorRepository,
            IAcademicDegreeRepository academicDegreeRepository,
            IStaffRepository staffRepository)
        {
            _staffEducationalBackgroundRepository = staffEducationalBackgroundRepository;
            _academicMajorRepository = academicMajorRepository;
            _academicDegreeRepository = academicDegreeRepository;
            _staffRepository = staffRepository;
        }

        public Task<Response<IEnumerable<StaffEducationalBackgroundViewModel>>> Handle(GetStaffEducationalBackgroundById request, CancellationToken cancellationToken)
        {
            var staffs = _staffRepository.GetAll();
            var academicDegrees = _academicDegreeRepository.GetAll();
            var academicMajors = _academicMajorRepository.GetAll();
            var staffEducationalBackgrounds = _staffEducationalBackgroundRepository.GetAll();
            return Task.FromResult(new Response<IEnumerable<StaffEducationalBackgroundViewModel>>(
                staffEducationalBackgrounds.Where(p => p.StaffId == request.Id)
                .Join(academicDegrees, st => st.AcademicDegreeId, ad => ad.Id, (st, ad) => new { st, ad })
                .Join(academicMajors, st => st.st.AcademicMajorId, am => am.Id, (st, am) => new { st, am })
                .Select(p => new StaffEducationalBackgroundViewModel
                {
                    Id = p.st.st.Id,
                    AcademicDegree = p.st.ad.Name,
                    AcademicMajor = p.am.Name
                })));
        }
    }
}
