﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Source;

namespace User.Messager
{
    public static class u_Message
    {
        public static void Say(string s_title,string s_message,bool b_error) {
            ucpmessager o_window = new ucpmessager(false, s_title, s_message);
            o_window.ShowDialog();
            if(b_error)
                u_Errorhandler.calllog(s_message, "MSG-Q");
        }

        public static bool Ask(string s_title, string s_message)
        {
            ucpmessager o_window = new ucpmessager(true, s_title, s_message);

            o_window.ShowDialog();

            return o_window.b_answer;
        }
    }
}