using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Room
{
    public class UpdateRoomCommand : RoomCommand
    {
        public UpdateRoomCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
