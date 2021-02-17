using FKRM.Domain.Validation.Room;
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
        public override bool IsValid()
        {
            ValidationResult = new UpdateRoomCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
