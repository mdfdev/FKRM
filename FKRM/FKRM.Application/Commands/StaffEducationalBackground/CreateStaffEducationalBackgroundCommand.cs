using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.StaffEducationalBackground
{
    public class CreateStaffEducationalBackgroundCommand : StaffEducationalBackgroundCommand
    {
        public CreateStaffEducationalBackgroundCommand(Guid staffId, Guid academicDegreeId, Guid academicMajorId)
        {
            StaffId = staffId;
            AcademicDegreeId = academicDegreeId;
            AcademicMajorId = academicMajorId;
        }
        public override bool IsValid()
        {
            //ValidationResult = new CreateStaffEducationalBackgroundCommandValidation().Validate(this);
            //return ValidationResult.IsValid;
            return true;
        }
    }
}
