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
    public partial class ucpsubjects : Form
    {
        Point p_relative;
        bool b_indrag = false;
        public Form o_wintype;
        public ucpsubjects()
        {
            InitializeComponent();
            InitializeInterface(new Size(340, 400));
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
            this.e_nav_title.Text = "Subjects";
            this.Text = this.e_nav_title.Text;


        }
        public void InitializeUI()
        {
            UpdateSubjectList();

            this.BackColor = u_Stylesource.o_backcolor;

            this.e_but_subjects_add.BackColor = u_Stylesource.o_backcolor;
            this.e_but_subjects_rename.BackColor = u_Stylesource.o_backcolor;
            this.e_but_subjects_remove.BackColor = u_Stylesource.o_backcolor;

            this.e_but_subjects_add.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_subjects_rename.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_subjects_remove.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_disp_subjects.ForeColor = u_Stylesource.o_backcolor;
            this.e_disp_subjects.BackColor = u_Stylesource.o_defaultcolor;

            this.e_disp_subjects.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_disp_subjects.BackColor = u_Stylesource.o_formcolor;

            this.e_inp_subjects.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_inp_subjects.BackColor = u_Stylesource.o_formcolor;

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

        private void UpdateSubjectList()
        {
            if (u_Project.subjects.s_subjects != null)
            {
                ImageList o_list = new ImageList();

                e_disp_subjects.Items.Clear();
                for (int i_index = 0; i_index < u_Project.subjects.s_subjects.Length; i_index++)
                {
                    e_disp_subjects.Items.Add(u_Project.subjects.s_subjects[i_index], i_index);
                    o_list.Images.Add(User.Properties.Resources.folder);
                }
                e_disp_subjects.SmallImageList = o_list;
            }
        }
        void event_subject(object o_sender, EventArgs o_eventargs)
        {
            e_inp_subjects.Text = u_Stringmanager.Subjectcorrect(e_inp_subjects.Text);
            e_inp_subjects.SelectionStart = e_inp_subjects.TextLength;
        }
        void sub_add(object o_sender, EventArgs o_eventargs)
        {
            string s_subject = u_Stringmanager.Subjectcorrect(e_inp_subjects.Text);
            if (s_subject != null && s_subject.Length >= 1)
            {
                addsubject(s_subject);

                UpdateSubjectList();

                u_Manager.SaveSubjects();
                u_Manager.RefreshProject();
            }

        }
        void sub_rename(object o_sender, EventArgs o_eventargs)
        {

            string s_subject = u_Stringmanager.Subjectcorrect(e_inp_subjects.Text);
            if (s_subject != null && s_subject.Length >= 4)
            {
                if (e_disp_subjects.SelectedItems.Count > 0)
                {
                    renamesubject(e_disp_subjects.SelectedItems[0].ImageIndex, s_subject);

                    UpdateSubjectList();

                    u_Manager.SaveSubjects();
                    u_Manager.RefreshProject();
                }
            }

        }
        void sub_remove(object o_sender, EventArgs o_eventargs)
        {

            if (u_Project.subjects.s_subjects.Length > 1)
            {
                if (e_disp_subjects.SelectedItems.Count > 0)
                {
                    removesubject(e_disp_subjects.SelectedItems[0].ImageIndex);
                }
                UpdateSubjectList();

                u_Manager.SaveSubjects();
                u_Manager.RefreshProject();
            }

        }
        public static void addsubject(string s_subject)
        {
            string[] s_subjects = new string[u_Project.subjects.s_subjects.Length + 1];
            for (int i_index = 0; i_index < u_Project.subjects.s_subjects.Length; i_index++)
            {
                s_subjects[i_index] = u_Project.subjects.s_subjects[i_index];
            }
            s_subjects[u_Project.subjects.s_subjects.Length] = s_subject;
            u_Project.subjects.s_subjects = new string[s_subjects.Length];
            u_Project.subjects.s_subjects = s_subjects;
        }

        public static void removesubject(int i_pos)
        {
            string[] s_subjects = new string[u_Project.subjects.s_subjects.Length - 1];
            for (int i_index = 0, i_subindex = 0; i_index < u_Project.subjects.s_subjects.Length; i_index++, i_subindex++)
            {
                if (i_index == i_pos)
                {
                    i_subindex--;
                    continue;
                }
                s_subjects[i_subindex] = u_Project.subjects.s_subjects[i_index];
            }
            u_Project.subjects.s_subjects = new string[s_subjects.Length];
            u_Project.subjects.s_subjects = s_subjects;
        }

        public static void renamesubject(int i_pos, string s_subject)
        {
            u_Project.subjects.s_subjects[i_pos] = s_subject;
        }

    }
}
