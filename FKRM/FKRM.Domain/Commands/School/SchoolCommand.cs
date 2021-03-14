using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Domain.Commands.School
{
    public abstract class SchoolCommand : Command
    {
        public string Name { get; protected set; }
        public Guid ID { get; protected set; }
        public string Code { get; protected set; }
        public Guid GenderId { get; protected set; }
        public Guid FeatureId { get; protected set; }
        public Guid OUTypeId { get; protected set; }
        public Guid UnitTypeId { get; protected set; }

    }
}
