using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Style;
namespace User.Forms
{
    public partial class ucpi_share
    {
        public void InitializeInterface()
        {
            if (u_Project.b_running)
            {
                this.e_sel_subject.Items.Clear();
                this.e_sel_subject.Items.AddRange(u_Project.subjects.s_subjects);
            }
            this.BackColor = u_Stylesource.o_backcolor;
            this.e_info_hashcode.ForeColor = u_Stylesource.o_headercolor;
            this.e_info_hashcode.BackColor = u_Stylesource.o_backcolor;
            this.e_info_lesson.ForeColor = u_Stylesource.o_headercolor;
            this.e_info_lesson.BackColor = u_Stylesource.o_backcolor;
            this.e_info_filepath.ForeColor = u_Stylesource.o_headercolor;
            this.e_info_filepath.BackColor = u_Stylesource.o_backcolor;

            this.e_infopanel.BackColor = u_Stylesource.o_formcolor;

            this.e_out_topic.BackColor = u_Stylesource.o_formcolor;
            this.e_out_files.BackColor = u_Stylesource.o_formcolor;
            this.e_out_hashcode.BackColor = u_Stylesource.o_formcolor;
            this.e_out_date.BackColor = u_Stylesource.o_formcolor;
            this.e_out_subject.BackColor = u_Stylesource.o_formcolor;
            this.e_info_subject.BackColor = u_Stylesource.o_formcolor;
            this.e_info_date.BackColor = u_Stylesource.o_formcolor;

            this.e_out_topic.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_out_files.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_out_hashcode.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_out_date.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_out_subject.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_info_subject.ForeColor = u_Stylesource.o_headercolor;
            this.e_info_date.ForeColor = u_Stylesource.o_headercolor;

            this.e_but_searchhash.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_export.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_search.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_import.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_sel_subject.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_but_searchhash.BackColor = u_Stylesource.o_backcolor;
            this.e_but_export.BackColor = u_Stylesource.o_backcolor;
            this.e_but_search.BackColor = u_Stylesource.o_backcolor;
            this.e_but_import.BackColor = u_Stylesource.o_backcolor;
            this.e_sel_subject.BackColor = u_Stylesource.o_backcolor;

            this.e_div_two.BackColor = u_Stylesource.o_defaultcolor;
            this.e_div_four.BackColor = u_Stylesource.o_defaultcolor;
            this.e_div_five.BackColor = u_Stylesource.o_defaultcolor;

            this.e_inp_hashcode.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_inp_path.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_inp_hashcode.BackColor = u_Stylesource.o_formcolor;
            this.e_inp_path.BackColor = u_Stylesource.o_formcolor;
        }
        public void UpdateList()
        {
            if (u_Project.b_running)
            {
                this.e_sel_subject.Items.Clear();
                this.e_sel_subject.Items.AddRange(u_Project.subjects.s_subjects);
            }
            SetUI();
        }
    }
}
