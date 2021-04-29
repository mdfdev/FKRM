using FKRM.Application.Commands.District;

namespace FKRM.Application.Validation.District
{
    public class UpdateDistrictCommandValidation : DistrictValidation<UpdateDistrictCommand>
    {
        public UpdateDistrictCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
