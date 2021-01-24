using FKRM.Domain.Core.Wrappers;
using MediatR;
using System;

namespace FKRM.Domain.Queries.Gender
{
    public class GetGenderByIdQuery : IRequest<Response<Entities.Gender>>
    {
        public Guid Id { get; set; }
       
    }
}
