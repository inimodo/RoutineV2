using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using User.Action;
namespace User.Source
{
    public static class u_Message
    {
        public static void Say(string s_title,string s_message) {
            ucpmessager o_window = new ucpmessager(false, s_title, s_message);
            o_window.ShowDialog();
        }

        public static bool Ask(string s_title, string s_message)
        {
            ucpmessager o_window = new ucpmessager(true, s_title, s_message);

            o_window.ShowDialog();

            return o_window.b_answer;
        }
    }
}
