using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.Feature
{
    public abstract class FeatureCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }
    }
}
