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
                if (!CheckName(o_YearDialog.s_GradeName))
                {
                    SystemSounds.Asterisk.Play();
                    Notify.Say("Invalid Name", "Sorry, but the charakter '][}:=#' are not allowed to be used in the grade name.");
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
                Router.AddRoute(s_Path);
                Router.SaveData();
                //CREATE config.ufg WITH  s_name AND OTHER DATA
            }

            UpdateView();
        }

        private bool CheckName(string s_Text)
        {
            char[] c_Forbiden = { ']', '[', '{', '}', ':', '=', '#' };
            for (int i_Index = 0; i_Index < c_Forbiden.Length; i_Index++)
            {
                if (s_Text.Contains(c_Forbiden[i_Index])) return false;
            }
            return true;
        }
        public void UpdateView()
        {
            if (Router.s_ProjectFiles != null)
            {
                ImageList o_list = new ImageList();

                e_disp_subjects.Items.Clear();
                for (int i_index = 0; i_index < Router.s_ProjectFiles.Length; i_index++)
                {
                    ListViewItem o_Item = new ListViewItem(Router.s_ProjectFiles[i_index],i_index);

                    if (i_index != Router.i_CurrentProject) o_Item.ForeColor = Stylesource.o_text_light;
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
                Router.DelRoute( e_disp_subjects.SelectedItems[0].ImageIndex);
                Router.SaveData();
                UpdateView();
            }
        }

        private void Sellect(object sender, EventArgs e)
        {
            if (e_disp_subjects.SelectedItems.Count > 0)
            {
                Router.i_CurrentProject = e_disp_subjects.SelectedItems[0].ImageIndex;
                Router.SaveData();
                UpdateView();
            }
        }

        private void AddExisting(object sender, EventArgs e)
        {
            using (FolderBrowserDialog o_FolderDialog = new FolderBrowserDialog())
            {
                if (o_FolderDialog.ShowDialog() == DialogResult.OK)
                {
                    Router.AddRoute(o_FolderDialog.SelectedPath);
                    Router.SaveData();
                    UpdateView();

                }
            }
        }
    }

   

}