using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source;
using Source.Style;

namespace User.Action
{
    public partial class ucpcreateappointment : Form
    {
        Point p_relative;
        bool b_indrag = false;


        public DateTime o_Due { get { return o_PrivateDue; }  }
        public int i_Subject { get { return i_PrivateSubject; } }

        private DateTime o_PrivateDue { get; set; }
        private int i_PrivateSubject { get; set; }
        private void Set(int i_Index,DateTime o_Date)
        {
            o_PrivateDue = o_Date;
            i_PrivateSubject = i_Index;
        }
        

        public ucpcreateappointment()
        {
            InitializeComponent();
            InitializeInterface(new Size(210, 100));
            InitializeUI();
        }

        void InitializeInterface(Size o_size)
        {
            int i_offset = this.Size.Width - o_size.Width;
            this.e_nav_close.Location = new Point(this.e_nav_close.Location.X - i_offset, this.e_nav_close.Location.Y);
            this.Size = new Size(o_size.Width, o_size.Height + e_nav.Size.Height);
            this.e_hider.Size = new Size(o_size.Width - 2, o_size.Height - 2);
            this.e_hider.Location = new Point(1, 1 + e_nav.Size.Height);
            this.e_nav.Location = new Point(1, 1);
            this.e_nav.Size = new Size(o_size.Width - 2, e_nav.Size.Height);
            this.e_nav_logo.Location = new Point(e_nav_logo.Location.X, 1);

            this.BackColor = u_Stylesource.o_bordercolor;
            this.e_nav.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_logo.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_title.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_title.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_hider.BackColor = u_Stylesource.o_backcolor;
            this.e_nav_title.Text = "Create";

        }
        public void InitializeUI()
        {

            if (u_Project.b_running)
            {
                this.e_sel_subject.Items.Clear();
                this.e_sel_subject.Items.AddRange(u_Project.subjects.s_subjects);
            }
            this.BackColor = u_Stylesource.o_backcolor;

            this.e_inp_date.BackColor = u_Stylesource.o_backcolor;
            this.e_sel_subject.BackColor = u_Stylesource.o_backcolor;

            this.e_inp_date.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_sel_subject.ForeColor = u_Stylesource.o_defaultcolor;
        }

        void event_focus(object sender, EventArgs e)
        {
            this.BackColor = u_Stylesource.o_bordercolor;
        }
        void event_unfocus(object sender, EventArgs e)
        {
            this.BackColor = u_Stylesource.o_clickcolor;

        }
        void event_close(object sender, EventArgs e)
        {
            this.Hide();
        }

        void Move_start(object o_sender, MouseEventArgs o_mouseventargs)
        {
            p_relative = this.PointToClient(Cursor.Position);
            b_indrag = true;
        }
        void Move_run(object o_sender, MouseEventArgs o_mouseventargs)
        {
            if (b_indrag)
            {
                this.Location = new Point(Cursor.Position.X - p_relative.X, Cursor.Position.Y - p_relative.Y);
            }
        }
        void Move_stop(object o_sender, MouseEventArgs o_mouseventargs)
        {
            b_indrag = false;
        }

        private void event_add(object sender, EventArgs e)
        {
            Set(e_sel_subject.SelectedIndex, e_inp_date.Value);
            this.Hide();
        }
    }
}
