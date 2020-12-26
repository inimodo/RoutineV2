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
    public partial class ucpi_general : UserControl
    {
        public ucpi_general()
        {
            InitializeComponent();
        }

        partial void select_project(object o_sender, EventArgs o_eventargs);
        partial void create_project(object o_sender, EventArgs o_eventargs);
        partial void loadout_project(object o_sender, EventArgs o_eventargs);

        partial void sel_autostart(object o_sender, EventArgs o_eventargs);
        partial void sel_smartstart(object o_sender, EventArgs o_eventargs);
    }
}
