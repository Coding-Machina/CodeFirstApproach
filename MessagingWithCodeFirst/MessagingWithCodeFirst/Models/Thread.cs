using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessagingWithCodeFirst.Models
{
    public class Thread
    {
        public int ThreadId { get; set; }
        public string CreatedDate { get; set; }

        public ICollection<ThreadUsersMap> Mapping { get; set; }
        public ICollection<Messages> Messages { get; set; }
    }
}