using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessagingWithCodeFirst.Models
{
    public class ThreadUsersMap
    {
        public int ThreadUsersMapId { get; set; }
        public int ThreadId { get; set; }
        public int UserId { get; set; }

        public Thread Thread { get; set; }
        public User User { get; set; }
    }
}