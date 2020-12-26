using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using User;
using User.Forms;
using User.Messager;
using Source;
using Source.Routines;
using Source.Style;
using System.Drawing;

namespace User.Forms
{
    public partial class ucpi_lesson
    {


        int i_missingfiles = 0;
        partial void SetTree()
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


                for (int i_index = 0,i_caught = 0; i_index < u_Project.lesson.o_loadedlesson.s_files.Length; i_index++)
                {
                    if (!File.Exists(u_Manager.GetFilePathFromIndex(i_index)))
                    {
                        o_nodes[i_caught + s_newfiles.Length] = new TreeNode(u_Project.lesson.o_loadedlesson.s_files[i_index]+u_Stringsource.s_filemissing);
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
    }
}
