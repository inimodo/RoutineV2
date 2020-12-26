using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source.Style;
using Source;
using System.Diagnostics;
using Source.Routines;
using System.IO;

namespace User.ActionWindow.Lesson
{
    public partial class ucplessondisp : UserControl
    {
        public ucplessondisp()
        {
            InitializeComponent();
            InitializeInterface();
        }

        public void InitializeInterface()
        {
            this.BackColor = u_Stylesource.o_backcolor;

            this.e_but_file_add.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_rename.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_remove.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_append.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_folder.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_append.BackColor = u_Stylesource.o_backcolor;
            this.e_but_file_deletelesson.BackColor = u_Stylesource.o_backcolor;

            this.e_inp_file.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_inp_file.BackColor = u_Stylesource.o_formcolor;

            this.e_div_five.BackColor = u_Stylesource.o_defaultcolor;
        }

        public void InitializeLesson()
        {
            if (u_Project.lesson.o_loadedlesson.s_files != null || u_Project.lesson.o_loadedlesson.s_files.Length > 0)
            {
                e_files.Items.Clear();
                string[] s_newfiles = Directory.GetFiles(u_Manager.GetFilePathFromString(""));

                ImageList o_List = new ImageList();

                for (int i_Index = 0; i_Index < s_newfiles.Length; i_Index++)
                {
                    string[] s_part = s_newfiles[i_Index].Split(u_LoadRoutines.s_sp);
                    string s_filename = s_part[s_part.Length - 1];
                    this.e_files.Items.Add(s_filename, i_Index);
                    o_List.Images.Add(Icon.ExtractAssociatedIcon(s_newfiles[i_Index]));
                    this.e_files.Items[i_Index].ForeColor = u_Stylesource.o_defaultcolordim;

                    Console.WriteLine(i_Index + " " + s_filename);
                }

                for (int i_index = 0,i_mIndex = 0; i_index < u_Project.lesson.o_loadedlesson.s_files.Length; i_index++)
                {
                    if (!File.Exists(u_Manager.GetFilePathFromIndex(i_index)))
                    {
                        string[] s_part = u_Manager.GetFilePathFromIndex(i_index).Split(u_LoadRoutines.s_sp);
                        string s_filename = s_part[s_part.Length - 1];

                        this.e_files.Items.Add(s_filename, i_mIndex + s_newfiles.Length);
                        o_List.Images.Add(SystemIcons.Error);
                        this.e_files.Items[i_mIndex + s_newfiles.Length].ForeColor = u_Stylesource.o_headercolor;
                        i_mIndex++;
                    }
                }
                e_files.SmallImageList = o_List;

            }
        }


        public bool SaveLessonLocal()
        {
            return u_LessonRoutines.lesson.Save(u_Project.lesson.o_loadedlesson);
        }


        void click_rename(object o_sender, EventArgs o_eventargs)
        {

            if (e_files.SelectedItems.Count == 0)
            {
                return;
            }
            int i_fileindex = u_Manager.LessonFileIndex(e_files.SelectedItems[0].Text);
            if (i_fileindex != -1)
            {

                string s_newname = u_Stringmanager.Filecorrect(e_inp_file.Text);
                if (s_newname != "" && s_newname != null)
                {
                    string s_newfile = u_Manager.RenameFileFromLesson(i_fileindex, s_newname);
                    if (s_newfile != null)
                    {
                        SaveLessonLocal();
                        InitializeLesson();
                    }
                }
            }

        }
        void click_close(object o_sender, EventArgs o_eventargs)
        {
            this.Hide();
        }
        void event_editfile(object o_sender, EventArgs o_eventargs)
        {
            e_inp_file.Text = u_Stringmanager.Filecorrect(e_inp_file.Text);
        }
        void click_add(object o_sender, EventArgs o_eventargs)
        {
            string s_name = u_Stringmanager.Filecorrect(e_inp_file.Text);
            if (e_files.SelectedItems.Count > 0 )
            {
                int i_fileindex = u_Manager.LessonFileIndex(e_files.SelectedItems[0].Text);
                if (i_fileindex == -1)
                {
                    s_name = u_Stringmanager.Filecorrect(e_files.SelectedItems[0].Text);
                    if (s_name == e_files.SelectedItems[0].Text)
                    {
                        u_Manager.AddFileToLessonByName(e_files.SelectedItems[0].Text);
                    }
                    SaveLessonLocal();
                    InitializeLesson();
                    return;
                }
            }

            if (s_name != "" && s_name != null)
            {
                u_Manager.AddFileToLesson(s_name);
                SaveLessonLocal();
                InitializeLesson();
            }
        }
        void click_openfolder(object o_sender, EventArgs o_eventargs)
        {
            string s_Path = u_Project.software.s_projectfolder + u_LessonRoutines.s_sp + u_Vars.s_data + u_LessonRoutines.s_sp + u_Project.lesson.o_loadedlesson.s_hash + u_LessonRoutines.s_sp + u_Vars.s_files;
            Process.Start(s_Path);
        }
        void click_deletelesson(object o_sender, EventArgs o_eventargs)
        {
            u_Manager.DeleteLesson(u_Project.lesson.o_loadedlesson.s_hash);
        }
        void click_remove(object o_sender, EventArgs o_eventargs)
        {
            if (e_files.SelectedItems.Count == 0)
            {
                return;
            }
            int i_fileindex = u_Manager.LessonFileIndex(e_files.SelectedItems[0].Text);
            if (i_fileindex != -1)
            {
                u_Manager.RemoveFileFromLesson(i_fileindex);
                SaveLessonLocal();
                InitializeLesson();
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
        void click_externaladd(object o_sender, EventArgs o_eventargs)
        {
            string s_newfile = SelectFile();
            if (s_newfile != null)
            {
                u_Manager.AddExternFileToLesson(s_newfile);
                SaveLessonLocal();
                InitializeLesson();
            }
        }

        void event_doubleclick(object o_sender, EventArgs o_eventargs)
        {
            if (e_files.SelectedItems.Count > 0)
            {

                string s_file = u_Manager.GetFilePathFromString(e_files.SelectedItems[0].Text);

                if (File.Exists(s_file))
                {
                    Process.Start(s_file);
                }
                
            }
        }
    }
}
