using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.MarkingType
{
    public class DeleteMarkingTypeCommand : MarkingTypeCommand
    {
        public DeleteMarkingTypeCommand(Guid id)
        {
            ID = id;
        }
    }
}
