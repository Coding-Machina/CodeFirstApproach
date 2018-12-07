using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MessagingWithCodeFirst.Models.configuarations
{
    public class MessageConfiguarations : EntityTypeConfiguration<Messages>
    {
        public MessageConfiguarations()
        {
            this.ToTable("Messages");
            this.HasKey<int>(s => s.MessagesId);

            this.HasRequired<User>(s => s.Creator)
          .WithMany(g => g.Messages)
          .HasForeignKey<int>(s => s.CreatorId);

            this.HasRequired<Thread>(s => s.Thread)
           .WithMany(g => g.Messages)
           .HasForeignKey<int>(s => s.ThreadId);
        }
    }
}