using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Queries.Staff
{
   public class GetAllDataByNid : IRequest<Response<StaffViewModel>>
    {
        public string NId { get; set; }
        public GetAllDataByNid(string nid)
        {
            NId = nid;
        }
    }
}
