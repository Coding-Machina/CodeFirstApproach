using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MessagingWithCodeFirst.Models.configuarations
{
    public class UserConfiguarations : EntityTypeConfiguration<User>
    {
        public UserConfiguarations()
        {
            this.ToTable("UsersGroups");
            this.HasKey<int>(s => s.UserId);
        }
    }
}