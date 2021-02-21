using FKRM.Domain.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Domain.Queries.Area
{
    public class GetAllAreaQuery : IRequest<Response<IQueryable<Entities.Area>>>
    {
        public GetAllAreaQuery()
        {

        }
    }
}
