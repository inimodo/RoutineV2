using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using Source;
using Source.Style;
using Source.Routines;
using User.Messager;
using User.Properties;

namespace User
{
    public partial class ucpdefault
    {

        public void InitializeInterface() {

            SetSize(new Size(334, 40));

            e_nav_title.Text = u_Stringsource.s_appname;

            if (u_Project.user.b_loggedin)
            {
                this.Text = u_Project.user.s_username + " | " + u_Stringsource.s_appname;
                e_nav_user.Text = u_Project.user.s_username;
            }
            else
            {
                this.Text = u_Stringsource.s_appname;
                e_nav_user.Hide();
            }
            e_windows.Text = this.Text;

            this.e_hider.BackColor = u_Stylesource.o_backcolor;

            this.BackColor = u_Stylesource.o_clickcolor;
            this.e_nav.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_logo.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_title.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_user.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_loggout.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_pad.BackColor = u_Stylesource.o_defaultcolor;
            this.e_nav_minimize.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_close.BackColor = u_Stylesource.o_dragcolor;

            this.e_nav_title.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_nav_user.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_info_version.BackColor = u_Stylesource.o_backcolor;
            this.e_info_version.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_info_version.Text = u_Project.s_version;

            this.e_tog_smartstart.BackColor = u_Stylesource.o_backcolor;
            this.e_tog_smartstart.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_ucplogo.BackColor = u_Stylesource.o_backcolor;
            this.e_tog_smartstart.Checked = u_Project.software.b_smartstart;


        }
        public void SetSize(Size o_size)
        {

            int i_offset = this.Size.Width - o_size.Width;

            this.e_nav_close.Location = new Point(this.e_nav_close.Location.X - i_offset, this.e_nav_close.Location.Y);
            this.Size = new Size(o_size.Width, o_size.Height + e_nav.Size.Height);
            this.e_hider.Size = new Size(o_size.Width - 2, o_size.Height - 2);
            this.e_hider.Location = new Point(1, 1 + e_nav.Size.Height);
            this.e_nav.Location = new Point(1, 1);
            this.e_nav.Size = new Size(o_size.Width - 2, e_nav.Size.Height);
            this.e_nav_logo.Location = new Point(e_nav_logo.Location.X, 1);

        }

    }
}
