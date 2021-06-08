using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Commands.Notification;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;

namespace FKRM.Application.Services
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public NotificationService(INotificationRepository notificationRepository, IMediatorHandler bus, IMapper mapper)
        {
            _notificationRepository = notificationRepository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public IEnumerable<NotificationViewModel> GetAll()
        {
            return _notificationRepository.GetAll().ProjectTo<NotificationViewModel>(_autoMapper.ConfigurationProvider);
        }

        public NotificationViewModel GetById(Guid id)
        {
            return _autoMapper.Map<NotificationViewModel>(_notificationRepository.GetById(id));

        }

        public IEnumerable<NotificationViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _notificationRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<NotificationViewModel>(_autoMapper.ConfigurationProvider);
        }

        public Task<Response<int>> Register(NotificationViewModel notificationViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateNotificationCommand>(notificationViewModel));

        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteNotificationCommand(id));
        }

        public Task<Response<int>> Update(NotificationViewModel notificationViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateNotificationCommand>(notificationViewModel));

        }
        public IEnumerable<NotificationViewModel> GetAllData()
        {
            return _notificationRepository.GetAllData().ProjectTo<NotificationViewModel>(_autoMapper.ConfigurationProvider);
        }

        public IEnumerable<NotificationViewModel> GetLatest()
        {
            return _notificationRepository.GetLatest().ProjectTo<NotificationViewModel>(_autoMapper.ConfigurationProvider);

        }
    }
}
