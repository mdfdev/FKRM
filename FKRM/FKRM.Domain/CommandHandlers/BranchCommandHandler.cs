using FKRM.Domain.Commands.Branch;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class BranchCommandHandler : CommandHandler,
        IRequestHandler<CreateBranchCommand, Response<int>>,
        IRequestHandler<DeleteBranchCommand, Response<int>>,
        IRequestHandler<UpdateBranchCommand, Response<int>>
    {
        private readonly IBranchRepository _branchRepository;
        public BranchCommandHandler(IBranchRepository BranchRepository)
        {
            _branchRepository = BranchRepository;
        }
        public Task<Response<int>> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var Branch = new Entities.Branch()
            {
                Name = request.Name,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _branchRepository.Add(Branch);
            return Task.FromResult(new Response<int>(200));
        }



        public Task<Response<int>> Handle(DeleteBranchCommand request, CancellationToken cancellationToken)
        {
            var entity = _branchRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _branchRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _branchRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.ModifiedDate = request.ModifiedDate;
                _branchRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
