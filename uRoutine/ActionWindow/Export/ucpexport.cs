using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Source;
using Source.Routines;
using Source.Style;

namespace User.Action
{
    public partial class ucpexport : Form
    {
        Point p_relative;
        bool b_indrag = false;
        public Form o_wintype;
        private string s_wintitle;
        public ucpexport()
        {
            InitializeComponent();
            InitializeInterface(new Size(230, 300));
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
            this.e_nav_title.Text = "Export";
            this.Text = this.e_nav_title.Text;

        }
        public void InitializeUI()
        {
            if (u_Project.b_running)
            {
                ListLessons();
            }

            this.BackColor = u_Stylesource.o_backcolor;

            e_list.BackColor = u_Stylesource.o_backcolor;

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

                    string s_filepath = u_Manager.GetLessonPath(u_Project.lesson.content.s_lessons[i_subindex]);
                    u_Listhandler.configset(s_filepath + u_Vars.lesson.content.s_contcfg);
                    string[] s_files = u_Listhandler.readstringlist();
                    u_Confighandler.configset(s_filepath + u_Vars.lesson.info.s_contcfg);

                    TreeNode o_lesson = new TreeNode();
                    string s_subject = u_Confighandler.readstring(u_Vars.lesson.info.s_cfgreg, u_Vars.lesson.info.s_cfg_subject);
                    string s_topic = u_Confighandler.readstring(u_Vars.lesson.info.s_cfgreg, u_Vars.lesson.info.s_cfg_topic);
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
        string s_hash = "";
         void event_open(object o_sender, EventArgs o_eventargs)
        {
            if (s_hash != "")
            {
      
                string s_filepath = SaveZip();
                if (s_filepath != null)
                {
                    string s_exportpath = u_Project.software.s_projectfolder + u_LoadRoutines.s_sp + u_Vars.s_data + u_LoadRoutines.s_sp + s_hash+ u_LoadRoutines.s_sp+u_Vars.s_files;
                    if (File.Exists(s_filepath)) File.Delete(s_filepath);
                    ZipFile.CreateFromDirectory(s_exportpath, s_filepath, CompressionLevel.Optimal, false);
                    this.Hide();
                }
                
            }
        }
         void event_sel(object o_sender, TreeViewEventArgs o_eventargs)
        {
            if (o_eventargs.Node.Level == 1)
            {
                s_hash = o_eventargs.Node.Name;
            }
            else
            if (o_eventargs.Node.Level == 2)
            {
                s_hash = "";
            }
        }
        void event_focus(object sender, EventArgs e)
        {
            this.BackColor = u_Stylesource.o_bordercolor;
        }
        void event_unfocus(object sender, EventArgs e)
        {
            this.BackColor = u_Stylesource.o_clickcolor;
            this.Hide();


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

    }
}
