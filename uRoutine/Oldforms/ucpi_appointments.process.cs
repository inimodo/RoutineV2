using Source;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source.Routines;
namespace User.Forms
{
    public partial class ucpi_appointments//25; 57
    {
        string s_lohash=""; 
        partial void event_sellect(object o_sender, EventArgs o_eventargs)
        {
            if (e_disp_homework.SelectedItems.Count > 0)
            {
                LoadOut(u_Project.appointments.s_appoints[e_disp_homework.SelectedItems[0].ImageIndex]);
            }
        }
        partial void click_save(object o_sender, EventArgs o_eventargs)
        {
            if (s_lohash != null && s_lohash != "")
            {
                u_Manager.SaveAppointText(s_lohash, e_inp_addiontional.Text);
            }
        }
        partial void click_delete(object o_sender, EventArgs o_eventargs)
        {
            if (e_disp_homework.SelectedItems.Count > 0)
            {
                u_Manager.DeleteAppoint(u_Project.appointments.s_appoints[e_disp_homework.SelectedItems[0].ImageIndex]);
                LoadIn();
                u_Manager.SaveAppoint();

            }
        }
        partial void click_add(object o_sender, EventArgs o_eventargs)
        {
            if (e_sel_subject.SelectedIndex >= 0 )
            {
                s_Appointment o_temphw = new s_Appointment();
                o_temphw.s_text = "";
                o_temphw.s_subject = u_Project.subjects.s_subjects[e_sel_subject.SelectedIndex];
                o_temphw.o_date = e_inp_date.Value;
                u_Manager.CreateAppoint(o_temphw);
                u_Manager.SaveAppoint();

                LoadIn();
            }
        }
        partial void event_ao(object o_sender, EventArgs o_eventargs)
        {
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
            e_out_days.Text = (o_temphw.o_date.Subtract(DateTime.Now).Days + 1).ToString() + u_Stringsource.s_daysleft;
            e_out_addiontional.Text = o_temphw.s_subject;
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
                    o_fileico =  global::User.Properties.Resources.expired;
                }
                o_list.Images.Add(o_fileico);

                if (i_delta <= 0 && e_tog_ao.Checked)
                {
                    continue;

                }
                e_disp_homework.Items.Add("  " + o_current.s_subject + " | " + o_current.o_date.ToShortDateString(), i_index);
            }

            e_disp_homework.LargeImageList = o_list;
            e_disp_homework.SmallImageList = o_list;
        }
    }
}
