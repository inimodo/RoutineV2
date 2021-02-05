using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User.Source;

namespace User.Action
{
    public partial class ucpmessager : Form
    {

        public bool b_answer;
        Winstyle.Windrag o_Drag;

        public ucpmessager(bool b_askfor,string s_title,string s_msg)
        {
            InitializeComponent();
            Winstyle.Apply(this, new Size(359, 148), s_title);
            o_Drag = new Winstyle.Windrag(this);

            if (b_askfor)
            {
                this.e_yes.Text = "YES";
                this.e_no.Text = "NO";
            }
            else
            {
                this.e_yes.Hide();
                this.e_no.Text = "OKAY";
            }
            this.e_msg.Text = s_msg;
        }

        private void Yes(object sender, EventArgs e)
        {
            b_answer = true;
            this.Close();
        }

        private void No(object sender, EventArgs e)
        {
            b_answer = false;
            this.Close();
        }
    }
}
