using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source;
using Source.Routines;
using Source.Style;
using User.Messager;

namespace User.Action
{
    public partial class ucpboard : Form
    {


        public int i_exitcode;
        public bool b_close = false;


        ucpsettings o_generall;
        ucpsubjects o_subjects;
        ucpopen o_open;
        ucpappointments o_appointments;
        ucpcreate o_create ;
        ucpexport o_export ;

        public ucpboard(string[] s_args)
        {
            InitializeComponent();

            u_Manager.ReadVersionFile();
            u_Manager.StartProject();
            u_Manager.o_board=this;

            InitializeUI();

            InitializeInterface(new Size(70, 250));
            HideLesson();
        }

        void InitializeInterface(Size o_size)
        {


            this.MinimumSize = new Size(o_size.Width+2, o_size.Height + e_nav.Size.Height);
            this.Size = new Size(o_size.Width+2, o_size.Height + e_nav.Size.Height);
            this.e_hider.Location = new Point(1, 1 + e_nav.Size.Height);
            this.e_nav.Location = new Point(1, 1);
            this.e_nav.Size = new Size(o_size.Width, e_nav.Size.Height);
            this.e_nav_logo.Location = new Point(e_nav_logo.Location.X, 1);


            this.Text = "Board";


        }
        public void InitializeUI()
        {
            this.BackColor = u_Stylesource.o_bordercolor;
            this.e_nav.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_logo.BackColor = u_Stylesource.o_dragcolor;

            this.e_hider.BackColor = u_Stylesource.o_backcolor;
            this.BackColor = u_Stylesource.o_backcolor;

            this.e_inp_topic.BackColor = u_Stylesource.o_dragcolor;
            this.e_inp_topic.ForeColor = u_Stylesource.o_bordercolor;


        }

        void event_focus(object sender, EventArgs e)
        {
            this.BackColor = u_Stylesource.o_bordercolor;
        }
        void event_unfocus(object sender, EventArgs e)
        {
            this.BackColor = u_Stylesource.o_clickcolor;

        }

        void event_edittopic(object o_sender, EventArgs o_eventargs)
        {

        }

        const int i_Offset = 350;
        public void ShowLesson()
        {
            this.e_inp_topic.Text = u_Project.lesson.o_loadedlesson.s_topic;
            e_inp_topic.Show();
            o_lesson.InitializeLesson();
            o_lesson.Location = new Point(1, 1+ e_nav.Size.Height);
            o_lesson.Size = new Size(i_Offset, 250);
            o_lesson.Show();
            
            InitializeInterface(new Size(i_Offset + 70,250));

            Rectangle o_res = Screen.PrimaryScreen.WorkingArea;
            Point o_pos = new Point(o_res.Width - this.Width, o_res.Height - this.Height);
            this.e_hider.Location = new Point(this.Size.Width - 1 - this.e_hider.Width, this.e_hider.Location.Y);
            this.Location = o_pos;


        }
        public void HideLesson()
        {
            e_inp_topic.Hide();
            o_lesson.Hide();
            InitializeInterface(new Size(70, 250));
            this.e_hider.Location = new Point(this.Size.Width - 1 - this.e_hider.Width, this.e_hider.Location.Y);


            Rectangle o_res = Screen.PrimaryScreen.WorkingArea;
            Point o_pos = new Point(o_res.Width - this.Width, o_res.Height - this.Height);
            this.Location = o_pos;
        }

        void click_general(object o_sender, EventArgs o_eventargs)
        {

            if (o_generall == null)
            {
                o_generall = new ucpsettings();
                o_generall.Show();

            }
            else
            {
                o_generall.Show();
            }
        }

        void click_manager(object o_sender, EventArgs o_eventargs)
        {
            if (u_Project.b_hooked)
            {
                if (o_subjects == null)
                {
                    o_subjects = new ucpsubjects();
                    o_subjects.Show();

                }
                else
                {
                    o_subjects.Show();
                }
            }
        }
        void click_all(object o_sender, EventArgs o_eventargs)
        {
            if (u_Project.b_running)
            {

                if (u_Project.b_allowsedit)
                {
                    click_create(o_sender, o_eventargs);
                }
                else
                {

                    if (o_open == null)
                    {
                        o_open = new ucpopen();
                        o_open.Show();

                    }
                    else
                    {
                        o_open.Show();
                    }
 
                }
            }
        }
        void click_share(object o_sender, EventArgs o_eventargs)
        {
            if (u_Project.b_running)
            {
                if (o_export == null)
                {
                    o_export = new ucpexport();
                    o_export.Show();

                }
                else
                {
                    o_export.Show();
                }

            }
        }

        void click_create(object o_sender, EventArgs o_eventargs)
        {

            if (u_Project.b_running)
            {

                if (o_create == null)
                {
                    o_create = new ucpcreate();
                    o_create.Show();

                }
                else
                {
                    o_create.Show();
                }

            }
        }

        void click_appointment(object o_sender, EventArgs o_eventargs)
        {
            if (u_Project.b_running)
            {

                if (o_appointments == null)
                {
                    o_appointments = new ucpappointments();
                    o_appointments.Show();

                }
                else
                {
                    o_appointments.Show();
                }


            }
        }

        private void e_nav_logo_Click(object sender, EventArgs e)
        {
            if (u_Project.lesson.b_access)
            {
                u_Project.lesson.b_access = false;
                HideLesson();
            }
            else
            {
                this.Close();
            }
        }
        string s_topic_pref;


        private void event_entertext(object sender, KeyEventArgs o_Stoke)
        {

            if (o_Stoke.KeyCode == Keys.Enter)
            {
                s_topic_pref = u_Project.lesson.o_loadedlesson.s_topic;


                if (e_inp_topic.Text.Length == 0)
                {
                    e_inp_topic.Text = s_topic_pref;
                    return;
                }

                e_inp_topic.Text = u_Stringmanager.Topiccorrect(e_inp_topic.Text);
                e_inp_topic.SelectionStart = e_inp_topic.TextLength;

                if (e_inp_topic.Text != null)
                {
                    u_Project.lesson.o_loadedlesson.s_topic = e_inp_topic.Text;
                    u_LessonRoutines.lesson.Save(u_Project.lesson.o_loadedlesson);
                }
                o_Stoke.Handled = true;
                o_Stoke.SuppressKeyPress = true;
            }
        }
    }
}
