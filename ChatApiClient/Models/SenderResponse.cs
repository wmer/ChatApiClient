using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApiClient.Models {
    public class SenderResponse {
        public string id { get; set; }
        public bool sent { get; set; }
        public string message { get; set; }
        public int queueNumber { get; set; }
    }
}
