using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.MarkingType
{
    public class UpdateMarkingTypeCommand : MarkingTypeCommand
    {
        public UpdateMarkingTypeCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
