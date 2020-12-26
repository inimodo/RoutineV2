using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
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
        public ucplesson o_lesson;


        partial void click_rename(object o_sender, EventArgs o_eventargs)
        {

            if(e_tree.SelectedNode == null)
            {
                return;
            }
            int i_fileindex = u_Manager.LessonFileIndex(e_tree.SelectedNode.Text);
            if (i_fileindex != -1) { 

                string s_newname = u_Stringmanager.Filecorrect(e_inp_file.Text);
                if (s_newname != "" && s_newname != null)
                {
                    string s_newfile = u_Manager.RenameFileFromLesson(i_fileindex, s_newname);
                    if (s_newfile != null)
                    {
                        SaveLessonLocal();
                        SetTree();
                    }
                }
            }
            
        }
        partial void click_close(object o_sender, EventArgs o_eventargs)
        {
            if(o_lesson != null)
            {
                o_lesson.Close();
            }      
        }
        partial void event_editfile(object o_sender, EventArgs o_eventargs)
        {
            e_inp_file.Text = u_Stringmanager.Filecorrect(e_inp_file.Text);
        }
        partial void click_add(object o_sender, EventArgs o_eventargs)
        {
            string s_name = u_Stringmanager.Filecorrect(e_inp_file.Text);
            if (e_tree.SelectedNode != null) {
                int i_fileindex = u_Manager.LessonFileIndex(e_tree.SelectedNode.Text);
                if (i_fileindex == -1)
                {
                    s_name = u_Stringmanager.Filecorrect(e_tree.SelectedNode.Text);
                    if (s_name == e_tree.SelectedNode.Text)
                    {
                        u_Manager.AddFileToLessonByName(e_tree.SelectedNode.Text);
                    }
                    SaveLessonLocal();
                    SetTree();
                    return;
                }
            }
   
            if (s_name != "" && s_name != null)
            {
                u_Manager.AddFileToLesson(s_name);
                SaveLessonLocal();
                SetTree();
            }
        }
        partial void click_openfolder(object o_sender, EventArgs o_eventargs)
        {
            string s_Path = u_Project.software.s_projectfolder + u_LessonRoutines.s_sp + u_Vars.s_data + u_LessonRoutines.s_sp + u_Project.lesson.o_loadedlesson.s_hash + u_LessonRoutines.s_sp + u_Vars.s_files;
            Process.Start(s_Path);
        }
        partial void click_deletelesson(object o_sender, EventArgs o_eventargs)
        {
            u_Manager.DeleteLesson(u_Project.lesson.o_loadedlesson.s_hash);
        }
        partial void click_remove(object o_sender, EventArgs o_eventargs)
        {
            if (e_tree.SelectedNode == null)
            {
                return;
            }
            int i_fileindex = u_Manager.LessonFileIndex(e_tree.SelectedNode.Text);
            if (i_fileindex != -1)
            {
                u_Manager.RemoveFileFromLesson(i_fileindex);
                SaveLessonLocal();
                SetTree();
            }
        }
        private string SelectFile()
        {
            OpenFileDialog o_openfile = new OpenFileDialog();
            o_openfile.Multiselect = false;

            o_openfile.Filter = "All files (*.*)|*.*";
            o_openfile.Title = u_Stringsource.s_appname + " | " + u_Stringsource.s_openfile;

            if (o_openfile.ShowDialog() == DialogResult.OK)
            {
               return o_openfile.FileName;
            }
            return null;
        }
        partial void click_externaladd(object o_sender, EventArgs o_eventargs)
        {
            string s_newfile = SelectFile();
            if (s_newfile != null)
            {
                u_Manager.AddExternFileToLesson(s_newfile);
                SaveLessonLocal();
                SetTree();
            }
        }
        string s_topic_pref;
        partial void event_edittopic(object o_sender, EventArgs o_eventargs)
        {
            if (e_inp_topic.Text.Length == 0)
            {
                e_inp_topic.Text = s_topic_pref;
                return;
            }

            e_inp_topic.Text = u_Stringmanager.Topiccorrect(e_inp_topic.Text);
            e_inp_topic.SelectionStart = e_inp_topic.TextLength;

            if (e_inp_topic.Text != null)
            {
                u_Project.lesson.o_loadedlesson.s_topic = e_inp_topic.Text;
                SaveLessonLocal();
                SetTree();
            }
        }
        partial void event_doubleclick(object o_sender, EventArgs o_eventargs)
        {
            if(e_tree.SelectedNode != null)
            {
                if (e_tree.SelectedNode.IsSelected)
                {      
                    string s_file = u_Manager.GetFilePathFromString(e_tree.SelectedNode.Text);

                    if (File.Exists(s_file))
                    {
                        Process.Start(s_file);
                    }
                }
            }
        }
    }
}
