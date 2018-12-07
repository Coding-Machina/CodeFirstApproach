using MessagingWithCodeFirst.Models.configuarations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MessagingWithCodeFirst.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("ChatApp")
        {
               
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Thread> Thread { get; set; }
        public DbSet<ThreadUsersMap> Mapping { get; set; }
        public DbSet<Messages> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguarations());
            modelBuilder.Configurations.Add(new ThreadConfiguarations());
            modelBuilder.Configurations.Add(new GroupConfiguarations());
            modelBuilder.Configurations.Add(new MessageConfiguarations());
        }
    }
}