﻿using FKRM.Domain.Commands.Room;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class RoomCommandHandler : CommandHandler,
        IRequestHandler<CreateRoomCommand, Response<int>>,
        IRequestHandler<DeleteRoomCommand, Response<int>>,
        IRequestHandler<UpdateRoomCommand, Response<int>>
    {
        private readonly IRoomRepository _roomRepository;
        public RoomCommandHandler(IRoomRepository RoomRepository, IMediatorHandler bus) : base(bus)
        {
            _roomRepository = RoomRepository;
        }
        public Task<Response<int>> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.FromResult(new Response<int>(400));
            }
            var Room = new Entities.Room()
            {
                Name = request.Name
            };
            _roomRepository.Add(Room);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
        {
            var entity = _roomRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _roomRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
        {
            var entity = _roomRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                _roomRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
