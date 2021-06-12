using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class NotificationRepository : Repository<Notification>, INotificationRepository
    {
        public NotificationRepository(SchoolDBContext context) : base(context)
        {
        }

        public IQueryable<Notification> GetAllData()
        {
            return DbSet.Select(p => new Notification()
            {
                Id = p.Id,
                Subject = p.Subject,
                Body = p.Body,
                ParentNotification = p.ParentNotification
            });
        }

        public IQueryable<Notification> GetLatest()
        {
            return DbSet.OrderByDescending(p => p.AddedDate).Take(3).Select(p => new Notification()
            {
                Id = p.Id,
                Subject = p.Subject,
                Body = p.Body,
                AddedDate = p.AddedDate,
                ParentNotification = p.ParentNotification
            });
        }
    }
}
