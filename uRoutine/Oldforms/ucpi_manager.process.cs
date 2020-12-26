using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


using Source.Routines;
using Source.Style;
using Source;
using User.Messager;

namespace User.Forms
{
    public partial class ucpi_manager
    {
        partial void save_grade(object o_sender, EventArgs o_eventargs) {
            string s_input = e_inp_grade.Text;
            s_input = u_Stringmanager.Gradecorrect(s_input);
            if (s_input == "")
            {
                u_Message.Say(u_Stringsource.s_load_title[8], u_Stringsource.s_load_text[8],true);
            }
            else
            {
                u_Project.pinfo.s_grade = s_input;
                u_Manager.SaveProjectInfo();
            }
        }

        public string SelectTimetable()
        {
            OpenFileDialog o_openfile = new OpenFileDialog();
            string s_path = "";
            o_openfile.Multiselect = false;
            o_openfile.InitialDirectory = u_Project.software.s_projectfolder + u_LoadRoutines.s_sp + u_Vars.s_resources + u_LoadRoutines.s_sp + u_Vars.s_table;
            o_openfile.Filter = u_Stringsource.s_filefilter_ucp;
            o_openfile.Title = u_Stringsource.s_appname + " | " + u_Stringsource.s_openfile;

            if (o_openfile.ShowDialog() == DialogResult.OK)
            {
                s_path = o_openfile.FileName;
                if (s_path.Contains(u_Project.software.s_projectfolder + u_LoadRoutines.s_sp + u_Vars.s_resources + u_LoadRoutines.s_sp + u_Vars.s_table))
                {
                    return s_path;
                }
                else
                {
                    u_Message.Say(u_Stringsource.s_load_title[9], u_Stringsource.s_load_text[9],true);
                }
            }
            return null;
        }
        private void UpdateSubjectList()
        {
            if (u_Project.subjects.s_subjects != null)
            {
                ImageList o_list = new ImageList();

                e_disp_subjects.Items.Clear();
                for (int i_index = 0; i_index < u_Project.subjects.s_subjects.Length; i_index++)
                {
                    e_disp_subjects.Items.Add(u_Project.subjects.s_subjects[i_index],i_index);
                    o_list.Images.Add(User.Properties.Resources.folder);
                }
                e_disp_subjects.SmallImageList = o_list;
            }
        }
        partial void event_subject(object o_sender, EventArgs o_eventargs)
        {
            e_inp_subjects.Text = u_Stringmanager.Subjectcorrect(e_inp_subjects.Text);
            e_inp_subjects.SelectionStart = e_inp_subjects.TextLength;
        }
        partial void sub_add(object o_sender, EventArgs o_eventargs)
        {
            string s_subject = u_Stringmanager.Subjectcorrect(e_inp_subjects.Text);
            if (s_subject != null && s_subject.Length >= 1)
            {
                addsubject(s_subject);

                UpdateSubjectList();

                u_Manager.SaveSubjects();
                u_Manager.RefreshProject();
            }              
            
        }
        partial void sub_rename(object o_sender, EventArgs o_eventargs)
        {

            string s_subject = u_Stringmanager.Subjectcorrect(e_inp_subjects.Text);
            if(s_subject != null && s_subject.Length >= 4)
            {
                if (e_disp_subjects.SelectedItems.Count > 0)
                {
                    renamesubject(e_disp_subjects.SelectedItems[0].ImageIndex, s_subject);

                    UpdateSubjectList();

                    u_Manager.SaveSubjects();
                    u_Manager.RefreshProject();
                }
            }
            
        }
        partial void sub_remove(object o_sender, EventArgs o_eventargs)
        {

            if (u_Project.subjects.s_subjects.Length > 1)
            {
                if (e_disp_subjects.SelectedItems.Count > 0)
                {
                    removesubject(e_disp_subjects.SelectedItems[0].ImageIndex);
                }
                UpdateSubjectList();

                u_Manager.SaveSubjects();
                u_Manager.RefreshProject();
            }

        }
        public static void addsubject(string s_subject)
        {
            string[] s_subjects = new string[u_Project.subjects.s_subjects.Length+1];
            for (int i_index = 0; i_index < u_Project.subjects.s_subjects.Length; i_index++)
            {
                s_subjects[i_index] = u_Project.subjects.s_subjects[i_index];
            }
            s_subjects[u_Project.subjects.s_subjects.Length] = s_subject;
            u_Project.subjects.s_subjects = new string[s_subjects.Length];
            u_Project.subjects.s_subjects = s_subjects;
        }

        public static void removesubject(int i_pos) {
            string[] s_subjects = new string[u_Project.subjects.s_subjects.Length - 1];
            for (int i_index = 0,i_subindex=0; i_index < u_Project.subjects.s_subjects.Length; i_index++,i_subindex++)
            {
                if (i_index == i_pos)
                {
                    i_subindex--;
                    continue;
                }
                s_subjects[i_subindex] = u_Project.subjects.s_subjects[i_index];
            }
            u_Project.subjects.s_subjects = new string[s_subjects.Length];
            u_Project.subjects.s_subjects = s_subjects;
        }

        public static void renamesubject(int i_pos, string s_subject)
        {
            u_Project.subjects.s_subjects[i_pos] = s_subject;
        }


    }
}
