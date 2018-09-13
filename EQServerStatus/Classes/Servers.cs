using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQServerStatus.Classes
{
    public class Servers
    {
        public string serverName { get; set; }
        public int lastUpdated { get; set; }
        public List<ServerDataPoints> serverHistoryData { get; set; }

        public Servers()
        {
            this.serverHistoryData = new List<ServerDataPoints>();
        }
    }
}
