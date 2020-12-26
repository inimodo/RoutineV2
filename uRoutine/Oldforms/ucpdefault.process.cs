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

using Source;
using Source.Style;
using System.IO;

namespace User
{
    public partial class ucpdefault {


        Point p_relative;
        bool b_indrag = false;
        partial void Move_run(object sender, MouseEventArgs e)
        {
            if (b_indrag)
            {
                this.Location = new Point(Cursor.Position.X - p_relative.X, Cursor.Position.Y - p_relative.Y);
            }
        }

        partial void Move_stop(object sender, MouseEventArgs e)
        {
            b_indrag = false;
        }

        partial void Move_start(object sender, MouseEventArgs e)
        {
            p_relative = this.PointToClient(Cursor.Position);
            b_indrag = true;
        }

        partial void Loggout(object sender, EventArgs e)
        {
            File.Delete(u_Stringsource.s_defaultcfgfile);
            Closeloop(1);
        }

        partial void Close(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        partial void Close_hover(object sender, EventArgs e)
        {
            e_nav_close.BackColor = Color.FromArgb(206, 50, 52);
        }

        partial void Minimize_hover(object sender, EventArgs e)
        {
            e_nav_minimize.BackColor = Color.FromArgb(50, 50, 50);
        }

        partial void Close_hover_leave(object sender, EventArgs e)
        {
            e_nav_close.BackColor = u_Stylesource.o_dragcolor;
        }

        partial void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        partial void Minimize_hover_leave(object sender, EventArgs e)
        {
            e_nav_minimize.BackColor = u_Stylesource.o_dragcolor;
        }

        partial void event_reopen(object sender, EventArgs e)
        {
            if (u_Project.lesson.b_access)
            {
                u_Manager.OpenLesson(u_Project.lesson.o_loadedlesson.s_hash);
            }

        }

        partial void event_focus(object sender, EventArgs e)
        {
            this.BackColor = u_Stylesource.o_bordercolor;
        }
        partial void event_unfocus(object sender, EventArgs e)
        {
            this.BackColor = u_Stylesource.o_clickcolor;

        }
    }
}
