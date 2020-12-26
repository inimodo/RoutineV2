using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Source;
using System.Diagnostics;
using User.Messager;
using User.Action;
using System.Drawing;

namespace User
{
    public static class systementry
    {

        [STAThread]
        public static void Main(string[] s_args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            u_Errorhandler.errorinit(u_Stringsource.s_logfile);
            if (u_Fonthandler.fontinit(u_Stringsource.s_fontname)) return;
            else u_Errorhandler.autolog((int)u_Stringsource.e_messagelist.Loadedfont);


            u_Confighandler.configset(u_Stringsource.s_defaultcfgfile);


            u_Errorhandler.autolog((int)u_Stringsource.e_messagelist.Logged);  
            u_Confighandler.kill();

            ucpboard o_page = new ucpboard(s_args);

            Rectangle o_res = Screen.PrimaryScreen.WorkingArea;
            Point o_pos = new Point(o_res.Width - o_page.Width, o_res.Height - o_page.Height);
            o_page.Show();
            o_page.Location = o_pos;

            if (o_page.b_close) return;
            Application.Run(o_page);


            switch (o_page.i_exitcode)
            {
                case 0:
                    u_Errorhandler.autolog((int)u_Stringsource.e_messagelist.Exit);
                    break;
                case 1:
                    u_Errorhandler.autolog((int)u_Stringsource.e_messagelist.Loggedout);

                    break;
                case 2:
                    u_Errorhandler.autolog((int)u_Stringsource.e_messagelist.Universal);
                    break;

                default:
    
                    break;

            }

            u_Errorhandler.errorkill();
            return;
        }
    }
}
