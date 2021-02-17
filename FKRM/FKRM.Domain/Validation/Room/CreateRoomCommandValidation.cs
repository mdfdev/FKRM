using FKRM.Domain.Commands.Room;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Room
{
    public class CreateRoomCommandValidation:RoomValidation<CreateRoomCommand>
    {
        public CreateRoomCommandValidation()
        {
            ValidateName();
        }
    }
}
