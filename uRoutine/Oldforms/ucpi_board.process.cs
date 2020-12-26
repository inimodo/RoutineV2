using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Source.Style;
using Source;
using User.Action;

namespace User.Forms
{
    public partial class ucpi_board
    {
        partial void event_hover(object o_sender, EventArgs o_eventargs)
        {
            Label o_sender_b = (Label)o_sender;
            o_sender_b.ForeColor = u_Stylesource.o_bhovercolor;
        }
        partial void event_endhover(object o_sender, EventArgs o_eventargs)
        {
            Label o_sender_b = (Label)o_sender;
            o_sender_b.ForeColor = u_Stylesource.o_defaultcolor;
        }
        partial void event_click(object o_sender, MouseEventArgs o_mouseeventargs)
        {
            Label o_sender_b = (Label)o_sender;
            o_sender_b.ForeColor = u_Stylesource.o_clickcolor;
        }
        partial void event_endclick(object o_sender, MouseEventArgs o_mouseeventargs)
        {
            Label o_sender_b = (Label)o_sender;
            o_sender_b.ForeColor = u_Stylesource.o_defaultcolor;
        }


        partial void click_general(object o_sender, EventArgs o_eventargs)
        {
            ucpsettings o_action = new ucpsettings();
            o_action.Show();
        }
        partial void click_manager(object o_sender, EventArgs o_eventargs)
        {
            if (u_Project.b_hooked)
            {
                ucpsubjects o_action = new ucpsubjects();
                o_action.Show();
            }
        }
        partial void click_all(object o_sender, EventArgs o_eventargs)
        {
            if (u_Project.b_running)
            {
                if (u_Project.b_allowsedit)
                {
                    click_create(o_sender, o_eventargs);
                }
                else
                {
                    ucpopen o_action = new ucpopen();
                    o_action.Show();
                }
            }
        }
        partial void click_share(object o_sender, EventArgs o_eventargs)
        {
            if (u_Project.b_running)
            {
                ucpexport o_action = new ucpexport();
                o_action.Show();
            }
        }

        partial void click_create(object o_sender, EventArgs o_eventargs)
        {

            if (u_Project.b_running)
            {
                ucpcreate o_action = new ucpcreate();
                o_action.Show();
            }
        }

        partial void click_appointment(object o_sender, EventArgs o_eventargs)
        {
            if (u_Project.b_running)
            {
                ucpappointments o_action = new ucpappointments();
                o_action.Show();
            }
        }

    }
}
