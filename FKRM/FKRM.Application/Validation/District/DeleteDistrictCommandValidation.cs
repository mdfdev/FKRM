using FKRM.Application.Commands.District;

namespace FKRM.Application.Validation.District
{
    public class DeleteDistrictCommandValidation : DistrictValidation<DeleteDistrictCommand>
    {
        public DeleteDistrictCommandValidation()
        {
            ValidateId();
        }
    }
}
