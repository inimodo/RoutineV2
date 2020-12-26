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
    public partial class ucpi_appointments : UserControl
    {
        public ucpi_appointments()
        {
            InitializeComponent();
        }

        partial void click_save(object o_sender, EventArgs o_eventargs);
        partial void click_delete(object o_sender, EventArgs o_eventargs);
        partial void click_add(object o_sender, EventArgs o_eventargs);
        partial void event_ao(object o_sender, EventArgs o_eventargs);

        partial void event_sellect(object o_sender, EventArgs o_eventargs);

        private void e_sel_subject_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void e_inp_date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
