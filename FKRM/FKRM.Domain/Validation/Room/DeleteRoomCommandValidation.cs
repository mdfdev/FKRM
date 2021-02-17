using FKRM.Domain.Commands.Room;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Room
{
    public class DeleteRoomCommandValidation:RoomValidation<DeleteRoomCommand>
    {
        public DeleteRoomCommandValidation()
        {
            ValidateId();
        }
    }
}
