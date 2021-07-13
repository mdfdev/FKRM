using FKRM.Application.Queries.JobTitle;
using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Application.QueryHandlers
{
    public class JobTitleQueryHandler : IRequestHandler<GetJobStatistics, Response<IEnumerable<ChartViewModel>>>
    {
        private readonly IStaffRepository _staffRepository;
        private readonly IJobTitleRepository _jobTitleRepository;
        public JobTitleQueryHandler(IStaffRepository staffRepository,IJobTitleRepository jobTitleRepository)
        {
            _staffRepository = staffRepository;
            _jobTitleRepository = jobTitleRepository;
        }
        public Task<Response<IEnumerable<ChartViewModel>>> Handle(GetJobStatistics request, CancellationToken cancellationToken)
        {
            var staffs = _staffRepository.GetAll();
            var jobTitles = _jobTitleRepository.GetAll();
            return Task.FromResult(new Response<IEnumerable<ChartViewModel>>(jobTitles
               .Join(staffs, jb => jb.Id, st => st.JobTitleId, (jb, st) => new { jb,st })
               .AsEnumerable()
               .GroupBy(n => new { n.jb })
               .Select(p => new ChartViewModel
               {
                   name = p.Key.jb.Title,
                   value = p.Count()
               })));
        }
    }
}
