using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Room
{
    public class DeleteRoomCommand : RoomCommand
    {
        public DeleteRoomCommand(Guid id)
        {
            ID = id;
        }
    }
}
