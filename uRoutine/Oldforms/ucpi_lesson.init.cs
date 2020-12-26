using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User;
using User.Forms;
using User.Messager;
using Source;
using Source.Routines;
using Source.Style;

namespace User.Forms
{
    public partial class ucpi_lesson
    {
        public void InitializeInterface()
        {
            this.e_nav.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_close.BackColor = u_Stylesource.o_dragcolor;

            this.e_div.BackColor = u_Stylesource.o_bordercolor;

            this.BackColor = u_Stylesource.o_backcolor;

            this.e_info_date.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_add.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_rename.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_remove.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_append.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_folder.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_append.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_deletelesson.BackColor = u_Stylesource.o_backcolor;

            this.e_inp_topic.BackColor = u_Stylesource.o_dragcolor;
            this.e_inp_topic.ForeColor = u_Stylesource.o_bordercolor;



            this.e_info_date.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_tree.BackColor = u_Stylesource.o_backcolor;
            this.e_tree.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_inp_file.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_inp_file.BackColor = u_Stylesource.o_formcolor;

            this.e_div_five.BackColor = u_Stylesource.o_defaultcolor;
        }

        public void InitializeLesson()
        {
            SetUi();
            SetTree();
        }
        public void SetUi()
        {
            s_topic_pref = u_Project.lesson.o_loadedlesson.s_topic;
            this.e_inp_topic.Text = u_Project.lesson.o_loadedlesson.s_topic;

            this.e_info_date.Text = u_Stringmanager.ToReadDate(u_Project.lesson.o_loadedlesson.o_date) +"  "+ u_Project.lesson.o_loadedlesson.s_subject;

        }
    }
}
