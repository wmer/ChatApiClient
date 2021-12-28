using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApiClient.Models {
    public class Messages {
        public List<Message> messages { get; set; }
        public List<ACK> ack { get; set; }
        public List<ChatUpdate> chatUpdate { get; set; }
        public int lastMessageNumber { get; set; }
    }
}
