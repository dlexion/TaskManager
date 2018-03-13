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
    public partial class ProcessesView : Form, ITMView
    {
        private PVController controller;

        public int FirstDisplayedRow
        {
            get
            {
                return dataGridView.FirstDisplayedScrollingRowIndex;
            }
            set
            {
                dataGridView.FirstDisplayedScrollingRowIndex = value >= 0 && value <= dataGridView.RowCount ? value : 0;
            }
        }

        public int SelectedRow
        {
            get
            {
                return dataGridView.Rows.IndexOf(dataGridView.CurrentRow);
            }
        }

        public ProcessesView()
        {
            InitializeComponent();
        }

        public void SetDataSource(BindingSource source)
        {
            dataGridView.DataSource = source;
        }

        public void SetProcessesCount(string count)
        {
            tsslProcessesCount.Text = count;
        }

        public void SetMemoryUsage(string value)
        {
            tsslMemoryUsageValue.Text = value;
        }
    }
}
