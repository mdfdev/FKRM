using FKRM.Application.Commands.Notification;
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
    public class NotificationCommandHandler : CommandHandler,
        IRequestHandler<CreateNotificationCommand, Response<int>>,
        IRequestHandler<DeleteNotificationCommand, Response<int>>,
        IRequestHandler<UpdateNotificationCommand, Response<int>>
    {
        private readonly INotificationRepository _notificationRepository;
        public NotificationCommandHandler(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }
        public Task<Response<int>> Handle(UpdateNotificationCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _notificationRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Body = request.Body;
                entity.Subject = request.Subject;
                entity.ModifiedDate = request.ModifiedDate;
                _notificationRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }

        public Task<Response<int>> Handle(DeleteNotificationCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = _notificationRepository.GetById(request.ID);

                if (entity == null)
                {
                    throw new ApiException($"گزینه مورد نظر یافت نشد.");
                }

                _notificationRepository.Remove(request.ID);
                return Task.FromResult(new Response<int>(200));
            }
            catch 
            {
                return Task.FromResult(new Response<int>(400, new List<string>() { $"گزینه مورد نظر حذف نشد." }));
            }
        }

        public Task<Response<int>> Handle(CreateNotificationCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var notification = new Domain.Entities.Notification()
            {
                Body=request.Body,
                Subject = request.Subject,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _notificationRepository.Add(notification);
            return Task.FromResult(new Response<int>(200));
        }
    }
}
