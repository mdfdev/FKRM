using System;

namespace FKRM.Domain.Commands.Gender
{
    public class UpdateAcademicCalendarCommand:GenderCommand
    {
        public UpdateAcademicCalendarCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
