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
    public partial class ucpi_lesson : UserControl
    {
        public ucpi_lesson()
        {
            InitializeComponent();
        }
        partial void SetTree();
        partial void click_add(object o_sender, EventArgs o_eventargs);
        partial void click_rename(object o_sender, EventArgs o_eventargs);
        partial void click_remove(object o_sender, EventArgs o_eventargs);
        partial void click_externaladd(object o_sender, EventArgs o_eventargs);
        partial void event_edittopic(object o_sender, EventArgs o_eventargs);
        partial void event_doubleclick(object o_sender, EventArgs o_eventargs);

        partial void event_editfile(object o_sender, EventArgs o_eventargs);

        partial void click_close(object o_sender, EventArgs o_eventargs);

        partial void click_openfolder(object o_sender, EventArgs o_eventargs);
        partial void click_deletelesson(object o_sender, EventArgs o_eventargs);

    }
}
