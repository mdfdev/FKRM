using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Feature
{
    public class CreateFeatureCommand : FeatureCommand
    {
        public CreateFeatureCommand(string name)
        {
            Name = name;
        }
    }
}
