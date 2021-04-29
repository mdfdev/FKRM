using FKRM.Application.Validation.School;
using System;

namespace FKRM.Application.Commands.School
{
    public class CreateSchoolCommand : SchoolCommand
    {
        public CreateSchoolCommand(string name,string code,Guid genderId,Guid featureId,Guid unitTypeId,Guid oUTypeId,Guid districtId)
        {
            Name = name;
            Code = code;
            GenderId = genderId;
            FeatureId = featureId;
            UnitTypeId = unitTypeId;
            OUTypeId = oUTypeId;
            DistrictId = districtId;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateSchoolCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
