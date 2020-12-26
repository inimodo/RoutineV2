using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User.Forms
{
    public partial class ucpi_all : UserControl
    {
        public ucpi_all()
        {
            InitializeComponent();
        }


        partial void event_open(object o_sender, EventArgs o_eventargs);
        partial void event_sel(object o_sender, TreeViewEventArgs o_eventargs);
    }
}
