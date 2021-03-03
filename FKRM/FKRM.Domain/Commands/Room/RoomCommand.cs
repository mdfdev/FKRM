using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Domain.Commands.Room
{
    public abstract class RoomCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }
    }
}
