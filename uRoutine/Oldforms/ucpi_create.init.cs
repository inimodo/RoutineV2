using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Source.Style;
using Source;
using System.Windows.Forms;
using System.Drawing;

namespace User.Forms
{
    public partial class ucpi_create
    {

        public void InitializeInterface()
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

            this.e_tog_createdef.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_tog_createdef.BackColor = u_Stylesource.o_backcolor;
            this.e_tog_project.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_tog_project.BackColor = u_Stylesource.o_backcolor;

            this.e_disp_fileending.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_disp_fileending.BackColor = u_Stylesource.o_formcolor;

            this.e_inp_fileending.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_inp_fileending.BackColor = u_Stylesource.o_formcolor;

            this.e_info_topic.ForeColor = u_Stylesource.o_headercolor;
            this.e_info_settings.ForeColor = u_Stylesource.o_headercolor;
            this.e_info_subject_one.ForeColor = u_Stylesource.o_headercolor;
            this.e_info_fileend.ForeColor = u_Stylesource.o_headercolor;
            this.e_info_filetypes.ForeColor = u_Stylesource.o_headercolor;

            this.e_info_topic.BackColor = u_Stylesource.o_backcolor;
            this.e_info_settings.BackColor = u_Stylesource.o_backcolor;
            this.e_info_subject_one.BackColor = u_Stylesource.o_backcolor;
            this.e_info_fileend.BackColor = u_Stylesource.o_backcolor;
            this.e_info_filetypes.BackColor = u_Stylesource.o_backcolor;

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
    }
}
