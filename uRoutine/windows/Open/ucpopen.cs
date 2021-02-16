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
using User.Source;

namespace User.Action
{
    public partial class ucpopen : Form
    {

        public delegate void OpenSession(int i_SessionIndex);
        public OpenSession o_OpenSession;

        Winstyle.Windrag o_Drag;
        public ucpopen()
        {
            InitializeComponent();
            Winstyle.Apply(this,new Size(340,400),"Open");
            o_Drag = new Winstyle.Windrag(this);
        }

        public void UpdateView()
        {
            e_list.Nodes.Clear();
            ImageList o_IconList = new ImageList();
            e_list.ImageList = o_IconList;
            o_IconList.Images.Add(global::User.Properties.Resources.folder);
            for (int i_Index = 0; i_Index < Projecthandler.s_Subjects.o_Content.Length; i_Index++)
            {
                TreeNode o_Subject = new TreeNode(Projecthandler.s_Subjects.o_Content[i_Index]);
                o_Subject.SelectedImageIndex = 0;
                o_Subject.ImageIndex = 0;
                o_Subject.ForeColor = Stylesource.o_headercolor;
                for (int i_Sub = 0; i_Sub < Projecthandler.Files.o_Sessions.o_Content.Length; i_Sub++)
                {
                    if (Projecthandler.Files.o_Sessions.o_Content[i_Sub].s_Subject == Projecthandler.s_Subjects.o_Content[i_Index])
                    {
                        TreeNode o_Session = new TreeNode(Projecthandler.Files.o_Sessions.o_Content[i_Sub].s_Name);
                        o_IconList.Images.Add(global::User.Properties.Resources.create);
                        o_Session.SelectedImageIndex = i_Sub+1;
                        o_Session.ImageIndex = i_Sub+1;
                        o_Subject.Nodes.Add(o_Session);

                    }
                }
                e_list.Nodes.Add(o_Subject);

            }
        }


        private void OpenSessionClick(object sender, EventArgs e)
        {
            if (e_list.SelectedNode.Level == 1)
            {
                o_OpenSession(e_list.SelectedNode.ImageIndex-1);
            }
        }
    }
}
