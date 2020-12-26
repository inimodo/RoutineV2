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
using Source;
using Source.Style;

namespace User.Action
{
    public partial class ucpopen : Form
    {
        Point p_relative;
        bool b_indrag = false;
        public Form o_wintype;
        public ucpopen()
        {
            InitializeComponent();
            InitializeInterface(new Size(340, 400));
            InitializeUI();
        }

        void InitializeInterface(Size o_size)
        {
            int i_offset = this.Size.Width - o_size.Width;
            this.e_nav_close.Location = new Point(this.e_nav_close.Location.X - i_offset, this.e_nav_close.Location.Y);
            this.Size = new Size(o_size.Width, o_size.Height + e_nav.Size.Height);
            this.e_hider.Size = new Size(o_size.Width - 2, o_size.Height - 2);
            this.e_hider.Location = new Point(1, 1 + e_nav.Size.Height);
            this.e_nav.Location = new Point(1, 1);
            this.e_nav.Size = new Size(o_size.Width - 2, e_nav.Size.Height);
            this.e_nav_logo.Location = new Point(e_nav_logo.Location.X, 1);

            this.BackColor = u_Stylesource.o_bordercolor;
            this.e_nav.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_logo.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_title.BackColor = u_Stylesource.o_dragcolor;
            this.e_nav_title.ForeColor = u_Stylesource.o_defaultcolor;
            this.e_hider.BackColor = u_Stylesource.o_backcolor;
            this.e_nav_title.Text = "Open";
            this.Text = this.e_nav_title.Text;


        }
        public void InitializeUI()
        {
            if (u_Project.b_running)
            {
                if (!u_Project.b_allowsedit)
                {
                    ListLessons();
                }
            }

            this.BackColor = u_Stylesource.o_backcolor;
            this.e_list.BackColor = u_Stylesource.o_backcolor;
            this.e_list.ForeColor = u_Stylesource.o_defaultcolor;
        }

        void event_focus(object sender, EventArgs e)
        {
            this.BackColor = u_Stylesource.o_bordercolor;
        }
        void event_unfocus(object sender, EventArgs e)
        {
            this.BackColor = u_Stylesource.o_clickcolor;

        }
        void event_close(object sender, EventArgs e)
        {
            this.Hide();
        }

        void Move_start(object o_sender, MouseEventArgs o_mouseventargs)
        {
            p_relative = this.PointToClient(Cursor.Position);
            b_indrag = true;
        }
        void Move_run(object o_sender, MouseEventArgs o_mouseventargs)
        {
            if (b_indrag)
            {
                this.Location = new Point(Cursor.Position.X - p_relative.X, Cursor.Position.Y - p_relative.Y);
            }
        }
        void Move_stop(object o_sender, MouseEventArgs o_mouseventargs)
        {
            b_indrag = false;
        }

        string s_hash = "";
        string s_file = "";

        void event_open(object o_sender, EventArgs o_eventargs)
        {
            if (s_hash != "")
            {
                u_Manager.OpenLesson(s_hash);
                this.Hide();
            }
            if (s_file != "")
            {
                if (File.Exists(s_file))
                {
                    Process.Start(s_file);
                    this.Hide();
                }
            }
        }
        void event_sel(object o_sender, TreeViewEventArgs o_eventargs)
        {
            if (o_eventargs.Node.Level == 1)
            {
                s_hash = o_eventargs.Node.Name;
                s_file = "";
            }
            else
            if (o_eventargs.Node.Level == 2)
            {
                s_hash = "";
                s_file = u_Manager.GetFileLessonPath(o_eventargs.Node.Name) + o_eventargs.Node.Text;
            }
        }

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
                    if (i_subjectid != -1)
                    {
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
        string[] LoadLessonInfo(string s_hash, out string s_subject, out string s_topic)
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
