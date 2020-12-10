﻿using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    public class UnitType : IEntity
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public List<School> Schools { get; set; }

    }
}
