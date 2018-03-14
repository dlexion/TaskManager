using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Controller;

namespace TaskManager.View
{
    public partial class ThreadsView : Form, ITMView
    {
        TVController controller;

        public ThreadsView()
        {
            InitializeComponent();
        }

        public int FirstDisplayedRow
        {
            get
            {
                return dataGridViewThreads.FirstDisplayedScrollingRowIndex;
            }
            set
            {
                dataGridViewThreads.FirstDisplayedScrollingRowIndex = value >= 0 && value <= dataGridViewThreads.RowCount ? value : 0;
            }
        }

        public int SelectedRow
        {
            get
            {
                return dataGridViewThreads.Rows.IndexOf(dataGridViewThreads.CurrentRow);
            }
        }

        public void SetController(TVController controller)
        {
            this.controller = controller;
        }

        public void SetDataSource(BindingSource source)
        {
            dataGridViewThreads.DataSource = source;
        }

        public void SetThreadsCount(string value)
        {
            tsslThreadsCountValue.Text = value;
        }

        private void ThreadsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.timer.Stop();
        }

        public void SetTitle(string title)
        {
            this.Text = title;
        }
    }
}
