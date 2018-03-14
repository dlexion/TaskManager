using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.View;
using TaskManager.Model;

namespace TaskManager.Controller
{
    public class PVController
    {
        private Timer timer;
        private ITMModel model;
        private ProcessesView view;

        public PVController(ITMModel model, ProcessesView view) : this()
        {
            this.model = model;
            this.view = view;
            SetController();
        }

        public PVController()
        {
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += UpdateView;
            timer.Tick += UpdateProcessesCount;
            timer.Tick += UpdateMemoryUsage;
            timer.Start();
        }

        private void SetController()
        {
            view.SetController(this);
        }

        private void UpdateMemoryUsage(object sender, EventArgs e)
        {
            view.SetMemoryUsage(model.GetTotalMemoryUsage().ToString());
        }

        private void UpdateProcessesCount(object sender, EventArgs e)
        {
            view.SetProcessesCount(model.GetNumberOfProcesses().ToString());
        }

        private void UpdateView(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource()
            {
                DataSource = model.GetProcesses(),
                Position = view.SelectedRow
            };

            int displayedRow = view.FirstDisplayedRow;

            view.SetDataSource(source);

            view.FirstDisplayedRow = displayedRow;
        }

        public void DoubleClick(int proceddId)
        {
            Program.CreateThreadsWindow(System.Diagnostics.Process.GetProcessById(proceddId));
        }
    }
}
