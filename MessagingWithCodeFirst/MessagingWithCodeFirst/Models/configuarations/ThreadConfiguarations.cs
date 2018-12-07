using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MessagingWithCodeFirst.Models.configuarations
{
    public class ThreadConfiguarations : EntityTypeConfiguration<Thread>
    {
        public ThreadConfiguarations()
        {
            this.ToTable("Thread");
            this.HasKey<int>(s => s.ThreadId);
        }
    }
}