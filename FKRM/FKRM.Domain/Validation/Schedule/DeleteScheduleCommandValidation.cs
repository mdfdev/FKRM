using FKRM.Domain.Commands.Schedule;

namespace FKRM.Domain.Validation.Schedule
{
    public class DeleteScheduleCommandValidation : ScheduleValidation<DeleteScheduleCommand>
    {
        public DeleteScheduleCommandValidation()
        {
            ValidateId();
        }
    }
}
