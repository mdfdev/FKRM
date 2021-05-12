using FKRM.Application.Commands.AcademicMajor;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Application.CommandHandlers
{
    public class AcademicMajorCommandHandler : CommandHandler,
        IRequestHandler<CreateAcademicMajorCommand, Response<int>>,
        IRequestHandler<DeleteAcademicMajorCommand, Response<int>>,
        IRequestHandler<UpdateAcademicMajorCommand, Response<int>>
    {
        private readonly IAcademicMajorRepository _academicMajorRepository;

        public AcademicMajorCommandHandler(IAcademicMajorRepository academicMajorRepository)
        {
            _academicMajorRepository = academicMajorRepository;
        }

        public Task<Response<int>> Handle(UpdateAcademicMajorCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _academicMajorRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.ModifiedDate = request.ModifiedDate;
                _academicMajorRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }

        public Task<Response<int>> Handle(DeleteAcademicMajorCommand request, CancellationToken cancellationToken)
        {
            var entity = _academicMajorRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            _academicMajorRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(CreateAcademicMajorCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var academicMajor = new Domain.Entities.AcademicMajor()
            {
                Name = request.Name,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _academicMajorRepository.Add(academicMajor);
            return Task.FromResult(new Response<int>(200));
        }
    }
}
