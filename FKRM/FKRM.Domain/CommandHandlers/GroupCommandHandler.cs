using FKRM.Domain.Commands.Group;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class GroupCommandHandler : CommandHandler,
        IRequestHandler<CreateGroupCommand, Response<int>>,
        IRequestHandler<DeleteGroupCommand, Response<int>>,
        IRequestHandler<UpdateGroupCommand, Response<int>>
    {
        private readonly IGroupRepository _groupRepository;
        public GroupCommandHandler(IGroupRepository GroupRepository)
        {
            _groupRepository = GroupRepository;
        }
        public Task<Response<int>> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var Group = new Entities.Group()
            {
                Name = request.Name,
                AreaId=request.AreaId,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _groupRepository.Add(Group);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = _groupRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _groupRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _groupRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.AreaId = request.AreaId;
                entity.ModifiedDate = request.ModifiedDate;
                _groupRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
