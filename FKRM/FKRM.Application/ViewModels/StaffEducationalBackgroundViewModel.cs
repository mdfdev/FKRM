using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.ViewModels
{
    /// <summary>
    /// سابقه آکادمیک
    /// </summary>
    public class StaffEducationalBackgroundViewModel : BaseViewModel
    {
        public string AcademicDegree { get; set; }
        public string AcademicMajor { get; set; }


        public Guid AcademicDegreeId { get; set; }
        public SelectList AcademicDegrees { get; set; }

        public Guid AcademicMajorId { get; set; }
        public SelectList AcademicMajors { get; set; }
    }
}
