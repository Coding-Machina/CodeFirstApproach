using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MessagingWithCodeFirst.Models.configuarations
{
    public class GroupConfiguarations : EntityTypeConfiguration<ThreadUsersMap>
    {
        public GroupConfiguarations()
        {
            this.ToTable("ThreadUsersMap");
            this.HasKey<int>(s => s.ThreadUsersMapId);

            this.HasRequired<User>(s => s.User)
          .WithMany(g => g.Mapping)
          .HasForeignKey<int>(s => s.UserId);

            this.HasRequired<Thread>(s => s.Thread)
           .WithMany(g => g.Mapping)
           .HasForeignKey<int>(s => s.ThreadId);
        }
    }
}