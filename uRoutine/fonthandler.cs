using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Text;

namespace Source
{
    public static class u_Fonthandler
    {
        public static bool fontinit(string s_fontpath)
        {
            if (!fontcheck(s_fontpath)) {
                u_Errorhandler.callerror(u_Stringsource.s_message_text[(int)u_Stringsource.e_messagelist.Fonterror], u_Stringsource.s_message_title[(int)u_Stringsource.e_messagelist.Fonterror]);
                return true;
            }

            return false;
        }
        private static bool fontcheck(string s_fontpath) {
            var v_winfontlist = new InstalledFontCollection();
            foreach (var v_winfontelement in v_winfontlist.Families)
            {
                if (v_winfontelement.Name == s_fontpath) return true;
            }
            return false;
        }
    }
}
