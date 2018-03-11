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
    }
}
