using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Feature
{
    public class UpdateFeatureCommand : FeatureCommand
    {
        public UpdateFeatureCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
