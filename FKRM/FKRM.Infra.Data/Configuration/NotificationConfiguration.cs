using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Configuration
{
    class NotificationConfiguration : IEntityTypeConfiguration<Notification>

    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder
               .HasKey(b => b.Id);

            builder
                .HasOne(x => x.ParentNotification)
                .WithMany()
                .HasForeignKey(x => x.ParentNotificationId);

          
        }
    }
}
