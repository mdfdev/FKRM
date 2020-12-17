using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class GradeViewModel
    {
        public IEnumerable<Grade> grades{ get; set; }
    }
}
