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
using Source;
using Source.Style;

namespace User.Action
{
    public partial class ucpcreatep : Form
    {
        Point p_relative;
        bool b_indrag = false;
        public Form o_wintype;

        public string s_Path { get { return s_PrivatePath; } }
        public string s_Class { get { return s_PrivateClass; } }

        private string s_PrivatePath { get; set; }
        private string s_PrivateClass { get; set; }
        private void Set(string s_Path, string s_Class)
        {
            s_PrivatePath = s_Path;
            s_PrivateClass = s_Class;
        }

        public ucpcreatep()
        {
            InitializeComponent();
            InitializeInterface(new Size(350, 50));
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
            this.Text = this.e_nav_title.Text;


        }
        public void InitializeUI()
        {

            this.BackColor = u_Stylesource.o_backcolor;

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

        void click_create(object sender, EventArgs e)
        {
            FolderBrowserDialog o_browser = new FolderBrowserDialog();
            if (o_browser.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(o_browser.SelectedPath))
                {
                    Set(o_browser.SelectedPath, e_inp_grade.Text);
                    this.Hide();
                    return;
                }
            }
            o_browser.Dispose();
            
        }
    }
}
