using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User.Action
{
    public partial class ucpmessager : Form
    {

        public bool b_answer;
        private bool b_ask;

        private string s_wintitle;
        private string s_wintext;
        public ucpmessager(bool b_askfor,string s_title,string s_msg)
        {
            s_wintitle = s_title;
            s_wintext = s_msg;
            b_ask = b_askfor;
            
            InitializeComponent();

            InitializeInterface();
        }
        partial void InitializeInterface();

        partial void click_no(object o_sender, EventArgs e_eventargs);
        partial void click_yes(object o_sender, EventArgs e_eventargs);

        partial void Move_start(object o_sender, MouseEventArgs o_mouseventargs);
        partial void Move_run(object o_sender, MouseEventArgs o_mouseventargs);
        partial void Move_stop(object o_sender, MouseEventArgs o_mouseventargs);
    }
}
