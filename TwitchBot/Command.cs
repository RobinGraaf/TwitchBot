using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot {
    public class Command
    {
        public int Id { get; set; }
        public string CommandText { get; set; }
        public string Response { get; set; }
        public string Description { get; set; }
    }
}
