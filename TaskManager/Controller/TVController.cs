using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using TaskManager.Model;
using TaskManager.View;

namespace TaskManager.Controller
{
    public class TVController
    {
        private Timer timer;
        private ITMModel model;
        private ThreadsView view;
        private Process process;

        public TVController(ITMModel model, ThreadsView view, Process process) : this()
        {
            this.model = model;
            this.view = view;
            this.process = process;
            SetController();
            view.SetTitle(process.ProcessName);
        }

        public TVController()
        {
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += UpdateView;
            timer.Tick += UpdateThreadsCount;
            timer.Start();
        }

        private void SetController()
        {
            view.SetController(this);
        }

        private void UpdateThreadsCount(object sender, EventArgs e)
        {
            view.SetThreadsCount(model.GetNumberOfThreads(process).ToString());
        }

        private void UpdateView(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource()
            {
                DataSource = model.GetThreads(process),
                Position = view.SelectedRow
            };

            int displayedRow = view.FirstDisplayedRow;

            view.SetDataSource(source);

            view.FirstDisplayedRow = displayedRow;
        }

        public void ViewClosed()
        {
            timer.Stop();
        }
    }
}
