using FKRM.Domain.Validation.School;
using System;

namespace FKRM.Domain.Commands.School
{
    public class UpdateSchoolCommand : SchoolCommand
    {
        public UpdateSchoolCommand(Guid id, string name, string code, Guid genderId, Guid featureId, Guid unitTypeId, Guid oUTypeId)
        {
            ID = id;
            Name = name;
            Code = code;
            GenderId = genderId;
            FeatureId = featureId;
            UnitTypeId = unitTypeId;
            OUTypeId = oUTypeId;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateSchoolCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
