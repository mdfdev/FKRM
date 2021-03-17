using FKRM.Domain.Commands.JobTitle;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class JobTitleCommandHandler : CommandHandler,
        IRequestHandler<CreateJobTitleCommand, Response<int>>,
        IRequestHandler<DeleteJobTitleCommand, Response<int>>,
        IRequestHandler<UpdateJobTitleCommand, Response<int>>
    {
        private readonly IJobTitleRepository _jobTitleRepository;
        public JobTitleCommandHandler(IJobTitleRepository jobTitleRepository)
        {
            _jobTitleRepository = jobTitleRepository;
        }
        public Task<Response<int>> Handle(CreateJobTitleCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var Schedule = new Entities.JobTitle()
            {
                Title = request.Title,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _jobTitleRepository.Add(Schedule);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteJobTitleCommand request, CancellationToken cancellationToken)
        {
            var entity = _jobTitleRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _jobTitleRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateJobTitleCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _jobTitleRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Title = request.Title;
                entity.ModifiedDate = request.ModifiedDate;
                _jobTitleRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
