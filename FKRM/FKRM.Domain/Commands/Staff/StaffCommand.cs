using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Domain.Commands.Staff
{
    public abstract class StaffCommand : Command
    {
        public Guid ID { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Phone { get; protected set; }
        public string Mobile { get; protected set; }
        public string NationalCode { get; protected set; }
    }
}
