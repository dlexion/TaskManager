using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager.View
{
    interface ITMView
    {
        void SetDataSource(BindingSource source);
        int FirstDisplayedRow { get; set; }
        int SelectedRow { get; }
    }
}
