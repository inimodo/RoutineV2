using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source;
using Source.Routines;
using User;


namespace User.Forms
{
    public partial class ucpi_create
    {
        private  string PathFile(string s_filend)
        {
            return u_Project.software.s_projectfolder +  @"\" + u_Vars.s_resources + @"\" + u_Vars.s_prefabs + @"\" + s_filend + "." + s_filend;
        }


        private void UpdatePrefabs()
        {
            u_Manager.ManagePrefabFiles();

            e_disp_fileending.Items.Clear();
            for (int i_index = 0; i_index < u_Project.prefab.o_current.s_fileendings.Length; i_index++)
            {
                e_disp_fileending.Items.Add(u_Project.prefab.o_current.s_fileendings[i_index], i_index);
            }

            ImageList o_list = new ImageList();
            for (int i_index = 0; i_index < u_Project.prefab.o_current.s_fileendings.Length; i_index++)
            {
                Icon o_fileico = SystemIcons.Error;
                o_fileico = Icon.ExtractAssociatedIcon(PathFile(u_Project.prefab.o_current.s_fileendings[i_index]));
                o_list.Images.Add(o_fileico);

            }

            e_disp_fileending.LargeImageList = o_list;
            e_disp_fileending.SmallImageList = o_list;
        }
        partial void event_changeitem(object o_sender, EventArgs o_eventargs)
        {
            e_sel_subject.SelectedIndex = e_sel_subject.SelectedIndex;
        }
        partial void click_fe_sel(object o_sender, EventArgs o_eventargs)
        {
            if(e_sel_subject.SelectedIndex == -1) { return;  }

            u_Project.prefab.s_subject = u_Project.subjects.s_subjects[e_sel_subject.SelectedIndex];
            u_Project.prefab.o_current = u_Manager.LoadPrefab(u_Project.prefab.s_subject);


            UpdatePrefabs();
        }
        partial void click_fe_add(object o_sender, EventArgs o_eventargs)
        {

            string s_filend = u_Stringmanager.Filendcorrect(e_inp_fileending.Text);
            if (s_filend != "" && s_filend != null)
            {
                if (u_Manager.ValidPrefabFilend(s_filend,u_Project.prefab.o_current.s_fileendings))
                {
                    u_Manager.AddPrefabFilend(s_filend, ref u_Project.prefab.o_current.s_fileendings);

                    u_Manager.SavePrefab(u_Project.prefab.s_subject, u_Project.prefab.o_current);

                    UpdatePrefabs();

                }
            }
        }
        partial void click_fe_remove(object o_sender, EventArgs o_eventargs)
        {

            if (e_disp_fileending.FocusedItem != null)
            {

                if ((u_Project.prefab.o_current.s_fileendings.Length - 1) == 0)
                {
                    u_Manager.AddPrefabFilend(u_Vars.csubject.prefabs.s_defaultfe, ref u_Project.prefab.o_current.s_fileendings);
                }

                u_Manager.RemovePrefabFilend(e_disp_fileending.FocusedItem.Index, ref u_Project.prefab.o_current.s_fileendings);

                u_Manager.SavePrefab(u_Project.prefab.s_subject, u_Project.prefab.o_current);

                UpdatePrefabs();
            }
        }
        partial void click_fe(object o_sender, EventArgs o_eventargs)
        {
            if (e_sel_subject.SelectedIndex == -1) { return; }
            string s_topic = u_Stringmanager.Topiccorrect( e_inp_topic.Text);

            if(s_topic == null) { return; }
            string s_subject = u_Project.subjects.s_subjects[e_sel_subject.SelectedIndex];
            s_Prefab o_prefab = new s_Prefab();

            if (e_tog_createdef.Checked) {
                o_prefab =u_Manager.LoadPrefab(s_subject);
            }
            else
            {
                o_prefab.s_fileendings = new string[1];
                o_prefab.s_fileendings[0] = u_Vars.csubject.prefabs.s_defaultfe;
            }

            s_Lesson o_lesson = new s_Lesson();

            o_lesson.o_date = DateTime.Now;
            o_lesson.s_subject = s_subject;
            o_lesson.s_topic = s_topic;
            o_lesson.b_project = e_tog_project.Checked;

            string s_hash = u_Manager.CreateLesson(o_lesson, o_prefab);
            if(s_hash == null)
            {
                return;
            }
            u_Manager.OpenLesson(s_hash);
            if (e_tog_createdef.Checked)
            {
                for (int i_index = 0; i_index < u_Project.lesson.o_loadedlesson.s_files.Length; i_index++)
                {
                    string s_file = u_Project.software.s_projectfolder +
                        u_LoadRoutines.s_sp +
                        u_Vars.s_data +
                        u_LoadRoutines.s_sp +
                        u_Project.lesson.o_loadedlesson.s_hash +
                        u_LoadRoutines.s_sp +
                        u_Vars.s_files +
                        u_LoadRoutines.s_sp +
                        u_Project.lesson.o_loadedlesson.s_files[i_index];
                }
            }

            u_Manager.RefreshProject();
        }
    }
}
