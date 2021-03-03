using FKRM.Domain.Commands.Enrollment;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class EnrollmentCommandHandler : CommandHandler,
        IRequestHandler<CreateEnrollmentCommand, Response<int>>,
        IRequestHandler<DeleteEnrollmentCommand, Response<int>>,
        IRequestHandler<UpdateEnrollmentCommand, Response<int>>
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        public EnrollmentCommandHandler(IEnrollmentRepository EnrollmentRepository)
        {
            _enrollmentRepository = EnrollmentRepository;
        }
        public Task<Response<int>> Handle(CreateEnrollmentCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var Enrollment = new Entities.Enrollment()
            {
                Capacity = request.Capacity,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _enrollmentRepository.Add(Enrollment);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteEnrollmentCommand request, CancellationToken cancellationToken)
        {
            var entity = _enrollmentRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _enrollmentRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateEnrollmentCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _enrollmentRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Capacity = request.Capacity;
                entity.ModifiedDate = request.ModifiedDate;
                _enrollmentRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
