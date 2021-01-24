using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Area
{
    public class UpdateAreaCommand : AreaCommand
    {
        public UpdateAreaCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
