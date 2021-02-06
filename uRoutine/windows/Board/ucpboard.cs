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
    public partial class ucpboard : Form 
    {
        public static class Win
        {
            public static ucpsettings o_Settings = new ucpsettings();
        }
        public static class Data
        {
            public static bool b_OpenedSession=true;
        }
        public ucpboard(string[] s_args)
        {
            InitializeComponent();
            Winstyle.Apply(this,new Size(390,235),"Routine");
            Router.LoadData();

        }

        private void CloseSession(object sender, EventArgs e)
        {
            if (Data.b_OpenedSession)
            {
                Data.b_OpenedSession = false;
                UpdateWindowState();
            }
            else this.Close();
        }

        public void UpdateWindowState()
        {
            if (!Data.b_OpenedSession)
            {
                this.Size = new Size(72, this.Size.Height);
                this.e_disp_subjects.Hide();
                this.e_nav_topic.Hide();
                this.e_hider.Location = new Point(1, this.e_hider.Location.Y);
                this.e_nav_logo.Location = new Point(20, this.e_nav_logo.Location.Y);

            }
            else
            {
                this.Size = new Size(392, this.Size.Height);
                this.e_disp_subjects.Show();
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
    }
}
