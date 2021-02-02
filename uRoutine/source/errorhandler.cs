using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using User.Source;


namespace User.Source
{
    public static class u_Errorhandler
    {
        private static StreamWriter sw_logwriter;
        private static string s_file;

        public static string s_output="";

        public static void errorinit(string s_logfile)
        {
            s_file = s_logfile;
        }
        public static void errorkill()
        {
            sw_logwriter.Close();
        }
        public static void callerror(string s_error_text, string s_error_title)
        {
            calllog(s_error_text, s_error_title);
            MessageBox.Show(
                s_error_text,
                s_error_title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );

        }
        public static void calllog(string s_message, string s_title)
        {
            if(s_file != null || s_file != null)
            {
                sw_logwriter = new StreamWriter(s_file);
                if(sw_logwriter == null)
                {
                    return;
                }
            }
            else
            {
                return;
            }
            string s_logentry = u_Stringsource.s_logformat;
            s_logentry = s_logentry.Replace("(DATE)",DateTime.UtcNow.ToLongTimeString());
            s_logentry = s_logentry.Replace("(TITLE)", s_title);
            s_logentry = s_logentry.Replace("(TEXT)", s_message);
            s_output += s_logentry+"\n";
            sw_logwriter.WriteLine(s_logentry);
            sw_logwriter.Close();
        }
        public static void autolog(int i_code) {

            calllog(u_Stringsource.s_message_text[i_code], u_Stringsource.s_message_title[i_code]);
        }
    }
}
