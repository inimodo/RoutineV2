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

/*
 TO DOOO
     
ERROR HANDLING FOR ALL FUNCTIONS ENDS AND IFS !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!     
     
*/
namespace User.Action
{
    public partial class ucpboard : Form
    {
        public static class Win
        {
            public static ucpsettings o_Settings = new ucpsettings();
            public static ucpsubjects o_Subjects = new ucpsubjects();
            public static ucpcreate o_Create = new ucpcreate();
            public static ucpopen o_Open = new ucpopen();
        }
        public static class Data
        {
            public static bool b_OpenedSession = false;
            public static int i_SellectedItem;
            public static string s_SellectedItemName;
        }
        public ucpboard(string[] s_args)
        {
            InitializeComponent();
            Winstyle.Apply(this, new Size(390, 235), "Routine");
            Router.LoadData();
            Projecthandler.Load();
            Projecthandler.Files.FetchAll();
            Projecthandler.Templates.LoadTemplates();
            Win.o_Create.o_OpenSession = CallbackOpen;
            Win.o_Open.o_OpenSession = CallbackOpen;
        }

        private void CloseSession(object sender, EventArgs e)
        {
            if (Data.b_OpenedSession)
            {
                Data.b_OpenedSession = false;
                Projecthandler.Files.i_LoadedSession = -1;

                UpdateWindowState();
            }
            else this.Close();
        }

        public void CallbackOpen(int i_SessionIndex)
        {
            Data.b_OpenedSession = true;
            Projecthandler.Files.i_LoadedSession = i_SessionIndex;
            UpdateWindowState();
            UpdateDisplayedContent();
        }


        public void UpdateDisplayedContent()
        {
            this.e_nav_topic.Text = Projecthandler.Files.o_Sessions.o_Content[Projecthandler.Files.i_LoadedSession].s_Name;
            string[] s_FoundFiles = Directory.GetFiles(Projecthandler.Files.GetSessionPath(Projecthandler.Files.i_LoadedSession));
            Console.WriteLine();
            ImageList o_list = new ImageList();
            e_disp_content.Items.Clear();
            for (int i_index = 0; i_index < s_FoundFiles.Length; i_index++)
            {
                ListViewItem o_Item = new ListViewItem(Checker.ExtractFileName(s_FoundFiles[i_index]),i_index);
                e_disp_content.Items.Add(o_Item);
                o_list.Images.Add(Icon.ExtractAssociatedIcon(s_FoundFiles[i_index]));
            }
            e_disp_content.LargeImageList = o_list;
        }

        public void UpdateWindowState()
        {
            if (!Data.b_OpenedSession)
            {
                this.Size = new Size(72, this.Size.Height);
                this.e_disp_content.Hide();
                this.e_nav_topic.Hide();
                this.e_hider.Location = new Point(1, this.e_hider.Location.Y);
                this.e_nav_logo.Location = new Point(20, this.e_nav_logo.Location.Y);

            }
            else
            {
                this.Size = new Size(392, this.Size.Height);
                this.e_disp_content.Show();
                this.e_disp_content.BringToFront();
                this.e_nav_topic.Show();
                this.e_hider.Location = new Point(321, this.e_hider.Location.Y);
                this.e_nav_logo.Location = new Point(10,this.e_nav_logo.Location.Y);

            }
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height); ;

            this.Update();
            this.UpdateBounds();
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            Win.o_Settings.Show();
        }

        private void Loading(object sender, EventArgs e)
        {
            UpdateWindowState();
            if (Router.i_CurrentProject == -1) SettingsTutorial();
            if (Router.i_CurrentProject != -1 && Projecthandler.s_Subjects.o_Content == null) SubjectTutorial();

        }

        public void SettingsTutorial()
        {
            Notify.Say("Hello!", "You need to create or sellect a projectfolder.");
            OpenSettings(null, null);

        }

        public void SubjectTutorial()
        {
            Notify.Say("Hello!", "Okay, now you need to enter all your subjects.");
            OpenSubjects(null, null);

        }

        private void OpenSubjects(object sender, EventArgs e)
        {
            if ((Router.i_CurrentProject != -1))
            {
                Win.o_Subjects.UpdateView();
                Win.o_Subjects.Show();
            }

        }

        private void CreateSession(object sender, EventArgs e)
        {
            if (Router.i_CurrentProject != -1 && Projecthandler.s_Subjects.o_Content != null)
            {
                Win.o_Create.UpdateView();
                Win.o_Create.Show();
            }
        }




        private void OpenFile(object sender, EventArgs e)
        {
            if (e_disp_content.SelectedItems.Count>0)
            {
                string s_BuildPath = Projecthandler.Files.GetSessionPath(Projecthandler.Files.i_LoadedSession) + e_disp_content.SelectedItems[0].Text;
                if (File.Exists(s_BuildPath)) Process.Start(s_BuildPath);
            }
        }

        private void OpenFolder(object sender, MouseEventArgs e)
        {
            if (e_disp_content.SelectedItems.Count == 0 && e.Clicks == 2)
            {
                string s_BuildPath = Projecthandler.Files.GetSessionPath(Projecthandler.Files.i_LoadedSession);
                if (Directory.Exists(s_BuildPath)) Process.Start(s_BuildPath);
            }
        }

        private void DragOnto(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void DragDrop(object sender, DragEventArgs e)
        {
            string s_Path;
            if (Router.GetCurrentDir(out s_Path))
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] s_Files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    foreach (string s_File in s_Files)
                    {
                        string s_NewPath = Projecthandler.Files.GetSessionPath(Projecthandler.Files.i_LoadedSession)+ Checker.ExtractFileName(s_File);
                        if (File.Exists(s_File) && !File.Exists(s_NewPath))
                        {
                            File.Copy(s_File, s_NewPath, true);
                            ImageList o_List = e_disp_content.LargeImageList;
                            ListViewItem o_Item = new ListViewItem(Checker.ExtractFileName(s_File), e_disp_content.Items.Count);
                            e_disp_content.Items.Add(o_Item);
                            o_List.Images.Add(Icon.ExtractAssociatedIcon(s_NewPath));
                        }
                        else if (Notify.Ask("File Error", "Sorry, the file '"+ Checker.ExtractFileName(s_File) + "' already exists. Do you want to replace it?"))
                        {
                            File.Copy(s_File, s_NewPath, true);

                        }
                        else continue;


                    }
                }
            }
        }

        private void UpdateName(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (Checker.CheckValid(e_nav_topic.Text))
                {
                    Projecthandler.Files.o_Sessions.o_Content[Projecthandler.Files.i_LoadedSession].s_Name = e_nav_topic.Text;
                    Projecthandler.Files.SaveConfig(Projecthandler.Files.i_LoadedSession);
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
                else
                {
                    e_nav_topic.Text= Projecthandler.Files.o_Sessions.o_Content[Projecthandler.Files.i_LoadedSession].s_Name;

                    Notify.Say("Invalid Name", "Sorry, but the charakters '][}:=#' are not allowed to be used in the session name.");
                }

            }
        }

        private void OpenSession(object sender, EventArgs e)
        {
            if (Router.i_CurrentProject != -1 && Projecthandler.s_Subjects.o_Content != null)
            {
                Win.o_Open.UpdateView();
                Win.o_Open.Show();
            }
        }
    }
}
