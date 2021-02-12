using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User;
using User.Source;

namespace User.Action
{

    //TODO: 
    /*
    Error Hnadling For all Inputs
         
    */

    public partial class ucpcreate : Form
    {
        public string s_Inheritance;
        public int i_SubjectIndex;
        public string s_Name;
        private bool b_State  = true;
        Winstyle.Windrag o_Drag;

        public ucpcreate()
        {
            InitializeComponent();
            Winstyle.Apply(this,new Size(275, 300),"Create Session");
            o_Drag = new Winstyle.Windrag(this);

            UpdateView();
            UpdateSellectables();
            UpdateButtons();

        }
        int[] i_Ref;
        public void UpdateSellectables()
        {
            if (Projecthandler.Files.o_Sessions.o_Content != null)
            {
                i_Ref = new int[Projecthandler.Files.o_Sessions.o_Content.Length];
                ImageList o_list = new ImageList();

                e_disp_inher.Items.Clear();
                for (int i_index = 0; i_index < Projecthandler.Files.o_Sessions.o_Content.Length; i_index++)
                {
                    if (Projecthandler.Files.o_Sessions.o_Content[i_index].s_Subject == Projecthandler.s_Subjects.o_Content[e_sel_subject.SelectedIndex])
                    {
                        ListViewItem o_Item = new ListViewItem(Projecthandler.Files.o_Sessions.o_Content[i_index].s_Name, o_list.Images.Count);
                        i_Ref[o_list.Images.Count] = i_index;
                        e_disp_inher.Items.Add(o_Item);
                        o_list.Images.Add(User.Properties.Resources.folder);
                    }
                }
                e_disp_inher.SmallImageList = o_list;
            }
            else e_disp_inher.Items.Clear();
        }
        public void UpdateView()
        {

            e_inp_topic.Text = "eg.: 'Calculus Lesson 1'";
            if (Projecthandler.s_Subjects.o_Content != null)
            {
                e_sel_subject.Items.Clear();
                e_sel_subject.Items.AddRange(Projecthandler.s_Subjects.o_Content);
                e_sel_subject.SelectedIndex = 0;
                e_sel_subject.Refresh();
            }

            if (Projecthandler.Templates.o_Templates.o_Content != null)
            {
                ImageList o_list = new ImageList();

                e_disp_temp.Items.Clear();
                for (int i_index = 0; i_index < Projecthandler.Templates.o_Templates.o_Content.Length; i_index++)
                {
                    ListViewItem o_Item = new ListViewItem(Projecthandler.Templates.o_Templates.o_Content[i_index].s_FileName, i_index);
                    e_disp_temp.Items.Add(o_Item);
                    o_list.Images.Add(Projecthandler.Templates.o_Templates.o_Content[i_index].o_Icon);
                }
                e_disp_temp.LargeImageList = o_list;
            }
            else e_disp_temp.Items.Clear();
        }

        private void CloseDialog(object sender, EventArgs e)
        {
            if (Checker.CheckValid(e_inp_topic.Text))
            {

                Projecthandler.Files.Session o_Session = new Projecthandler.Files.Session();
                o_Session.s_Name = e_inp_topic.Text;
                o_Session.o_Date = DateTime.Now;
                o_Session.s_Subject = Projecthandler.s_Subjects.o_Content[e_sel_subject.SelectedIndex];

                if (e_disp_inher.SelectedItems.Count > 0)
                {
                    Projecthandler.Files.Session o_TempSession = Projecthandler.Files.o_Sessions.o_Content[i_Ref[e_disp_inher.SelectedItems[0].ImageIndex]];
                    o_Session.s_Inheritance = Projecthandler.Files.GetSessionName(o_TempSession.s_Name, o_TempSession.o_Date);
                }
                else o_Session.s_Inheritance = "NONE";

                int[] i_Temps = null;
                if (e_disp_temp.SelectedItems.Count > 0)
                {
                    i_Temps = new int[e_disp_temp.SelectedItems.Count];
                    for (int i_Index = 0; i_Index < i_Temps.Length; i_Index++)
                    {
                        i_Temps[i_Index] = e_disp_temp.SelectedItems[i_Index].ImageIndex;
                    }
                }

                Projecthandler.Files.Create(o_Session, i_Temps);
                this.Hide();


            }
            else
            {
                Notify.Say("Invalid Name", "Sorry, but the charakters '][}:=#' are not allowed to be used in the session name.");
                this.Focus();
            }
        }

        private void Change(object sender, EventArgs e)
        {
            UpdateSellectables();
        }

        private void SellectInher(object sender, EventArgs e)
        {
            b_State = true;
            UpdateButtons();
        }

        private void SellectTemplates(object sender, EventArgs e)
        {
            b_State = false;
            UpdateButtons();
        }

        private void GlowHighlight(object sender, EventArgs e)
        {
            Label o_Label = (Label)sender;
            o_Label.ForeColor = Stylesource.o_bhovercolor;
        }

        private void GlowLeave(object sender, EventArgs e)
        {
            UpdateButtons();
        }
        private void UpdateButtons()
        {
            if (b_State)
            {
                e_but_inher.ForeColor = Stylesource.o_border;
                e_but_temp.ForeColor = Stylesource.o_text;
                e_disp_inher.BringToFront();
            }
            else
            {
                e_disp_temp.BringToFront();

                e_but_inher.ForeColor = Stylesource.o_text;
                e_but_temp.ForeColor = Stylesource.o_border;
            }
        }
    }
}
