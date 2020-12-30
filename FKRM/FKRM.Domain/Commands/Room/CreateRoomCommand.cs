using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Room
{
    public class CreateRoomCommand: RoomCommand
    {
        public CreateRoomCommand(string name)
        {
            Name = name;
        }
    }
}
