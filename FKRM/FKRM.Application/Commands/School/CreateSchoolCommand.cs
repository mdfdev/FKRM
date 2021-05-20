using FKRM.Application.Validation.School;
using System;

namespace FKRM.Application.Commands.School
{
    public class CreateSchoolCommand : SchoolCommand
    {
        public CreateSchoolCommand(string name,
            string code,
            Guid genderId,
            Guid featureId,
            Guid unitTypeId,
            Guid oUTypeId,
            Guid districtId,
            Guid parentSchoolId,
            bool hasParentSchool,
            Guid branchId)
        {
            Name = name;
            Code = code;
            GenderId = genderId;
            FeatureId = featureId;
            UnitTypeId = unitTypeId;
            OUTypeId = oUTypeId;
            DistrictId = districtId;
            ParentSchoolId = parentSchoolId;
            HasParentSchool = hasParentSchool;
            BranchId = branchId;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateSchoolCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
