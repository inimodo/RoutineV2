using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source;
using Source.Routines;
using Source.Style;
using User;
namespace User.Forms
{
    partial class ucpi_all
    {
        private void ListLessons()
        {
            ImageList o_imagelist = new ImageList();
            TreeNode[] o_subjects = new TreeNode[u_Project.subjects.s_subjects.Length];
            if (u_Project.lesson.content.s_lessons.Length > 0)
            {
                o_imagelist.Images.Add(global::User.Properties.Resources.folder);
                o_imagelist.Images.Add(global::User.Properties.Resources.create);

                e_list.Nodes.Clear();
                for (int i_selsub = 0; i_selsub < u_Project.subjects.s_subjects.Length; i_selsub++)
                {
                    o_subjects[i_selsub] = new TreeNode();
                    o_subjects[i_selsub].Text = u_Project.subjects.s_subjects[i_selsub];
                    o_subjects[i_selsub].ForeColor = u_Stylesource.o_defaultcolor;
                    o_subjects[i_selsub].ImageIndex = 0;
                }

                for (int i_subindex = 0; i_subindex < u_Project.lesson.content.s_lessons.Length; i_subindex++)
                {
                    u_Listhandler.configset(u_Manager.GetLessonPath(u_Project.lesson.content.s_lessons[i_subindex]) + u_Vars.lesson.content.s_contcfg);
                    string s_subject, s_topic;
                    string[] s_files = LoadLessonInfo(u_Project.lesson.content.s_lessons[i_subindex], out s_subject, out s_topic);
                    if (s_files == null)
                    {
                        u_Manager.SuspectError();
                        return;
                    }

                    TreeNode[] o_fileinfolist = new TreeNode[s_files.Length];
                    for (int i_infoindex = 0; i_infoindex < o_fileinfolist.Length; i_infoindex++)
                    {
                        o_fileinfolist[i_infoindex] = new TreeNode();
                        o_fileinfolist[i_infoindex].ForeColor = u_Stylesource.o_defaultcolor;
                        o_fileinfolist[i_infoindex].ImageIndex = 1;
                        o_fileinfolist[i_infoindex].Text = s_files[i_infoindex];
                        o_fileinfolist[i_infoindex].Name = u_Project.lesson.content.s_lessons[i_subindex];
                    }

                    TreeNode o_lesson = new TreeNode();     
                    o_lesson.Nodes.AddRange(o_fileinfolist);
                    o_lesson.Text = s_topic;
                    o_lesson.ImageIndex = 0;
                    o_lesson.ForeColor = u_Stylesource.o_headercolor;
                    o_lesson.Name = u_Project.lesson.content.s_lessons[i_subindex];
                    int i_subjectid = GetSubjectIndex(s_subject);
                    if (i_subjectid != -1) {
                        o_subjects[i_subjectid].Nodes.Add(o_lesson);
                    }
                }
                e_list.Nodes.AddRange(o_subjects);
                e_list.ImageList = o_imagelist;
            }
        }
        int GetSubjectIndex(string s_subject)
        {
            int i_selsub = 0;
            for (i_selsub = 0; i_selsub < u_Project.subjects.s_subjects.Length; i_selsub++)
            {
                if (s_subject == u_Project.subjects.s_subjects[i_selsub])
                {
                    return i_selsub;
                }
            }
            return -1;
        }
        string[] LoadLessonInfo(string s_hash, out string s_subject,out string s_topic)
        {
            string s_filepath = u_Manager.GetLessonPath(s_hash);
            u_Listhandler.configset(s_filepath + u_Vars.lesson.content.s_contcfg);
            string[] s_files = u_Listhandler.readstringlist();
            u_Confighandler.configset(s_filepath + u_Vars.lesson.info.s_contcfg);
            s_subject = u_Confighandler.readstring(u_Vars.lesson.info.s_cfgreg, u_Vars.lesson.info.s_cfg_subject);
            s_topic = u_Confighandler.readstring(u_Vars.lesson.info.s_cfgreg, u_Vars.lesson.info.s_cfg_topic);
            if (s_files == null)
            {
                u_Manager.SuspectError();
            }
            return s_files;
        }
    }
}
