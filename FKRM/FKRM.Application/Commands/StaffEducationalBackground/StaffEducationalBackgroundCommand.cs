using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.StaffEducationalBackground
{
    public abstract class StaffEducationalBackgroundCommand : Command
    {
        public Guid StaffId { get; protected set; }
        public Guid AcademicDegreeId { get; protected set; }
        public Guid AcademicMajorId { get; protected set; }
    }
}
