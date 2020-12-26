using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Source.Style;
namespace User.Messager
{
    public partial class ucpmessager
    {
        partial void InitializeInterface()
        {
            this.BackColor = u_Stylesource.o_bordercolor;
            this.e_nav.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_logo.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_title.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_title.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_hider.BackColor = u_Stylesource.o_backcolor;

            this.e_nav_title.Text = s_wintitle;

            this.e_yes.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_no.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_yes.BackColor = u_Stylesource.o_backcolor;
            this.e_no.BackColor = u_Stylesource.o_backcolor;
            if (b_ask)
            {
                this.e_yes.Text = "YES";
                this.e_no.Text = "NO";
            }
            else
            {
                this.e_yes.Hide();
                this.e_no.Text = "OKAY";
            }
            this.e_msg.Text = s_wintext;
            this.e_msg.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_msg.BackColor = u_Stylesource.o_backcolor;
            this.Text = s_wintitle;

        }
    }
}
