using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User.Source;

namespace User.Action
{


    public partial class ucpsettings : Form
    {
        public delegate void LoadProject();
        public LoadProject o_LoadProject;
        Winstyle.Windrag o_Drag;
        public ucpsettings()
        { 
            InitializeComponent();
            Winstyle.Apply(this, new Size(520, 195),"Years");
            o_Drag = new Winstyle.Windrag(this);
            UpdateView();
        }

        private void CreateNewYear(object sender, EventArgs e)
        {
            string s_Name =null, s_Path = null;
            using (ucpcreatep o_YearDialog = new ucpcreatep())
            {
                o_YearDialog.ShowDialog();
                if (o_YearDialog.s_GradeName.Length == 0) return;
                if (!Checker.CheckValid(o_YearDialog.s_GradeName))
                {
                    SystemSounds.Asterisk.Play();
                    Notify.Say("Invalid Name", "Sorry, but the charakters '][}:=#' are not allowed to be used in the grade name.");
                }
                else
                {
                    s_Name = o_YearDialog.s_GradeName;
                    using (FolderBrowserDialog o_FolderDialog = new FolderBrowserDialog())
                    {
                        if (o_FolderDialog.ShowDialog() == DialogResult.OK)
                        {
                            s_Path = o_FolderDialog.SelectedPath;
                        }
                    }
                }
            }
            if (s_Path != null && s_Name != null)
            {
                Router.s_ProjectFiles.Add(s_Path);
                Router.i_CurrentProject = Router.s_ProjectFiles.o_Content.Length - 1;
                Router.SaveData();
                Projecthandler.Create(s_Path,s_Name);
            }

            UpdateView();
        }


        public void UpdateView()
        {
            Console.WriteLine(Router.s_ProjectFiles.o_Content==null);
            if (Router.s_ProjectFiles.o_Content != null)
            {
                ImageList o_list = new ImageList();

                e_disp_subjects.Items.Clear();
                for (int i_index = 0; i_index < Router.s_ProjectFiles.o_Content.Length; i_index++)
                {
                    ListViewItem o_Item = new ListViewItem(Router.s_ProjectFiles.o_Content[i_index],i_index);
                    if (i_index != Router.i_CurrentProject) o_Item.ForeColor = Stylesource.o_text_light;
                    if(!Directory.Exists(Router.s_ProjectFiles.o_Content[i_index])) o_Item.ForeColor = Stylesource.o_headercolor;

                    e_disp_subjects.Items.Add(o_Item);
                    o_list.Images.Add(User.Properties.Resources.folder);

                }
                e_disp_subjects.SmallImageList = o_list;
            }else e_disp_subjects.Items.Clear();
        }

        private void RemoveYear(object sender, EventArgs e)
        {
            if (e_disp_subjects.SelectedItems.Count > 0)
            {
                Router.i_CurrentProject = -1;
                Router.s_ProjectFiles.Delete( e_disp_subjects.SelectedItems[0].ImageIndex);
                Router.SaveData();
                UpdateView();
            }
        }

        private void Sellect(object sender, EventArgs e)
        {
            if (e_disp_subjects.SelectedItems.Count > 0)
            {
                if (Directory.Exists(Router.s_ProjectFiles.o_Content[e_disp_subjects.SelectedItems[0].ImageIndex]))
                {
                    Router.i_CurrentProject = e_disp_subjects.SelectedItems[0].ImageIndex;
                    Router.SaveData();
                    o_LoadProject();
                    UpdateView();
                } else
                {
                    Notify.Say("Error", "The Folder does not exist an thus cannot be sellectet as Project!");
                }


            }
        }

        private void AddExisting(object sender, EventArgs e)
        {
            using (FolderBrowserDialog o_FolderDialog = new FolderBrowserDialog())
            {
                if (o_FolderDialog.ShowDialog() == DialogResult.OK)
                {
                    Router.s_ProjectFiles.Add(o_FolderDialog.SelectedPath);
                    Router.SaveData();
                    UpdateView();

                }
            }
        }
    }

   

}