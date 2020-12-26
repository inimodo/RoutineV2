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
    public partial class ucpi_board : UserControl
    {
        public ucpi_board()
        {
            InitializeComponent();
        }

        partial void event_hover(object o_sender, EventArgs o_eventargs);
        partial void event_endhover(object o_sender, EventArgs o_eventargs);

        partial void event_click(object o_sender, MouseEventArgs o_mouseeventargs);
        partial void event_endclick(object o_sender, MouseEventArgs o_mouseeventargs);

        partial void click_general(object o_sender, EventArgs o_eventargs);
        partial void click_manager(object o_sender, EventArgs o_eventargs);
        partial void click_all(object o_sender, EventArgs o_eventargs);
        partial void click_share(object o_sender, EventArgs o_eventargs);

        partial void click_create(object o_sender, EventArgs o_eventargs);
        partial void click_appointment(object o_sender, EventArgs o_eventargs);
    }
}
