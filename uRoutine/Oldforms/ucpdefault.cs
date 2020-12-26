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
using User.Messager;

namespace User
{

    public partial class ucpdefault : Form 
    {
        public int i_exitcode;
        public bool b_close = false;
        public ucpdefault(string s_name,string s_code,bool b_logged,string[] s_args,bool b_con)
        {
            InitializeComponent();

            u_Project.user.Senduser(s_name, s_code, b_logged);

            u_Manager.InitializeSoftware();
            if (b_con)
            {
                if (s_args.Length != 1 && u_Project.software.b_smartstart)
                {

                    if (File.Exists(u_Stringsource.s_version))
                    {
                        Process.Start(Application.StartupPath + @"\" + u_Stringsource.s_version, u_Stringsource.s_version_update);
                        b_close = true;
                        return;
                    }
                    else
                    {
                        u_Message.Say(u_Stringsource.s_load_title[17], u_Stringsource.s_load_text[17], true);
                    }
                }
            }
            else
            {
                u_Message.Say(u_Stringsource.s_load_title[18], u_Stringsource.s_load_text[18], true);
            }
            u_Manager.ReadVersionFile();
            u_Manager.StartProject();
            InitializeInterface();
            this.WindowState = FormWindowState.Minimized;

        }
        void sel_smartstart(object o_sender, EventArgs o_eventargs)
        {
            u_Project.software.b_smartstart = e_tog_smartstart.Checked;
            u_Manager.SaveProjectCfg();

        }
        partial void Loggout(object sender, EventArgs e);
        partial void Close(object sender, EventArgs e);
        partial void Close_hover(object sender, EventArgs e);
        partial void Minimize_hover(object sender, EventArgs e);
        partial void Close_hover_leave(object sender, EventArgs e);
        partial void Minimize(object sender, EventArgs e);
        partial void Minimize_hover_leave(object sender, EventArgs e);
        partial void Move_start(object sender, MouseEventArgs e);
        partial void Move_stop(object sender, MouseEventArgs e);
        partial void Move_run(object sender, MouseEventArgs e);

        partial void event_reopen(object sender, EventArgs e);


        partial void event_focus(object sender, EventArgs e);
        partial void event_unfocus(object sender, EventArgs e);

    }
}
