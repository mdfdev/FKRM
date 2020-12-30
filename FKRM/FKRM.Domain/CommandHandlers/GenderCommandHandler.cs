using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class GenderCommandHandler : IRequestHandler<CreateGenderCommand, bool>
    {
        private readonly IGenderRepository _genderRepository;
        public GenderCommandHandler(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }

        public Task<bool> Handle(CreateGenderCommand request, CancellationToken cancellationToken)
        {
            var gender = new Gender()
            {
                Name = request.Name
            };
            _genderRepository.Add(gender);
            return Task.FromResult(true);
        }
    }
}
