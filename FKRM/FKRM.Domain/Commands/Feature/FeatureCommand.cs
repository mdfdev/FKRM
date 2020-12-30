using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Feature
{
    public abstract class FeatureCommand:Command
    {
        public string Name { get; protected set; }
    }
}
