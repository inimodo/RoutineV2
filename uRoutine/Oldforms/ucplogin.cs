using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Source;
using Source.Style;
using Source.Routines;
using User.Messager;
using User.Forms;

namespace Source
{
    public partial class ucplogin : Form
    {
        private int i_animsize = 540;//290; 540
        private Size o_size = u_Stylesource.o_loginsize;
        private Color o_bordercolor = u_Stylesource.o_bordercolor;//Color.FromArgb(50, 50, 50);
        public ucplogin(string s_name,bool b_isnew,bool b_logginout)
        {
            InitializeComponent();

            s_softwarename = s_name;
            b_loggout = b_logginout;
            b_new = b_isnew;

            this.Size = o_size;
            this.BackColor = o_bordercolor;
            this.e_hide.Size = new Size(o_size.Width - 2, o_size.Height - 2);
            this.e_hide.Location = new Point(1, 1);
            this.e_nav.Location = new Point(1, 1);
            this.e_nav.Size = new Size(o_size.Width - 2, e_nav.Size.Height);


        }
        private string s_softwarename = "";

        public bool b_new;
        public bool b_loggout;
        public bool b_logged = false;
        public bool b_connected = true;
        public string s_name="none";
        public string s_code="none";


        public bool check(string s_checkid) {


            string s_geto_requesthttp = "https://www.ucpsystems.com/login.php";

            var s_text = Encoding.ASCII.GetBytes("request=" + s_checkid);

            HttpWebRequest o_requesthttp = (HttpWebRequest)WebRequest.Create(s_geto_requesthttp);

            o_requesthttp.Method = "POST";
            o_requesthttp.ContentType = "application/x-www-form-urlencoded";
            o_requesthttp.ContentLength = s_text.Length;

            Stream o_filestream = o_requesthttp.GetRequestStream();

            o_filestream.Write(s_text, 0, s_text.Length);
      
            HttpWebResponse o_responsehttp = (HttpWebResponse)o_requesthttp.GetResponse();

            StreamReader reader = new StreamReader(o_responsehttp.GetResponseStream());

            string s_html = reader.ReadToEnd();

            Console.WriteLine(s_html);
            if (s_html.Contains("false"))
            {
                return false;
            }

            string[] s_split = s_html.Split('#');
            s_code = s_split[0].Replace(" ", "");
            s_name = s_split[1].Replace(" ", "");

            return true;
        }
        public bool checkpass() {


            string s_geto_requesthttp = "https://www.ucpsystems.com/login.php";

            var s_text = Encoding.ASCII.GetBytes("name=" + s_name+"&check="+s_code);     

            HttpWebRequest o_requesthttp = (HttpWebRequest)WebRequest.Create(s_geto_requesthttp);

            o_requesthttp.Method = "POST";
            o_requesthttp.ContentType = "application/x-www-form-urlencoded";
            o_requesthttp.ContentLength = s_text.Length;

            Stream o_filestream = o_requesthttp.GetRequestStream();

            o_filestream.Write(s_text, 0, s_text.Length);

            HttpWebResponse o_responsehttp = (HttpWebResponse)o_requesthttp.GetResponse();

            StreamReader reader = new StreamReader(o_responsehttp.GetResponseStream());

            string s_html = reader.ReadToEnd();

            return s_html.Contains("true");

        }

        public bool loggout()
        {


            string s_geto_requesthttp = "https://www.ucpsystems.com/login.php";

            var s_text = Encoding.ASCII.GetBytes("delname=" + s_name + "&delcheck=" + s_code);

            HttpWebRequest o_requesthttp = (HttpWebRequest)WebRequest.Create(s_geto_requesthttp);

            o_requesthttp.Method = "POST";
            o_requesthttp.ContentType = "application/x-www-form-urlencoded";
            o_requesthttp.ContentLength = s_text.Length;

            Stream o_filestream = o_requesthttp.GetRequestStream();

            o_filestream.Write(s_text, 0, s_text.Length);

            HttpWebResponse o_responsehttp = (HttpWebResponse)o_requesthttp.GetResponse();

            StreamReader reader = new StreamReader(o_responsehttp.GetResponseStream());

            string s_html = reader.ReadToEnd();

            return s_html.Contains("true");

        }

        private void login(object sender, EventArgs e)
        {
            b_logged = check(e_input_name.Text);
            if (b_logged != true)
            {
                e_wrong.Visible = true;
            }
            else
            if (b_logged == true) {
                this.Close();
            }
        }

        private void openbrw(object sender, EventArgs e)
        {
              Process.Start("https://www.ucpsystems.com/login.php?stw=" + s_softwarename);

            this.Size = new Size(o_size.Width, i_animsize);
            this.e_hide.Size = new Size(o_size.Width - 2, i_animsize - 2);
        }

        private void ucplogin_Load(object sender, EventArgs e)
        {
            if (b_loggout) {
                loggout();
                this.Close();
                return;
            }
            if (!b_new) {
                try
                {
                    b_logged = checkpass();
                }
                catch 
                {
                    b_connected = false;
                    this.Close();
                }
                this.Close();
            }
        }


        private void openreg(object sender, EventArgs e)
        {
            Process.Start(@"https://www.ucpsystems.com/index.php?site=account");
        }

        private void skipreg(object sender, EventArgs e)
        {
            b_logged = false;

            this.Close();
        }

        Point p_relative;
        bool b_indrag = false;
        private void move(object sender, MouseEventArgs e)
        {
            if (b_indrag)
            {
                this.Location = new Point(Cursor.Position.X - p_relative.X, Cursor.Position.Y - p_relative.Y);
            }
        }

        private void move_stop(object sender, MouseEventArgs e)
        {
            b_indrag = false;
        }

        private void move_start(object sender, MouseEventArgs e)
        {
            p_relative = this.PointToClient(Cursor.Position);
            b_indrag = true;
        }



        private void close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_hover(object sender, EventArgs e)
        {
            e_nav_minimize.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimize_hover_leave(object sender, EventArgs e)
        {
            e_nav_minimize.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void close_hover_leave(object sender, EventArgs e)
        {
            e_nav_close.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void close_hover(object sender, EventArgs e)
        {
            e_nav_close.BackColor = Color.FromArgb(206, 50, 52);
        }

        private void clicksettup(object sender, EventArgs e)
        {
            if (File.Exists(u_Stringsource.s_version))
            {
                Process.Start(u_Stringsource.s_version+u_Stringsource.s_version_settings);
            }
            else//17
            {
                u_Message.Say(u_Stringsource.s_load_title[17], u_Stringsource.s_load_text[17],true);
            }
        }
    }
}
