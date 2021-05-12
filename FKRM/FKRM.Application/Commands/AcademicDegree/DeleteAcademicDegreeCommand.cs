using FKRM.Application.Validation.AcademicDegree;
using System;

namespace FKRM.Application.Commands.AcademicDegree
{
    public class DeleteAcademicDegreeCommand : AcademicDegreeCommand
    {
        public DeleteAcademicDegreeCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteAcademicDegreeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
