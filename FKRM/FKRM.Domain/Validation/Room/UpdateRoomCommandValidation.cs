using FKRM.Domain.Commands.Room;

namespace FKRM.Domain.Validation.Room
{
    public class UpdateRoomCommandValidation : RoomValidation<UpdateRoomCommand>
    {
        public UpdateRoomCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
