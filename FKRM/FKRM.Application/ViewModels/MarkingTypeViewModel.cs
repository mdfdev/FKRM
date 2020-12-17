using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class MarkingTypeViewModel
    {
        public IEnumerable<MarkingType> markingTypes { get; set; }
    }
}
