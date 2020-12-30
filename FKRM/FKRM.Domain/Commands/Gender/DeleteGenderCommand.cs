using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Gender
{
    public class DeleteGenderCommand : GenderCommand
    {
        public DeleteGenderCommand(int id)
        {
            ID = id;
        }
    }
}
