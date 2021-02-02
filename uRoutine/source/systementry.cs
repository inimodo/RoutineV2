using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;

using User.Action;

namespace User
{
    public static class systementry
    {

        [STAThread]
        public static void Main(string[] s_args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ucpboard o_page = new ucpboard(s_args);

            o_page.Show();
            o_page.Location = new Point( Screen.PrimaryScreen.WorkingArea.Width - o_page.Width, Screen.PrimaryScreen.WorkingArea.Height - o_page.Height); ;

            Application.Run(o_page);

            return;
        }
    }
}
