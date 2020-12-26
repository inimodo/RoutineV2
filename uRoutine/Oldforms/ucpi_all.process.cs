using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Source;
using Source.Routines;
using User;
using System.Diagnostics;

namespace User.Forms
{
    partial class ucpi_all
    {
        string s_hash ="";
        string s_file ="";

        partial void event_open(object o_sender, EventArgs o_eventargs)
        {
            if (s_hash != "")
            {
                u_Manager.OpenLesson(s_hash);
            }
            if (s_file != "")
            {
                if (File.Exists(s_file))
                {
                    Process.Start(s_file);
                }
            }
        }
        partial void event_sel(object o_sender, TreeViewEventArgs o_eventargs)
        {
            if (o_eventargs.Node.Level == 1)
            {
                s_hash = o_eventargs.Node.Name;
                s_file = "";
            }
            else
            if (o_eventargs.Node.Level == 2)
            {
                s_hash = "";
                s_file = u_Manager.GetFileLessonPath( o_eventargs.Node.Name)+ o_eventargs.Node.Text;
            }
        }

    }
}
