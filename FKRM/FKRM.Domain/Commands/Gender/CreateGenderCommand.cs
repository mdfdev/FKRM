﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Gender
{
    public class CreateGenderCommand : GenderCommand
    {
        public CreateGenderCommand(string name)
        {
            Name = name;
        }
    }
}