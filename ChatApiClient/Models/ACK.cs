using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApiClient.Models {
    public class ACK {
        public string id { get; set; }
        public string queueNumber { get; set; }
        public string chatId { get; set; }
        public string status { get; set; }
    }
}
