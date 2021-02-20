﻿using FKRM.Domain.Commands.Area;
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
    public class AreaCommandHandler : CommandHandler,
        IRequestHandler<CreateAreaCommand, Response<int>>,
        IRequestHandler<DeleteAreaCommand, Response<int>>,
        IRequestHandler<UpdateAreaCommand, Response<int>>
    {
        private readonly IAreaRepository _areaRepository;
        public AreaCommandHandler(IAreaRepository areaRepository, IMediatorHandler bus) : base(bus)
        {
            _areaRepository = areaRepository;
        }
        public Task<Response<int>> Handle(CreateAreaCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.FromResult(new Response<int>(400));
            }
            var area = new Entities.Area()
            {
                Name = request.Name
            };
            _areaRepository.Add(area);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteAreaCommand request, CancellationToken cancellationToken)
        {
            var entity = _areaRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _areaRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateAreaCommand request, CancellationToken cancellationToken)
        {
            var entity = _areaRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                _areaRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}