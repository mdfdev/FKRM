using FKRM.Domain.Commands.Schedule;

namespace FKRM.Domain.Validation.Schedule
{
    public class CreateScheduleCommandValidation : ScheduleValidation<CreateScheduleCommand>
    {
        public CreateScheduleCommandValidation()
        {
            ValidateName();
        }
    }
}
