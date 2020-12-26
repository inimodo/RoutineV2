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
    public partial class ucpsettings : Form
    {
        Point p_relative;
        bool b_indrag = false;
        public Form o_wintype;
        public ucpsettings()
        {
            InitializeComponent();
            InitializeInterface(new Size(520, 195));
            InitializeUI();
        }

        void InitializeInterface(Size o_size)
        {
            UpdateList();
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
            this.e_nav_title.Text = "Settings";
            this.Text = this.e_nav_title.Text;


        }
        public void InitializeUI()
        {

            this.BackColor = u_Stylesource.o_backcolor;

            this.e_disp_subjects.ForeColor = u_Stylesource.o_backcolor;
            this.e_disp_subjects.BackColor = u_Stylesource.o_defaultcolor;

            this.e_disp_subjects.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_disp_subjects.BackColor = u_Stylesource.o_formcolor;

            this.e_but_subjects_add.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_subjects_add.BackColor = u_Stylesource.o_backcolor;
            this.e_but_subjects_remove.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_subjects_remove.BackColor = u_Stylesource.o_backcolor;
            this.e_but_subjects_rename.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_subjects_rename.BackColor = u_Stylesource.o_backcolor;
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


        void select_project(object o_sender, EventArgs o_eventargs)
        {
            if (e_disp_subjects.SelectedItems.Count > 0)
            {          
                u_Project.software.s_projectfolder = u_Project.software.s_projectroutes[e_disp_subjects.SelectedItems[0].ImageIndex];
                u_Project.software.b_ploaded = true;
                u_Manager.SaveProjectCfg();
                u_Manager.LoadProject();
                UpdateList();
            }
            this.Hide();
        }
        void create_project(object o_sender, EventArgs o_eventargs)
        {
            ucpcreatep o_action = new ucpcreatep();
            o_action.ShowDialog();

            if (o_action.s_Path != null)
            {
                u_Project.software.s_projectfolder = o_action.s_Path;
                u_Manager.Create(o_action.s_Path);
                u_Project.software.b_ploaded = true;
                u_Project.pinfo.s_grade = o_action.s_Class;
                u_Manager.SaveProjectCfg();
                u_Manager.LoadProject();
                UpdateList();
            }
        }
        void loadout_project(object o_sender, EventArgs o_eventargs)
        {
            if (e_disp_subjects.SelectedItems.Count > 0)
            {
                u_Manager.RemoveRoute(e_disp_subjects.SelectedItems[0].ImageIndex);
                u_Project.software.b_ploaded = false;

                u_Manager.SaveProjectCfg();
                u_Manager.LoadProject();
                UpdateList();
            }
        }
        private void UpdateList()
        {
            if (u_Project.software.s_projectroutes != null)
            {
                ImageList o_list = new ImageList();

                e_disp_subjects.Items.Clear();
                for (int i_index = 0; i_index < u_Project.software.s_projectroutes.Length; i_index++)
                {
                    e_disp_subjects.Items.Add(u_Project.software.s_projectroutes[i_index], i_index);
                    o_list.Images.Add(User.Properties.Resources.folder);
                }
                e_disp_subjects.SmallImageList = o_list;
            }
        }


        private void event_open(object sender, EventArgs e)
        {
            select_project(sender,e);
        }
        public string GetPath()
        {
            FolderBrowserDialog o_browser = new FolderBrowserDialog();
            if (o_browser.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(o_browser.SelectedPath))
                {
                    return o_browser.SelectedPath;
                }
            }
            o_browser.Dispose();
            return null;
        }
        private void event_extern(object sender, EventArgs e)
        {
            string s_path = GetPath();
            if (s_path != null)
            {
                u_Project.software.s_projectfolder = s_path;
                u_Project.software.b_ploaded = true;
                u_Manager.SaveProjectCfg();
                u_Manager.LoadProject();
                u_Manager.Addroute(s_path);
                UpdateList();

            }
        }
    }
}
