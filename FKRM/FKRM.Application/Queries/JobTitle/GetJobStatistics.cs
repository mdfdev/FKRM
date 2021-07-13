using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Queries.JobTitle
{
    public class GetJobStatistics : IRequest<Response<IEnumerable<ChartViewModel>>>
    {

    }
}
