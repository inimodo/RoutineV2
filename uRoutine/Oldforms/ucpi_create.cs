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
    public partial class ucpi_create : UserControl
    {
        public ucpi_create()
        {
            InitializeComponent();
        }

        partial void click_fe_add(object o_sender, EventArgs o_eventargs);
        partial void click_fe_remove(object o_sender, EventArgs o_eventargs);
        partial void click_fe(object o_sender, EventArgs o_eventargs);
        partial void click_fe_sel(object o_sender, EventArgs o_eventargs);

        partial void event_changeitem(object o_sender, EventArgs o_eventargs);

    }
}
