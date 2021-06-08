using FKRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Infra.Data.Configuration
{
    class NotificationRecipientConfiguration : IEntityTypeConfiguration<NotificationRecipient>
    {
        public void Configure(EntityTypeBuilder<NotificationRecipient> builder)
        {

            builder
                .HasKey(b => b.Id);

            builder
               .HasOne(s => s.Notification)
               .WithMany(g => g.NotificationRecipients)
               .HasForeignKey(s => s.NotificationId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
