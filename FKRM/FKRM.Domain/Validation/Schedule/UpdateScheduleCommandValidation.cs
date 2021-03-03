using FKRM.Domain.Commands.Schedule;

namespace FKRM.Domain.Validation.Schedule
{
    public class UpdateScheduleCommandValidation : ScheduleValidation<UpdateScheduleCommand>
    {
        public UpdateScheduleCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
