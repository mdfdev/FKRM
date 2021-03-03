using FKRM.Domain.Commands.Room;

namespace FKRM.Domain.Validation.Room
{
    public class DeleteRoomCommandValidation : RoomValidation<DeleteRoomCommand>
    {
        public DeleteRoomCommandValidation()
        {
            ValidateId();
        }
    }
}
