using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Validation.Room;
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
        public override bool IsValid()
        {
            ValidationResult = new CreateRoomCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
