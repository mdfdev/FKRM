using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.JobTitle
{
    public abstract class JobTitleCommand : Command
    {
        public string Title { get; protected set; }
        public Guid ID { get; set; }
    }
}
