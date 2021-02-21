using FKRM.Domain.Commands.Course;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class CourseCommandHandler : 
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
                return Task.FromResult(new Response<int>(400));
            }
            var Course = new Entities.Course()
            {
                Name = request.Name
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
            var entity = _courseRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                _courseRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
