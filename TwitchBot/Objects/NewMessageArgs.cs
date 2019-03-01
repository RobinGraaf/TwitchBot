using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot.Objects {
    public class NewMessageArgs : EventArgs
    {
        public string Speaker { get; set; }
        public string Message { get; set; }
    }
}
