using FKRM.Application.Commands.School;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Application.CommandHandlers
{
    public class SchoolCommandHandler : CommandHandler,
        IRequestHandler<CreateSchoolCommand, Response<int>>,
        IRequestHandler<DeleteSchoolCommand, Response<int>>,
        IRequestHandler<UpdateSchoolCommand, Response<int>>
    {
        private readonly ISchoolRepository _schoolRepository;
        public SchoolCommandHandler(ISchoolRepository SchoolRepository)
        {
            _schoolRepository = SchoolRepository;
        }
        public Task<Response<int>> Handle(CreateSchoolCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var School = new Domain.Entities.School()
            {
                Name = request.Name,
                Code = request.Code,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate,
                GenderId = request.GenderId,
                FeatureId = request.FeatureId,
                UnitTypeId = request.UnitTypeId,
                OUTypeId = request.OUTypeId,
                DistrictId = request.DistrictId,
                SubsidiaryId = request.ParentSchoolId
            };
            _schoolRepository.Add(School);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteSchoolCommand request, CancellationToken cancellationToken)
        {
            var entity = _schoolRepository.GetById(request.ID);
            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            _schoolRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }
        public Task<Response<int>> Handle(UpdateSchoolCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _schoolRepository.GetById(request.ID);
            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.ModifiedDate = request.ModifiedDate;
                entity.GenderId = request.GenderId;
                entity.FeatureId = request.FeatureId;
                entity.UnitTypeId = request.UnitTypeId;
                entity.OUTypeId = request.OUTypeId;
                entity.DistrictId = request.DistrictId;
                entity.SubsidiaryId = request.ParentSchoolId;
                _schoolRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
