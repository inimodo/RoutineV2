using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Source.Routines;
using Source.Style;
using Source;
using User.Messager;
using System.Drawing;

namespace User.Forms
{
    public partial class ucpi_manager
    {
        public void InitializeInterface() {
            e_inp_grade.Text = u_Stringmanager.Gradecorrect(u_Project.pinfo.s_grade);


            UpdateSubjectList();

            

            this.BackColor = u_Stylesource.o_backcolor;
            this.e_info_grade.BackColor = u_Stylesource.o_backcolor;
            this.e_but_grade.BackColor = u_Stylesource.o_backcolor;
            this.e_info_subjects.BackColor = u_Stylesource.o_backcolor;
            this.e_info_subject.BackColor = u_Stylesource.o_backcolor;

            this.e_but_subjects_add.BackColor = u_Stylesource.o_backcolor;
            this.e_but_subjects_rename.BackColor = u_Stylesource.o_backcolor;
            this.e_but_subjects_remove.BackColor = u_Stylesource.o_backcolor;


            this.e_but_grade.ForeColor = u_Stylesource.o_defaultcolor;


            this.e_info_subjects.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_info_subject.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_info_grade.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_but_subjects_add.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_subjects_rename.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_subjects_remove.ForeColor = u_Stylesource.o_defaultcolor;


            this.e_disp_subjects.ForeColor = u_Stylesource.o_backcolor;
            this.e_disp_subjects.BackColor = u_Stylesource.o_defaultcolor;



            this.e_disp_subjects.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_disp_subjects.BackColor = u_Stylesource.o_formcolor;

            this.e_inp_subjects.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_inp_subjects.BackColor = u_Stylesource.o_formcolor;

            this.e_inp_grade.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_inp_grade.BackColor = u_Stylesource.o_formcolor;



            this.e_div_two.BackColor = u_Stylesource.o_defaultcolor;
            this.e_div_three.BackColor = u_Stylesource.o_defaultcolor;

            this.e_div_six.BackColor = u_Stylesource.o_defaultcolor;
        }
    }
}
