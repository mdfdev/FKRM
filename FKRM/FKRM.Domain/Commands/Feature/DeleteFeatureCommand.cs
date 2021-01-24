using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Feature
{
    public class DeleteFeatureCommand : FeatureCommand
    {
        public DeleteFeatureCommand(Guid id)
        {
            ID = id;
        }
    }
}
