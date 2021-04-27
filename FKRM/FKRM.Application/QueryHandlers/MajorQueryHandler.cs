using FKRM.Application.Queries.Major;
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
    public class MajorQueryHandler : IRequestHandler<GetMajorStatistics, Response<IEnumerable<ChartViewModel>>>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IAreaRepository _areaRepository;
        private readonly IGroupRepository _groupRepository;
        private readonly IMajorRepository _majorRepository;
        public MajorQueryHandler(IBranchRepository branchRepository,IAreaRepository areaRepository,IGroupRepository groupRepository,IMajorRepository majorRepository)
        {
            _branchRepository = branchRepository;
            _areaRepository = areaRepository;
            _groupRepository = groupRepository;
            _majorRepository = majorRepository;
        }
        public Task<Response<IEnumerable<ChartViewModel>>> Handle(GetMajorStatistics request, CancellationToken cancellationToken)
        {
            var branches = _branchRepository.GetAll();
            var areas = _areaRepository.GetAll();
            var groups = _groupRepository.GetAll();
            var majors = _majorRepository.GetAll();
            return Task.FromResult(new Response<IEnumerable<ChartViewModel>>(branches
               .Join(areas, br => br.Id, ar => ar.BranchId, (br, ar) => new { br, ar })
               .Join(groups, ar => ar.ar.Id, gr => gr.AreaId, (ar, gr) => new { ar, gr })
               .Join(majors, ar => ar.gr.Id, mr => mr.GroupId, (ar, mr) => new { ar, mr })
               .AsEnumerable()
               .GroupBy(n => new { n.ar.ar.br })
               .Select(p => new ChartViewModel
               {
                   name = p.Key.br.Name,
                   value = p.Count()
               })));

        }
    }
}
