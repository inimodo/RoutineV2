using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User.Source
{
    public static class Winstyle
    {
        public static void Apply(Form o_This,Size o_Size)
        {
            o_This.Size = new Size(o_Size.Width+2,o_Size.Height+32);
            o_This.BackColor = Stylesource.o_border;
            foreach (Control o_Control in o_This.Controls)
            {
                if (o_Control.Name.Contains("_nav_")) o_Control.BackColor = Stylesource.o_dragbar;
                else o_Control.BackColor = Stylesource.o_boxcolor;

                if (o_Control is TextBox)
                {
                    o_Control.ForeColor = Stylesource.o_text;
                    if (o_Control.Name.Contains("_nav_")) o_Control.BackColor = Stylesource.o_dragbar;
                    else o_Control.BackColor = Stylesource.o_kontrast;
                }

                if (o_Control is TreeView || o_Control is Label || o_Control is ListView || o_Control is Panel)
                {
                    o_Control.ForeColor = Stylesource.o_text;
                    o_Control.BackColor = Stylesource.o_form;
                }
            }
        }
    }
}