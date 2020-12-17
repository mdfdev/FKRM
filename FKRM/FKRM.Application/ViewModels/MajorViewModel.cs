using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class MajorViewModel
    {
        public IEnumerable<Major> majors { get; set; }
    }
}
