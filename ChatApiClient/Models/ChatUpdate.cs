using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ChatApiClient.Models {
    public class ChatUpdate {
        public Old old { get; set; }
        [JsonPropertyName("new")]
        public New novo { get; set; }
    }

}
