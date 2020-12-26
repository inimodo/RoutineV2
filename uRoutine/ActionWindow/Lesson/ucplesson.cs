using Source;
using Source.Routines;
using Source.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User
{
    public partial class ucplesson : Form
    {
        public ucplesson()
        {
            InitializeComponent();
            InitializeInterface();

            this.TopMost = true;
            this.ShowInTaskbar = false;
        }
        int i_missingfiles = 0;
        string s_topic_pref;

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

            this.e_info_date.Text = u_Stringmanager.ToReadDate(u_Project.lesson.o_loadedlesson.o_date) + "  " + u_Project.lesson.o_loadedlesson.s_subject;

        }

        void SetTree()
        {
            if (u_Project.lesson.o_loadedlesson.s_files != null || u_Project.lesson.o_loadedlesson.s_files.Length > 0)
            {
                int i_mcounter = 0;
                string[] s_newfiles = Directory.GetFiles(u_Manager.GetFilePathFromString(""));

                for (int i_index = 0; i_index < u_Project.lesson.o_loadedlesson.s_files.Length; i_index++)
                {
                    if (!File.Exists(u_Manager.GetFilePathFromIndex(i_index)))
                    {
                        i_mcounter++;
                    }
                }

                e_tree.Nodes.Clear();
                TreeNode[] o_nodes = new TreeNode[s_newfiles.Length + i_mcounter];
                ImageList o_list = new ImageList();
                Icon o_fileico = SystemIcons.Error;

                for (int i_index = 0; i_index < s_newfiles.Length; i_index++)
                {

                    int i_lessonindex = u_Manager.LessonFileIndex(s_newfiles[i_index]);
                    string[] s_part = s_newfiles[i_index].Split(u_LoadRoutines.s_sp);
                    string s_filename = s_part[s_part.Length - 1];

                    o_nodes[i_index] = new TreeNode(s_filename);
                    o_fileico = Icon.ExtractAssociatedIcon(s_newfiles[i_index]);

                    if (i_lessonindex == -1)
                    {
                        o_nodes[i_index].ForeColor = u_Stylesource.o_defaultcolordim;
                    }
                    o_nodes[i_index].ImageIndex = i_index;
                    o_nodes[i_index].SelectedImageIndex = i_index;
                    o_list.Images.Add(o_fileico);

                }


                for (int i_index = 0, i_caught = 0; i_index < u_Project.lesson.o_loadedlesson.s_files.Length; i_index++)
                {
                    if (!File.Exists(u_Manager.GetFilePathFromIndex(i_index)))
                    {
                        o_nodes[i_caught + s_newfiles.Length] = new TreeNode(u_Project.lesson.o_loadedlesson.s_files[i_index] + u_Stringsource.s_filemissing);
                        o_nodes[i_caught + s_newfiles.Length].ImageIndex = i_index;
                        o_nodes[i_caught + s_newfiles.Length].SelectedImageIndex = i_index;
                        o_nodes[i_caught + s_newfiles.Length].ForeColor = u_Stylesource.o_headercolor;

                        o_fileico = SystemIcons.Error;
                        o_list.Images.Add(o_fileico);
                        i_caught++;
                    }
                }

                e_tree.ImageList = o_list;
                e_tree.Nodes.AddRange(o_nodes);
                e_tree.ExpandAll();

                if (i_mcounter > 1)
                {
                    if (i_missingfiles != i_mcounter)
                    {
                        if (u_Manager.RemoveNonFileFromLesson(i_mcounter))
                        {
                            SaveLessonLocal();
                            SetTree();
                        }
                        else
                        {
                            i_missingfiles = i_mcounter;
                        }
                    }
                }
            }
        }

        public bool SaveLessonLocal()
        {
            SetUi();
            return u_LessonRoutines.lesson.Save(u_Project.lesson.o_loadedlesson);
        }


        void click_rename(object o_sender, EventArgs o_eventargs)
        {

            if (e_tree.SelectedNode == null)
            {
                return;
            }
            int i_fileindex = u_Manager.LessonFileIndex(e_tree.SelectedNode.Text);
            if (i_fileindex != -1)
            {

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
            if (e_tree.SelectedNode != null)
            {
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
        void click_externaladd(object o_sender, EventArgs o_eventargs)
        {
            string s_newfile = SelectFile();
            if (s_newfile != null)
            {
                u_Manager.AddExternFileToLesson(s_newfile);
                SaveLessonLocal();
                SetTree();
            }
        }
        void event_edittopic(object o_sender, EventArgs o_eventargs)
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
        void event_doubleclick(object o_sender, EventArgs o_eventargs)
        {
            if (e_tree.SelectedNode != null)
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
