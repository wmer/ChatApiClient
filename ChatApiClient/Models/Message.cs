using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApiClient.Models {
    public class Message {
        public string id { get; set; }
        public string chatId { get; set; }
        public string author { get; set; }
        public string senderName { get; set; }
        public string phone { get; set; }
        public string body { get; set; }
        public string filename { get; set; }
        public string caption { get; set; }
        public string type { get; set; }
        public bool fromMe { get; set; }
        public int time { get; set; }
        public int messageNumber { get; set; }

    }
}
