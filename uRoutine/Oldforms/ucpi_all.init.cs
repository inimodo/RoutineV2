using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User;
using Source;
using Source.Style;
using System.Drawing;

namespace User.Forms
{
    partial class ucpi_all
    {
        public void InitializeInterface()
        {
            this.BackColor = u_Stylesource.o_backcolor;

            this.e_list.BackColor = u_Stylesource.o_backcolor;
            this.e_list.ForeColor = u_Stylesource.o_defaultcolor;
        }
        public void UpdateList()
        {

            if (u_Project.b_running)
            {
                if (!u_Project.b_allowsedit)
                {
                    ListLessons();
                }
            }
        }
    }
}
