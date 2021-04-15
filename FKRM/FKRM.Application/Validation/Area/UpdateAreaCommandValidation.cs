using FKRM.Application.Commands.Area;

namespace FKRM.Application.Validation.Area
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
