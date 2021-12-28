using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApiClient.Models {
    public class New {
        public string id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public Metadata metadata { get; set; }
        public int last_time { get; set; }
    }
}
