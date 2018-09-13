using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQServerStatus.Classes
{
    public class Triggers
    {
        public string Server { get; set; }
        public string StatusFrom { get; set; }
        public string StatusTo { get; set; }
        public bool AlertRepeating { get; set; }
    }
}
