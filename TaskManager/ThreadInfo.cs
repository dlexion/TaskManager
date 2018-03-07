using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class ThreadInfo
    {
        [DisplayName("ID")]
        public String ID { get; set; }

        [DisplayName("Priority")]
        public String PriorityLevel { get; set; }

        [DisplayName("State")]
        public String ThreadState { get; set; }
    }
}
