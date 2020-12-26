using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Style;
namespace User.Forms
{
    public partial class ucpi_appointments
    {
        public void InitializeInterface()
        {
            UpdateList();

            this.BackColor = u_Stylesource.o_backcolor;

            this.e_div_two.BackColor = u_Stylesource.o_defaultcolor;
            this.e_div_three.BackColor = u_Stylesource.o_defaultcolor;
            this.e_div_five.BackColor = u_Stylesource.o_defaultcolor;

            this.e_but_save.BackColor = u_Stylesource.o_backcolor;
            this.e_but_save.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_info_subject.BackColor = u_Stylesource.o_backcolor;
            this.e_info_date.BackColor = u_Stylesource.o_backcolor;
            this.e_out_days.BackColor = u_Stylesource.o_backcolor;
            this.e_inp_addiontional.BackColor = u_Stylesource.o_formcolor;
            this.e_tog_ao.BackColor = u_Stylesource.o_backcolor;
            this.e_but_del.BackColor = u_Stylesource.o_backcolor;

            this.e_inp_date.BackColor = u_Stylesource.o_backcolor;
            this.e_sel_subject.BackColor = u_Stylesource.o_backcolor;


            this.e_info_subject.ForeColor = u_Stylesource.o_headercolor;

            this.e_info_date.ForeColor = u_Stylesource.o_headercolor;
            this.e_out_days.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_inp_addiontional.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_tog_ao.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_del.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_inp_date.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_sel_subject.ForeColor = u_Stylesource.o_defaultcolor;


            this.e_disp_homework.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_disp_homework.BackColor = u_Stylesource.o_formcolor;


        }
        public void UpdateList()
        {
            if (u_Project.b_running)
            {
                this.e_sel_subject.Items.Clear();
                this.e_sel_subject.Items.AddRange(u_Project.subjects.s_subjects);
            }
            LoadIn();
        }
    }
}
