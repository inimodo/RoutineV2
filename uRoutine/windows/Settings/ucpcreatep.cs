using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User.Source;

namespace User.Action
{
    public partial class ucpcreatep : Form
    {
        Winstyle.Windrag o_Drag;
        public ucpcreatep()
        {
            InitializeComponent();
            Winstyle.Apply(this,new Size(350, 50),"Create Project");
            o_Drag = new Winstyle.Windrag(this);


        }
        public string s_GradeName = "";
        private void EnterCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CloseDialog(null,null);
        }

        private void CloseDialog(object sender, EventArgs e)
        {
            s_GradeName = this.e_inp_grade.Text;
            this.Close();
        }

    }
}
