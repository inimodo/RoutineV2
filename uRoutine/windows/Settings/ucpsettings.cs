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


    public partial class ucpsettings : Form
    {
        Winstyle.Windrag o_Drag;
        public ucpsettings()
        {

            InitializeComponent();
            Winstyle.Apply(this, new Size(520, 195),"Years");
            o_Drag = new Winstyle.Windrag(this);
        }

        private void CreateNewYear(object sender, EventArgs e)
        {
            ucpcreatep o_YearDialog = new ucpcreatep();
            o_YearDialog.ShowDialog();
            if (!CheckName(o_YearDialog.s_GradeName))
            {
                Notify.Say("Invalid Name","Sorry, but the charakter '][}:=#' are not allowed to be used in the grade name.");
            }
            //Create Year/Grade
            UpdateView();
        }

        private bool CheckName(string s_Text)
        {
            char[] c_Forbiden = { ']', '[', '{', '}', ':', '=', '#' };
            for (int i_Index = 0; i_Index < c_Forbiden.Length; i_Index++)
            {
                if (s_Text.Contains(c_Forbiden[i_Index])) return false;
            }
            return true;
        }
        public void UpdateView()
        {
        }


    }

   

}