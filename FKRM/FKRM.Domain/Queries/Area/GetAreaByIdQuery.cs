using FKRM.Domain.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Queries.Area
{
    public class GetAreaByIdQuery : IRequest<Response<Entities.Area>>
    {
        public Guid Id { get; set; }
        public GetAreaByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
