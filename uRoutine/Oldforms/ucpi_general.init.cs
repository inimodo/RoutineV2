using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Source;
using Source.Style;

namespace User.Forms
{
    public partial class ucpi_general
    {
        public void InitializeInterface()
        {
  

            this.e_inp_loadedp.Text = u_Project.software.s_projectfolder;
            this.e_tog_autostart.Checked = u_Project.software.b_autostart;
            this.e_tog_smartstart.Checked = u_Project.software.b_smartstart;

            this.BackColor = u_Stylesource.o_backcolor;
           

            this.e_but_loadedp.BackColor = u_Stylesource.o_backcolor;
            this.e_but_cnewp.BackColor = u_Stylesource.o_backcolor;
            this.e_but_unloadp.BackColor = u_Stylesource.o_backcolor;
            this.e_info_cnewp.BackColor = u_Stylesource.o_backcolor;
            this.e_info_unloadp.BackColor = u_Stylesource.o_backcolor;
            this.e_info_autostart.BackColor = u_Stylesource.o_backcolor;
            this.e_info_smartstart.BackColor = u_Stylesource.o_backcolor;
            this.e_info_smartstart.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_tog_autostart.BackColor = u_Stylesource.o_backcolor;
            this.e_tog_smartstart.BackColor = u_Stylesource.o_backcolor;

            this.e_but_loadedp.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_cnewp.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_but_unloadp.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_tog_autostart.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_tog_smartstart.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_info_cnewp.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_info_unloadp.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_info_autostart.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_info_copyright.BackColor = u_Stylesource.o_backcolor;

            this.e_inp_loadedp.BackColor = u_Stylesource.o_formcolor;
            this.e_inp_loadedp.ForeColor = u_Stylesource.o_defaultcolor;

            this.e_div_four.BackColor = u_Stylesource.o_defaultcolor;

            this.e_info_infotext.BackColor = u_Stylesource.o_formcolor;
            this.e_info_infotext.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_info_copyright.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_info_version.BackColor = u_Stylesource.o_backcolor;
            this.e_info_version.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_info_version.Text = u_Project.s_version;
            UpdateLog();
        }

        public void UpdateLog()
        {
            e_info_infotext.Text = u_Errorhandler.s_output;
        }
    }
}
