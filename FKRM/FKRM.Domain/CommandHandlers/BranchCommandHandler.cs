using FKRM.Domain.Commands.Branch;
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
    class BranchCommandHandler : CommandHandler,
        IRequestHandler<CreateBranchCommand, Response<int>>,
        IRequestHandler<DeleteBranchCommand, Response<int>>,
        IRequestHandler<UpdateBranchCommand, Response<int>>
    {
        private readonly IBranchRepository _branchRepository;
        public BranchCommandHandler(IBranchRepository BranchRepository, IMediatorHandler bus) : base(bus)
        {
            _branchRepository = BranchRepository;
        }
        public Task<Response<int>> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.FromResult(new Response<int>(400));
            }
            var Branch = new Entities.Branch()
            {
                Name = request.Name
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
            var entity = _branchRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                _branchRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
