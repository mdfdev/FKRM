using FKRM.Domain.Commands.Course;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class CourseCommandHandler : CommandHandler,
        IRequestHandler<CreateCourseCommand, Response<int>>,
        IRequestHandler<DeleteCourseCommand, Response<int>>,
        IRequestHandler<UpdateCourseCommand, Response<int>>
    {
        private readonly ICourseRepository _courseRepository;
        public CourseCommandHandler(ICourseRepository CourseRepository)
        {
            _courseRepository = CourseRepository;
        }
        public Task<Response<int>> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var Course = new Entities.Course()
            {
                Code = request.Code,
                Name = request.Name,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate,
                Credits = request.Credits,
                PassMark = request.PassMark
            };
            _courseRepository.Add(Course);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
        {
            var entity = _courseRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _courseRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _courseRepository.GetById(request.ID);
            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.ModifiedDate = request.ModifiedDate;
                _courseRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
