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
    public partial class ucpi_share : UserControl
    {
        public ucpi_share()
        {
            InitializeComponent();
        }

        partial void click_load(object o_sender, EventArgs o_eventargs);
        partial void click_searchcode(object o_sender, EventArgs o_eventargs);
        partial void click_export(object o_sender, EventArgs o_eventargs);
        partial void click_search(object o_sender, EventArgs o_eventargs);
        partial void click_import(object o_sender, EventArgs o_eventargs);
    }
}
