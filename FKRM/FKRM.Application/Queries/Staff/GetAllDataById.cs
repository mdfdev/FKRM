using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Queries.Staff
{
   public class GetAllDataById : IRequest<Response<StaffViewModel>>
    {
        public Guid Id { get; set; }
        public GetAllDataById(Guid id)
        {
            Id = id;
        }
    }
}
