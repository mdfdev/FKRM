using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands
{
    public class CreateGenderCommand:GenderCommand
    {
        public CreateGenderCommand(string name)
        {
            Name = name;
        }
    }
}
