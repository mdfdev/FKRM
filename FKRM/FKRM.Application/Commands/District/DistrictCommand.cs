using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.District
{
    public abstract class DistrictCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }
    }
}
