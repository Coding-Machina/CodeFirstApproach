using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessagingWithCodeFirst.Models
{
    public class Messages
    {
        public int MessagesId { get; set; }
        public string MeassageContent { get; set; }
        public int ThreadId { get; set; }
        public int CreatorId  { get; set; }

        public Thread Thread { get; set; }
        public User Creator { get; set; }
    }
}