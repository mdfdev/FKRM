using FKRM.Domain.Validation.Room;
using System;

namespace FKRM.Domain.Commands.Room
{
    public class CreateRoomCommand : RoomCommand
    {
        public CreateRoomCommand(string name,Guid schoolId)
        {
            Name = name;
            SchoolId = schoolId;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateRoomCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
