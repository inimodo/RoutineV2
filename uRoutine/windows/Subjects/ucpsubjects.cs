using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User.Source;

namespace User.Action
{
    public partial class ucpsubjects : Form
    {
        Winstyle.Windrag o_Drag;

        public ucpsubjects()
        {
            InitializeComponent();
            Winstyle.Apply(this, new Size(340,360),"Classes");
            o_Drag = new Winstyle.Windrag(this);

        }

        private void AddSubject(object sender, EventArgs e)
        {
            if (!Checker.CheckValid(e_inp_subjects.Text))
            {
                SystemSounds.Asterisk.Play();
                Notify.Say("Invalid Name", "Sorry, but the charakters '][}:=#' are not allowed to be used in the subject name.");
            }
            else
            {
                Projecthandler.s_Subjects.Add(e_inp_subjects.Text);
                Projecthandler.Save();
                e_inp_subjects.Clear();
                UpdateView();
            }
        }

        public void UpdateView()
        {
            Console.WriteLine("PING");
            if (Projecthandler.s_Subjects.o_Content!= null)
            {
                ImageList o_list = new ImageList();

                e_disp_subjects.Items.Clear();
                for (int i_index = 0; i_index < Projecthandler.s_Subjects.o_Content.Length; i_index++)
                {
                    ListViewItem o_Item = new ListViewItem(Projecthandler.s_Subjects.o_Content[i_index], i_index);

    
                    e_disp_subjects.Items.Add(o_Item);
                    o_list.Images.Add(User.Properties.Resources.folder);

                }
                e_disp_subjects.SmallImageList = o_list;
            }
            else e_disp_subjects.Items.Clear();
        }
        private void Del(object sender, EventArgs e)
        {
            if (e_disp_subjects.SelectedItems.Count > 0)
            {
                Projecthandler.s_Subjects.Delete(e_disp_subjects.SelectedItems[0].ImageIndex);
                Projecthandler.Save();
                UpdateView();
            }
        }

    }
}
