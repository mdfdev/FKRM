﻿using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// زمینه رشته
    /// </summary>
    public class Area : BaseEntity
    {
        public string Name { get; set; }
        public Branch Branch { get; set; }

        public ICollection<Group> Groups { get; set; }
        
    }
}
