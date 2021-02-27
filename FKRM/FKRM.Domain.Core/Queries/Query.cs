using FKRM.Domain.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Core.Queries
{
    public abstract class Query<T> : IRequest<Response<T>>
    {

    }
}
