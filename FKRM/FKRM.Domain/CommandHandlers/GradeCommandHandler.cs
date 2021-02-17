using FKRM.Domain.Commands.Grade;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    class GradeCommandHandler : CommandHandler,
        IRequestHandler<CreateGradeCommand, Response<int>>,
        IRequestHandler<DeleteGradeCommand, Response<int>>,
        IRequestHandler<UpdateGradeCommand, Response<int>>
    {
        private readonly IGradeRepository _gradeRepository;
        public GradeCommandHandler(IGradeRepository GradeRepository, IMediatorHandler bus) : base(bus)
        {
            _gradeRepository = GradeRepository;
        }
        public Task<Response<int>> Handle(CreateGradeCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.FromResult(new Response<int>(400));
            }
            var Grade = new Entities.Grade()
            {
                Name = request.Name
            };
            _gradeRepository.Add(Grade);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteGradeCommand request, CancellationToken cancellationToken)
        {
            var entity = _gradeRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _gradeRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateGradeCommand request, CancellationToken cancellationToken)
        {
            var entity = _gradeRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                _gradeRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
