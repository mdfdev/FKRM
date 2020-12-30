using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.MarkingType
{
    public class CreateMarkingTypeCommand: MarkingTypeCommand
    {
        public CreateMarkingTypeCommand(string name)
        {
            Name = name;
        }
    }
}
