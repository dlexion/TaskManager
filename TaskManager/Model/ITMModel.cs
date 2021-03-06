﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Model
{
    public interface ITMModel
    {
        List<ProcessInfo> GetProcesses();
        List<ThreadInfo> GetThreads(Process process);
        int GetNumberOfProcesses();
        float GetTotalMemoryUsage();
        int GetNumberOfThreads(Process process);
    }
}
