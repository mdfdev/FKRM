﻿using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Course
{
    public abstract class CourseCommand:Command
    {
        public string Name { get; protected set; }
    }
}
