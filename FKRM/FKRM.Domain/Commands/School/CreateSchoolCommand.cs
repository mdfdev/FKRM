using FKRM.Domain.Validation.School;
using System;

namespace FKRM.Domain.Commands.School
{
    public class CreateSchoolCommand : SchoolCommand
    {
        public CreateSchoolCommand(string name,string code,Guid genderId,Guid featureId,Guid unitTypeId,Guid oUTypeId)
        {
            Name = name;
            Code = code;
            GenderId = genderId;
            FeatureId = featureId;
            UnitTypeId = unitTypeId;
            OUTypeId = oUTypeId;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateSchoolCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
