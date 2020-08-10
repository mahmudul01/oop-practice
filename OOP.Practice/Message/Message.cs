using System;
using System.Collections.Generic;
using System.Text;

namespace MessagingSystem
{
    public class Message
    {
        public string Body{ get; set; }
        public DateTime DeliveredOn{ get; set; }
        public string Receipient { get; set; }
    }
}
