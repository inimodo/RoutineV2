using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace User.Forms
{
    public partial class ucpi_manager : UserControl
    {
        public ucpi_manager()
        {

              
            InitializeComponent();
        }

        partial void save_grade(object o_sender, EventArgs o_eventargs);

        partial void sub_add(object o_sender, EventArgs o_eventargs);
        partial void sub_rename(object o_sender, EventArgs o_eventargs);
        partial void sub_remove(object o_sender, EventArgs o_eventargs);

        partial void event_subject(object o_sender, EventArgs o_eventargs);
    }
}
