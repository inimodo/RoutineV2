using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source.Style;
using Source;
using Source.Routines;
using User;

namespace User.Action
{
    public partial class ucpcreate : Form
    {
        Point p_relative;
        bool b_indrag = false;
        public ucpcreate()
        {
            InitializeComponent();
            InitializeInterface(new Size(275, 200));
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

        void event_close(object sender, EventArgs e)
        {
            this.Hide();
        }

        void event_focus(object sender, EventArgs e)
        {
            this.BackColor = u_Stylesource.o_bordercolor;
        }
        void event_unfocus(object sender, EventArgs e)
        {
            this.BackColor = u_Stylesource.o_clickcolor;
            this.Hide();

        }

        public void InitializeUI()
        {
            UpdateList();

            this.BackColor = u_Stylesource.o_backcolor;

            this.e_inp_topic.BackColor = u_Stylesource.o_formcolor;
            this.e_inp_topic.BackgroundImage = User.Properties.Resources.noise;
            this.e_inp_topic.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_sel_subject.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_sel_subject.BackColor = u_Stylesource.o_formcolor;
            this.e_sel_subject.BackColor = u_Stylesource.o_formcolor;
            this.e_sel_subject.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_but_create.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_create.BackColor = u_Stylesource.o_backcolor;
            this.e_inp_fileending_add.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_inp_fileending_add.BackColor = u_Stylesource.o_backcolor;
            this.e_inp_fileending_remove.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_inp_fileending_remove.BackColor = u_Stylesource.o_backcolor;



            this.e_disp_fileending.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_disp_fileending.BackColor = u_Stylesource.o_formcolor;

            this.e_inp_fileending.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_inp_fileending.BackColor = u_Stylesource.o_formcolor;


            this.e_div_two.BackColor = u_Stylesource.o_defaultcolor;
            this.e_div_three.BackColor = u_Stylesource.o_defaultcolor;
            this.e_div_five.BackColor = u_Stylesource.o_defaultcolor;
            this.e_div_six.BackColor = u_Stylesource.o_defaultcolor;



        }
        public void UpdateList()
        {
            if (u_Project.b_running)
            {
                this.e_sel_subject.Items.Clear();
                this.e_sel_subject.Items.AddRange(u_Project.subjects.s_subjects);
                this.e_sel_subject.SelectedIndex = 0;
                this.e_sel_subject.Refresh();

                UpdatePrefabs();
            }
        }

        private string PathFile(string s_filend)
        {
            return u_Project.software.s_projectfolder + @"\" + u_Vars.s_resources + @"\" + u_Vars.s_prefabs + @"\" + s_filend + "." + s_filend;
        }


        private void UpdatePrefabs()
        {
            u_Manager.ManagePrefabFiles();

            e_disp_fileending.Items.Clear();
            for (int i_index = 0; i_index < u_Project.prefab.o_current.s_fileendings.Length; i_index++)
            {
                e_disp_fileending.Items.Add(u_Project.prefab.o_current.s_fileendings[i_index], i_index);
            }

            ImageList o_list = new ImageList();
            for (int i_index = 0; i_index < u_Project.prefab.o_current.s_fileendings.Length; i_index++)
            {
                Icon o_fileico = SystemIcons.Error;
                o_fileico = Icon.ExtractAssociatedIcon(PathFile(u_Project.prefab.o_current.s_fileendings[i_index]));
                o_list.Images.Add(o_fileico);

            }

            e_disp_fileending.LargeImageList = o_list;
            e_disp_fileending.SmallImageList = o_list;
        }
         void event_changeitem(object o_sender, EventArgs o_eventargs)
        {
            e_sel_subject.SelectedIndex = e_sel_subject.SelectedIndex;
        }
         void click_fe_sel(object o_sender, EventArgs o_eventargs)
        {
            if (e_sel_subject.SelectedIndex == -1) { return; }

            u_Project.prefab.s_subject = u_Project.subjects.s_subjects[e_sel_subject.SelectedIndex];
            u_Project.prefab.o_current = u_Manager.LoadPrefab(u_Project.prefab.s_subject);


            UpdatePrefabs();
        }
         void click_fe_add(object o_sender, EventArgs o_eventargs)
        {

            string s_filend = u_Stringmanager.Filendcorrect(e_inp_fileending.Text);
            if (s_filend != "" && s_filend != null)
            {
                if (u_Manager.ValidPrefabFilend(s_filend, u_Project.prefab.o_current.s_fileendings))
                {
                    u_Manager.AddPrefabFilend(s_filend, ref u_Project.prefab.o_current.s_fileendings);

                    u_Manager.SavePrefab(u_Project.prefab.s_subject, u_Project.prefab.o_current);

                    UpdatePrefabs();

                }
            }
        }
         void click_fe_remove(object o_sender, EventArgs o_eventargs)
        {

            if (e_disp_fileending.FocusedItem != null)
            {

                if ((u_Project.prefab.o_current.s_fileendings.Length - 1) == 0)
                {
                    u_Manager.AddPrefabFilend(u_Vars.csubject.prefabs.s_defaultfe, ref u_Project.prefab.o_current.s_fileendings);
                }

                u_Manager.RemovePrefabFilend(e_disp_fileending.FocusedItem.Index, ref u_Project.prefab.o_current.s_fileendings);

                u_Manager.SavePrefab(u_Project.prefab.s_subject, u_Project.prefab.o_current);

                UpdatePrefabs();
            }
        }
         void click_fe(object o_sender, EventArgs o_eventargs)
        {
            if (e_sel_subject.SelectedIndex == -1) { return; }
            string s_topic = u_Stringmanager.Topiccorrect(e_inp_topic.Text);

            if (s_topic == null) { return; }
            string s_subject = u_Project.subjects.s_subjects[e_sel_subject.SelectedIndex];
            s_Prefab o_prefab = new s_Prefab();


            o_prefab = u_Manager.LoadPrefab(s_subject);

            s_Lesson o_lesson = new s_Lesson();

            o_lesson.o_date = DateTime.Now;
            o_lesson.s_subject = s_subject;
            o_lesson.s_topic = s_topic;
            o_lesson.b_project = true;

            string s_hash = u_Manager.CreateLesson(o_lesson, o_prefab);
            if (s_hash == null)
            {
                return;
            }
            u_Manager.OpenLesson(s_hash);

            for (int i_index = 0; i_index < u_Project.lesson.o_loadedlesson.s_files.Length; i_index++)
            {
                string s_file = u_Project.software.s_projectfolder +
                    u_LoadRoutines.s_sp +
                    u_Vars.s_data +
                    u_LoadRoutines.s_sp +
                    u_Project.lesson.o_loadedlesson.s_hash +
                    u_LoadRoutines.s_sp +
                    u_Vars.s_files +
                    u_LoadRoutines.s_sp +
                    u_Project.lesson.o_loadedlesson.s_files[i_index];
            }
            

            u_Manager.RefreshProject();
            this.Hide();
        }


    }
}
