using FKRM.Domain.Commands.Area;

namespace FKRM.Domain.Validation.Area
{
    public class UpdateAreaCommandValidation : AreaValidation<UpdateAreaCommand>
    {
        public UpdateAreaCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
