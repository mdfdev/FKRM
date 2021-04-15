using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Domain.Queries.Staff
{
    public class GetStaffAllData: IRequest<Response<IEnumerable<StaffViewModel>>>
    {
        public Guid Id { get; set; }
        public GetStaffAllData(Guid id)
        {
            Id = id;
        }
    }
}
