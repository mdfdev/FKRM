using FKRM.Application.Commands.District;

namespace FKRM.Application.Validation.District
{
    class CreateDistrictCommandValidation : DistrictValidation<CreateDistrictCommand>
    {
        public CreateDistrictCommandValidation()
        {
            ValidateName();
        }
    }
}
