using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    public class SchoolViewModel : BaseViewModel
    {
        [DisplayName("منطقه")]
        public string District { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام")]
        public string Name { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("کد مدرسه")]
        public string Code { get; set; }
        [DisplayName("جنسیت")]
        public string Gender { get; set; }
        [DisplayName("واحد سازمانی")]
        public string OUType { get; set; }
        [DisplayName("ویژگی مدرسه")]
        public string Feature { get; set; }
        [DisplayName("نوع اداره")]
        public string UnitType { get; set; }
        [DisplayName("مدرسه اصلی")]
        public string ParentSchool { get; set; }
        public Guid GenderId { get; set; }
        public Guid UnitTypeId { get; set; }
        public Guid FeatureId { get; set; }
        public Guid OUTypeId { get; set; }
        public Guid DistrictId { get; set; }
        public bool HasParentSchool { get; set; }
        public Guid ParentSchoolId { get; set; }
        public SelectList Genders { get; set; }
        public SelectList OUTypes { get; set; }
        public SelectList Features { get; set; }
        public SelectList UnitTypes { get; set; }
        public SelectList Districts { get; set; }
        public SelectList ParentSchools { get; set; }

    }
}
