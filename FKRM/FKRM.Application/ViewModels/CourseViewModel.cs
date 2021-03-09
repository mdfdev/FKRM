using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    public class CourseViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("کد درس")]
        public string Code { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام درس")]
        public string Name { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("تعداد واحد")]
        public int Credits { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("حد نصاب قبولی")]
        public int PassMark { get; set; }
        [DisplayName("شاخه")]
        public string Branch { get; set; }
        [DisplayName("زمینه")]
        public string Area { get; set; }
        [DisplayName("گروه")]
        public string Group { get; set; }
        [DisplayName("رشته")]
        public string Major { get; set; }
        [DisplayName("پایه")]
        public string Grade { get; set; }
        [DisplayName("مدل نمره دهی")]
        public string MarkingType { get; set; }
        public Guid BranchId { get; set; }
        public Guid AreaId { get; set; }
        public Guid GroupId { get; set; }
        public Guid MajorId { get; set; }
        public Guid GradeId { get; set; }
        public Guid MarkingTypeId { get; set; }
        public SelectList Branches { get; set; }
        public SelectList Areas { get; set; }
        public SelectList Groups { get; set; }
        public SelectList Majors { get; set; }
        public SelectList Grades { get; set; }
        public SelectList MarkingTypes { get; set; }
    }
}
