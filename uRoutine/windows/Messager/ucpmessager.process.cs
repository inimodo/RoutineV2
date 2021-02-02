using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User.Action
{
    partial class ucpmessager
    {
        partial void click_no(object o_sender, EventArgs e_eventargs)
        {
            b_answer = false;
            this.Close();
        }
        partial void click_yes(object o_sender, EventArgs e_eventargs)
        {
            b_answer = true;
            this.Close();
        }

        Point p_relative;
        bool b_indrag = false;
        partial void Move_start(object o_sender, MouseEventArgs o_mouseventargs)
        {
            p_relative = this.PointToClient(Cursor.Position);
            b_indrag = true;
        }
        partial void Move_run(object o_sender, MouseEventArgs o_mouseventargs)
        {
            if (b_indrag)
            {
                this.Location = new Point(Cursor.Position.X - p_relative.X, Cursor.Position.Y - p_relative.Y);
            }
        }
        partial void Move_stop(object o_sender, MouseEventArgs o_mouseventargs)
        {
            b_indrag = false;
        }
    }
}
