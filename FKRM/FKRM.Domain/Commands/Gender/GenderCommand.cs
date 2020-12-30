using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Gender
{
    public abstract class GenderCommand:Command
    {
        public int ID { get; protected set; }
        public string Name { get; protected set; }
    }
}
