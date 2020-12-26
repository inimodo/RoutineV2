using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

using System.IO;
using Source;
using Source.Routines;


namespace User.Forms
{
    public partial class ucpi_share
    {
        private string s_hash, s_importpath, s_importname, s_subject = "none";

        public void SetUI()
        {
            if (u_Project.b_running && u_Project.lesson.o_loadedlesson.s_hash != null)
            {
                s_hash = u_Project.lesson.o_loadedlesson.s_hash;

                e_out_topic.Text = u_Project.lesson.o_loadedlesson.s_topic;            
                e_out_files.Text = u_Stringsource.s_confiles.Replace("?", u_Project.lesson.o_loadedlesson.s_files.Length.ToString());
                e_out_hashcode.Text = s_hash;
                e_out_subject.Text = u_Project.lesson.o_loadedlesson.s_subject;
                e_out_date.Text = u_Stringmanager.ToReadDate(u_Project.lesson.o_loadedlesson.o_date);
            }
        }
        partial void click_load(object o_sender, EventArgs o_eventargs)
        {
            if (u_Manager.LoadOpenLesson(e_inp_hashcode.Text))
            {
                SetUI();
            }
        }
        partial void click_searchcode(object o_sender, EventArgs o_eventargs)
        {
            OpenAll();
        }

        public bool SelectZip()
        {
            OpenFileDialog o_openfile = new OpenFileDialog();
            o_openfile.Multiselect = false;

            o_openfile.Filter = u_Stringsource.s_filefilter_zip;
            o_openfile.Title = u_Stringsource.s_appname + " | " + u_Stringsource.s_openfile;

            if (o_openfile.ShowDialog() == DialogResult.OK)
            {
                s_importpath = o_openfile.FileName;
                s_importname = o_openfile.SafeFileName;
                return true;
            }
            return false;
        }

        public string SaveZip()
        {
            SaveFileDialog o_openfile = new SaveFileDialog();

            o_openfile.Filter = u_Stringsource.s_filefilter_zip;
            o_openfile.Title = u_Stringsource.s_appname + " | " + u_Stringsource.s_createfile;

            if (o_openfile.ShowDialog() == DialogResult.OK)
            {
                return o_openfile.FileName;
            }
            return null;
        }

        partial void click_search(object o_sender, EventArgs o_eventargs)
        {
            SelectZip();
            e_inp_path.Text = s_importpath;
        }

        partial void click_import(object o_sender, EventArgs o_eventargs)
        {
            if (e_sel_subject.SelectedIndex >= 0)
            {
                s_subject = u_Project.subjects.s_subjects[e_sel_subject.SelectedIndex];

                if (File.Exists(s_importpath))
                {
                    string s_exportpath = u_Project.software.s_projectfolder + u_LoadRoutines.s_sp + u_Vars.s_resources + u_LoadRoutines.s_sp + u_Vars.s_temp;

                    try
                    {
                        ZipFile.ExtractToDirectory(s_importpath, s_exportpath);
                    }
                    catch
                    {
                        return;
                    }
                    u_Confighandler.configset(s_exportpath + u_LoadRoutines.s_sp + u_Vars.lesson.info.s_contcfg);
                    string s_getdate = u_Confighandler.readstring(u_Vars.lesson.info.s_cfgreg, u_Vars.lesson.info.s_cfg_date);
                    DateTime o_date = u_Stringmanager.Datefromstring(s_getdate);

                    string s_hash = u_LessonRoutines.lesson.HashGen(s_subject, o_date);
                    u_Confighandler.writestring(u_Vars.lesson.info.s_cfgreg, u_Vars.lesson.info.s_cfg_subject, s_subject);
                    string s_datapath = u_Project.software.s_projectfolder + u_LoadRoutines.s_sp + u_Vars.s_data + u_LoadRoutines.s_sp + s_hash;

                    if (!Directory.Exists(s_datapath))
                    {
                        Directory.Move(s_exportpath, s_datapath);
                        u_Manager.AddHash(s_hash);
                    }
                    else
                    {
                        Directory.Delete(s_exportpath, true);
                    }
                    OpenAll();
                }
            }
        }
        partial void click_export(object o_sender, EventArgs o_eventargs)
        {
            string s_filepath = SaveZip();
            if (s_filepath != null)
            {
                string s_exportpath = u_Project.software.s_projectfolder + u_LoadRoutines.s_sp + u_Vars.s_data + u_LoadRoutines.s_sp + s_hash;

                ZipFile.CreateFromDirectory(s_exportpath, s_filepath, CompressionLevel.Optimal, false);
            }
        }

        private void OpenAll()
        {
            this.Hide();
        }
    }
}
