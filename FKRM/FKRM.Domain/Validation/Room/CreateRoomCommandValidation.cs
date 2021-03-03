using FKRM.Domain.Commands.Room;

namespace FKRM.Domain.Validation.Room
{
    public class CreateRoomCommandValidation : RoomValidation<CreateRoomCommand>
    {
        public CreateRoomCommandValidation()
        {
            ValidateName();
        }
    }
}
