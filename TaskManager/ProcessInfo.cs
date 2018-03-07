using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class ProcessInfo
    {
        [DisplayName("Name")]
        public String ProcessName { get; set; }

        [DisplayName("ID")]
        public int ID { get; set; }

        [DisplayName("Owner")]
        public String Owner { get; set; }

        [DisplayName("Priority")]
        public String PriorityClass { get; set; }

        [DisplayName("Memory")]
        public long PrivateMemorySize64 { get; set; }

        [DisplayName("Threads")]
        public int NumberOfThreads { get; set; }
    }
}
