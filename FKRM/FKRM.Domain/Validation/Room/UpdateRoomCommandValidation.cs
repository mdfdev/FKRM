using FKRM.Domain.Commands.Room;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Room
{
    public class UpdateRoomCommandValidation:RoomValidation<UpdateRoomCommand>
    {
        public UpdateRoomCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
