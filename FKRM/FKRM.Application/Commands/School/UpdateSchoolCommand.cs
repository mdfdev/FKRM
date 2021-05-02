using FKRM.Application.Validation.School;
using System;

namespace FKRM.Application.Commands.School
{
    public class UpdateSchoolCommand : SchoolCommand
    {
        public UpdateSchoolCommand(Guid id, string name, string code, Guid genderId, Guid featureId, Guid unitTypeId, Guid oUTypeId, Guid districtId, Guid parentSchoolId)
        {
            ID = id;
            Name = name;
            Code = code;
            GenderId = genderId;
            FeatureId = featureId;
            UnitTypeId = unitTypeId;
            OUTypeId = oUTypeId;
            DistrictId = districtId;
            ParentSchoolId = parentSchoolId;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateSchoolCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
