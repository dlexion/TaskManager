using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Model
{
    class TMModel : ITMModel
    {
        #region DllImport
        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);
        #endregion

        public List<ProcessInfo> GetProcesses()
        {
            List<ProcessInfo> processes = new List<ProcessInfo>();

            foreach (var process in Process.GetProcesses())
            {
                processes.Add(new ProcessInfo()
                {
                    ProcessName = GetProcessName(process),
                    ID = GetID(process),
                    Owner = GetOwner(process),
                    PriorityClass = GetPriority(process),
                    PrivateMemorySize64 = GetUsedMemory(process),
                    NumberOfThreads = GetNumberOfThreads(process)
                });
            }
            return processes;
        }

        public List<ThreadInfo> GetThreads(Process process)
        {
            List<ThreadInfo> threads = new List<ThreadInfo>();

            foreach(ProcessThread thread in process.Threads)
            {
                threads.Add(new ThreadInfo()
                {
                    ID = GetID(thread).ToString(),
                    PriorityLevel = GetPriority(thread),
                    ThreadState = GetState(thread)
                });
            }
            return threads;
        }

        #region Getting information about process
        private String GetProcessName(Process process)
        {
            try
            {
                return process.ProcessName;
            }
            catch
            {
                return "";
            }
        }

        private int GetID(Process process)
        {
            try
            {
                return process.Id;
            }
            catch
            {
                return -1;
            }
        }

        private String GetOwner(Process process)
        {
            IntPtr processHandle = IntPtr.Zero;
            try
            {
                OpenProcessToken(process.Handle, 8, out processHandle);
                WindowsIdentity wi = new WindowsIdentity(processHandle);
                string user = wi.Name;
                return user.Contains(@"\") ? user.Substring(user.IndexOf(@"\") + 1) : user;
            }
            catch
            {
                return "";
            }
            finally
            {
                if (processHandle != IntPtr.Zero)
                {
                    CloseHandle(processHandle);
                }
            }
        }

        private String GetPriority(Process process)
        {
            try
            {
                return process.PriorityClass.ToString();
            }
            catch
            {
                return "";
            }
        }

        private float GetUsedMemory(Process process)
        {
            try
            {
                return process.PrivateMemorySize64/1024f/1024f; // convet bytes into megabytes
            }
            catch
            {
                return -1;
            }
        }

        private int GetNumberOfThreads(Process process)
        {
            try
            {
                return process.Threads.Count;
            }
            catch
            {
                return -1;
            }
        }
        #endregion

        public int GetNumberOfProcesses()
        {
            return Process.GetProcesses().Length;
        }

        #region Getting information about thread
        private int GetID(ProcessThread thread)
        {
            try
            {
                return thread.Id;
            }
            catch
            {
                return -1;
            }
        }

        private String GetPriority(ProcessThread thread)
        {
            try
            {
                return thread.PriorityLevel.ToString();
            }
            catch
            {
                return "";
            }
        }

        private String GetState(ProcessThread thread)
        {
            try
            {
                return thread.ThreadState.ToString();
            }
            catch
            {
                return "";
            }
        }
        #endregion

        public float GetTotalMemoryUsage()
        {
            float memoryUsage = 0;
            foreach(var process in Process.GetProcesses())
            {
                memoryUsage += GetUsedMemory(process);
            }

            return memoryUsage;
        }
    }
}
