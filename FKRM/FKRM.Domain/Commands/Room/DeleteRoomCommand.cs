using FKRM.Domain.Validation.Room;
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
        public override bool IsValid()
        {
            ValidationResult = new DeleteRoomCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
