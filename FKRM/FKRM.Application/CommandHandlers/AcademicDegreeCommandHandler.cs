using FKRM.Application.Commands.AcademicDegree;
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
    public class AcademicDegreeCommandHandler : CommandHandler,
        IRequestHandler<CreateAcademicDegreeCommand, Response<int>>,
        IRequestHandler<DeleteAcademicDegreeCommand, Response<int>>,
        IRequestHandler<UpdateAcademicDegreeCommand, Response<int>>
    {
        private readonly IAcademicDegreeRepository _academicDegreeRepository;
        public AcademicDegreeCommandHandler(IAcademicDegreeRepository academicDegreeRepository)
        {
            _academicDegreeRepository = academicDegreeRepository;
        }

        public Task<Response<int>> Handle(UpdateAcademicDegreeCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _academicDegreeRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.ModifiedDate = request.ModifiedDate;
                _academicDegreeRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }

        public Task<Response<int>> Handle(DeleteAcademicDegreeCommand request, CancellationToken cancellationToken)
        {
            var entity = _academicDegreeRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            _academicDegreeRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(CreateAcademicDegreeCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var academicDegree = new Domain.Entities.AcademicDegree()
            {
                Name = request.Name,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _academicDegreeRepository.Add(academicDegree);
            return Task.FromResult(new Response<int>(200));
        }
    }
}
