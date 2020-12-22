using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// رشته
    /// </summary>
    public class Major : IEntity
    {
        public int Id { get ; set ; }
        /// <summary>
        /// نام رشته
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// کد رایانه ای
        /// </summary>
        public string ComputerCode { get; set; }
        /// <summary>
        /// تعداد واحد الزامی
        /// </summary>
        public int RequiredCredit { get; set; }
        /// <summary>
        /// تعداد واحد اختیاری یا انتخابی
        /// </summary>
        public int OptionalElectiveCredit { get; set; }
        /// <summary>
        /// تعداد واحد فارغ التحصیلی
        /// </summary>
        public int GraduationCredits { get; set; }
        public Group Group { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
