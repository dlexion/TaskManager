using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using TaskManager.View;
using TaskManager.Model;
using TaskManager.Controller;

namespace TaskManager
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ProcessesView view = new ProcessesView();
            ITMModel model = new TMModel();
            PVController controller = new PVController(model, view);

            Application.Run(view);
        }

        public static void CreateThreadsWindow(System.Diagnostics.Process process)
        {
            ThreadsView view = new ThreadsView();
            ITMModel model = new TMModel();
            TVController controller = new TVController(model, view, process);
            view.Visible = true;
        }
    }
}
