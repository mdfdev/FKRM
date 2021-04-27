using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Queries.Major
{
    public class GetMajorStatistics : IRequest<Response<IEnumerable<ChartViewModel>>>
    {

    }
}
