using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApiClient.Models {
    public class Metadata {
        public object groupInviteLink { get; set; }
        public bool isGroup { get; set; }
        public List<string> participants { get; set; }
        public List<string> admins { get; set; }
        public List<ParticipantsInfo> participantsInfo { get; set; }
    }
}
