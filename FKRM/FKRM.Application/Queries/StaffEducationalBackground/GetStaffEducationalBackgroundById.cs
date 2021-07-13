using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Queries.StaffEducationalBackground
{
    public class GetStaffEducationalBackgroundById : IRequest<Response<IEnumerable<StaffEducationalBackgroundViewModel>>>
    {
        public Guid Id { get; set; }
        public GetStaffEducationalBackgroundById(Guid id)
        {
            Id = id;
        }
    }
}
