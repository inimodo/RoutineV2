using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Source;
using Source.Routines;


namespace User.Forms
{
    public partial class ucpi_general
    {
        partial void select_project(object o_sender, EventArgs o_eventargs)
        {
            string s_path = GetPath();
            if (s_path != null) {
                u_Project.software.s_projectfolder = s_path;
                this.e_inp_loadedp.Text = s_path;
                u_Project.software.b_ploaded = true;
                u_Manager.SaveProjectCfg();
                u_Manager.LoadProject();

            }
        }
        partial void create_project(object o_sender, EventArgs o_eventargs)
        {
            string s_path = GetPath();
            if (s_path != null)
            {
                u_Project.software.s_projectfolder = s_path;
                u_Manager.Create(s_path);
                this.e_inp_loadedp.Text = s_path;
                u_Project.software.b_ploaded = true;
                u_Manager.SaveProjectCfg();
                u_Manager.LoadProject();


            }
        }
        partial void loadout_project(object o_sender, EventArgs o_eventargs)
        {
            u_Project.software.s_projectfolder = "";
            u_Project.software.b_ploaded = false;
            u_Manager.SaveProjectCfg();
            u_Manager.LoadProject();
            

        }
        partial void sel_autostart(object o_sender, EventArgs o_eventargs)
        {
            u_Project.software.b_autostart = e_tog_autostart.Checked;
            u_Manager.SaveProjectCfg();


        }
        partial void sel_smartstart(object o_sender, EventArgs o_eventargs)
        {
            u_Project.software.b_smartstart = e_tog_smartstart.Checked;
            u_Manager.SaveProjectCfg();

        }
    }
}
