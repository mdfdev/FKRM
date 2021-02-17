using FKRM.Domain.Commands.MarkingType;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.MarkingType
{
    public class CreateMarkingTypeCommandValidation:MarkingTypeValidation<CreateMarkingTypeCommand>
    {
        public CreateMarkingTypeCommandValidation()
        {
            ValidateName();
        }
    }
}
