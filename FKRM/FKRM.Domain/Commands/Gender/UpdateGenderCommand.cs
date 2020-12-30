using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Gender
{
    class UpdateGenderCommand:GenderCommand
    {
        public UpdateGenderCommand(int id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
