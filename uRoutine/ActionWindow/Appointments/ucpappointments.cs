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
    public partial class ucpappointments : Form
    {
        Point p_relative;
        bool b_indrag = false;
        public Form o_wintype;
        public ucpappointments()
        {
            InitializeComponent();
            InitializeInterface(new Size(280, 320));
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
            this.e_nav_title.Text = "Appointments";

        }
        public void InitializeUI()
        {
            if (u_Project.b_running)
            {
                LoadIn();
            }

            this.BackColor = u_Stylesource.o_backcolor;

            this.e_inp_addiontional.BackColor = u_Stylesource.o_formcolor;
            this.e_inp_addiontional.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_disp_homework.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_disp_homework.BackColor = u_Stylesource.o_formcolor;

            this.e_but_file_add.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_file_add.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_remove.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_file_remove.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_rename.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_file_rename.BackColor = u_Stylesource.o_backcolor;
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

        string s_lohash = "";
        void event_sellect(object o_sender, EventArgs o_eventargs)
        {
            if (e_disp_homework.SelectedItems.Count > 0)
            {
                LoadOut(u_Project.appointments.s_appoints[e_disp_homework.SelectedItems[0].ImageIndex]);
            }
        }
        void click_save(object o_sender, EventArgs o_eventargs)
        {
            if (s_lohash != null && s_lohash != "")
            {
                u_Manager.SaveAppointText(s_lohash, e_inp_addiontional.Text);
            }
        }
        void click_delete(object o_sender, EventArgs o_eventargs)
        {
            if (e_disp_homework.SelectedItems.Count > 0)
            {
                u_Manager.DeleteAppoint(u_Project.appointments.s_appoints[e_disp_homework.SelectedItems[0].ImageIndex]);
                LoadIn();
                u_Manager.SaveAppoint();

            }
        }
        void click_add(object o_sender, EventArgs o_eventargs)
        {
            ucpcreateappointment o_Actionwin = new ucpcreateappointment();
            o_Actionwin.ShowDialog();

                s_Appointment o_temphw = new s_Appointment();
                o_temphw.s_text = "";
                o_temphw.s_subject = u_Project.subjects.s_subjects[o_Actionwin.i_Subject];
                o_temphw.o_date = o_Actionwin.o_Due;
                u_Manager.CreateAppoint(o_temphw);
                u_Manager.SaveAppoint();

                LoadIn();
            
        }

        public void LoadOut(string s_hash)
        {
            s_Appointment o_temphw = new s_Appointment();
            o_temphw = u_Manager.GetAppoint(s_hash);
            if (o_temphw.s_hash == null)
            {
                return;
            }
            s_lohash = o_temphw.s_hash;
            e_inp_addiontional.Text = o_temphw.s_text;
        }
        public void LoadIn()
        {
            int i_delta;

            s_Appointment o_current;
            ImageList o_list = new ImageList();
            e_disp_homework.Items.Clear();
            for (int i_index = 0; i_index < u_Project.appointments.s_appoints.Length; i_index++)
            {
                o_current = u_Manager.GetAppoint(u_Project.appointments.s_appoints[i_index]);
                Bitmap o_fileico = global::User.Properties.Resources.none;

                i_delta = o_current.o_date.Subtract(DateTime.Now).Days + 1;
                if (i_delta <= 7 && i_delta > 0)
                {
                    o_fileico = global::User.Properties.Resources.urgend;
                }
                else
                if (i_delta <= 0)
                {
                    o_fileico = global::User.Properties.Resources.expired;
                }
                o_list.Images.Add(o_fileico);

                if (i_delta <= 0)
                {
                    continue;
                }
                
                e_disp_homework.Items.Add("  " + o_current.s_subject + " | " + o_current.o_date.ToShortDateString()+" | "+i_delta + u_Stringsource.s_daysleft, i_index);
            }

            e_disp_homework.LargeImageList = o_list;
            e_disp_homework.SmallImageList = o_list;
        }
    }
}
