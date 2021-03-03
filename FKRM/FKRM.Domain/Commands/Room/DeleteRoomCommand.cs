using FKRM.Domain.Validation.Room;
using System;

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
