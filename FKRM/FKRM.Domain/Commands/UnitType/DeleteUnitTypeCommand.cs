using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.UnitType
{
    public class DeleteUnitTypeCommand : UnitTypeCommand
    {
        public DeleteUnitTypeCommand(Guid id)
        {
            ID = id;
        }
    }
}
