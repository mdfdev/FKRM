using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Domain.Commands.Course
{
    public abstract class CourseCommand : Command
    {
        public Guid ID { get; protected set; }
        public string Name { get; protected set; }
        public string Code { get; protected set; }
        public int Credits { get; protected set; }
        public int PassMark { get; protected set; }
    }
}
