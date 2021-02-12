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
        public static void Apply(Form o_This, Size o_Size, string s_Title)
        {
            o_This.Text = s_Title;
            o_This.Size = new Size(o_Size.Width + 2, o_Size.Height + 32);
            o_This.BackColor = Stylesource.o_border;

            void ApplyControl(Control o_Control)
            {
                if (o_Control.Name.Contains("_nav_")) o_Control.BackColor = Stylesource.o_dragbar;
                else o_Control.BackColor = Stylesource.o_boxcolor;

                if (o_Control is TextBox || o_Control is DomainUpDown)
                {
                    o_Control.ForeColor = Stylesource.o_text;
                    if (o_Control.Name.Contains("_nav_")) o_Control.BackColor = Stylesource.o_dragbar;
                    else o_Control.BackColor = Stylesource.o_kontrast;
                }

                if (o_Control is TreeView || o_Control is Label || o_Control is ListView || o_Control is Panel || o_Control is Button)
                {
                    o_Control.ForeColor = Stylesource.o_text;
                    o_Control.BackColor = Stylesource.o_form;
                }
                if (o_Control.Name == "e_nav_title") o_Control.Text = s_Title;
            }


            foreach (Control o_Control in o_This.Controls)
            {
                ApplyControl(o_Control);
                if (o_Control is Panel)
                {
                    foreach (Control o_SubControl in o_Control.Controls)
                    {
                        ApplyControl(o_SubControl);
                    }
                }
            }
        }
        

        public class Windrag
        {
            public Windrag(Form o_This,bool b_CloseOnDeFocus = true)
            {
                this.b_CloseOnDeFocus = b_CloseOnDeFocus;
                this.o_This = o_This;
                this.o_This.Activated += new System.EventHandler(this.Focus);
                this.o_This.Deactivate += new System.EventHandler(this.UnFocus);
                foreach (Control o_Control in o_This.Controls)
                {
                    if (o_Control.Name == "e_nav_grab" || o_Control.Name == "e_nav_title" || o_Control.Name == "e_nav_logo")
                    {
                        o_Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveStart);
                        o_Control.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
                        o_Control.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveStop);
                    }
                    if (o_Control.Name == "e_nav_close")
                    {
                        o_Control.Click += new System.EventHandler(this.Close);
                    }
                }
            }
            private bool b_CloseOnDeFocus;
            private Form o_This;
            private Point p_relative;
            private bool b_indrag = false;
            void Focus(object sender, EventArgs e)
            {
                o_This.BackColor = Stylesource.o_border;
            }
            void UnFocus(object sender, EventArgs e)
            {
                o_This.BackColor = Stylesource.o_clickcolor;
                if (b_CloseOnDeFocus) Close(sender,e);
            }

            void Close(object sender, EventArgs e)
            {
                o_This.Hide();
            }

            void MoveStart(object o_sender, MouseEventArgs o_mouseventargs)
            {
                p_relative = o_This.PointToClient(Cursor.Position);
                b_indrag = true;
            }
            void Move(object o_sender, MouseEventArgs o_mouseventargs)
            {
                if (b_indrag)
                {
                    o_This.Location = new Point(Cursor.Position.X - p_relative.X, Cursor.Position.Y - p_relative.Y);
                }
            }
            void MoveStop(object o_sender, MouseEventArgs o_mouseventargs)
            {
                b_indrag = false;

            }

        }
    }
}