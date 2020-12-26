namespace User.Action
{
    partial class ucpboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucpboard));
            this.e_nav_logo = new System.Windows.Forms.PictureBox();
            this.e_nav = new System.Windows.Forms.PictureBox();
            this.e_hider = new System.Windows.Forms.Panel();
            this.e_ico_manger = new System.Windows.Forms.PictureBox();
            this.e_ico_general = new System.Windows.Forms.PictureBox();
            this.e_div_one = new System.Windows.Forms.PictureBox();
            this.e_ico_all = new System.Windows.Forms.PictureBox();
            this.e_ico_create = new System.Windows.Forms.PictureBox();
            this.e_ico_share = new System.Windows.Forms.PictureBox();
            this.e_ico_appointments = new System.Windows.Forms.PictureBox();
            this.e_inp_topic = new System.Windows.Forms.TextBox();
            this.o_lesson = new User.ActionWindow.Lesson.ucplessondisp();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).BeginInit();
            this.e_hider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_manger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_general)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_all)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_create)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_share)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_appointments)).BeginInit();
            this.SuspendLayout();
            // 
            // e_nav_logo
            // 
            this.e_nav_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_logo.Image = global::User.Properties.Resources.LOGO;
            this.e_nav_logo.Location = new System.Drawing.Point(21, 1);
            this.e_nav_logo.Name = "e_nav_logo";
            this.e_nav_logo.Size = new System.Drawing.Size(30, 30);
            this.e_nav_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_logo.TabIndex = 17;
            this.e_nav_logo.TabStop = false;
            this.e_nav_logo.Click += new System.EventHandler(this.e_nav_logo_Click);
            // 
            // e_nav
            // 
            this.e_nav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav.Location = new System.Drawing.Point(1, 1);
            this.e_nav.Name = "e_nav";
            this.e_nav.Size = new System.Drawing.Size(603, 30);
            this.e_nav.TabIndex = 16;
            this.e_nav.TabStop = false;
            // 
            // e_hider
            // 
            this.e_hider.Controls.Add(this.e_ico_manger);
            this.e_hider.Controls.Add(this.e_ico_general);
            this.e_hider.Controls.Add(this.e_div_one);
            this.e_hider.Controls.Add(this.e_ico_all);
            this.e_hider.Controls.Add(this.e_ico_create);
            this.e_hider.Controls.Add(this.e_ico_share);
            this.e_hider.Controls.Add(this.e_ico_appointments);
            this.e_hider.Location = new System.Drawing.Point(446, 37);
            this.e_hider.Name = "e_hider";
            this.e_hider.Size = new System.Drawing.Size(70, 250);
            this.e_hider.TabIndex = 20;
            // 
            // e_ico_manger
            // 
            this.e_ico_manger.Image = global::User.Properties.Resources.markus_manager;
            this.e_ico_manger.Location = new System.Drawing.Point(20, 200);
            this.e_ico_manger.Name = "e_ico_manger";
            this.e_ico_manger.Size = new System.Drawing.Size(30, 30);
            this.e_ico_manger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_manger.TabIndex = 33;
            this.e_ico_manger.TabStop = false;
            this.e_ico_manger.Click += new System.EventHandler(this.click_manager);
            // 
            // e_ico_general
            // 
            this.e_ico_general.Image = global::User.Properties.Resources.settings;
            this.e_ico_general.Location = new System.Drawing.Point(20, 164);
            this.e_ico_general.Name = "e_ico_general";
            this.e_ico_general.Size = new System.Drawing.Size(30, 30);
            this.e_ico_general.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_general.TabIndex = 31;
            this.e_ico_general.TabStop = false;
            this.e_ico_general.Click += new System.EventHandler(this.click_general);
            // 
            // e_div_one
            // 
            this.e_div_one.BackColor = System.Drawing.Color.White;
            this.e_div_one.Location = new System.Drawing.Point(10, 157);
            this.e_div_one.Name = "e_div_one";
            this.e_div_one.Size = new System.Drawing.Size(50, 1);
            this.e_div_one.TabIndex = 32;
            this.e_div_one.TabStop = false;
            // 
            // e_ico_all
            // 
            this.e_ico_all.Image = global::User.Properties.Resources.homework;
            this.e_ico_all.Location = new System.Drawing.Point(20, 51);
            this.e_ico_all.Name = "e_ico_all";
            this.e_ico_all.Size = new System.Drawing.Size(30, 30);
            this.e_ico_all.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_all.TabIndex = 34;
            this.e_ico_all.TabStop = false;
            this.e_ico_all.Click += new System.EventHandler(this.click_all);
            // 
            // e_ico_create
            // 
            this.e_ico_create.Image = global::User.Properties.Resources.create;
            this.e_ico_create.Location = new System.Drawing.Point(20, 15);
            this.e_ico_create.Name = "e_ico_create";
            this.e_ico_create.Size = new System.Drawing.Size(30, 30);
            this.e_ico_create.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_create.TabIndex = 36;
            this.e_ico_create.TabStop = false;
            this.e_ico_create.Click += new System.EventHandler(this.click_create);
            // 
            // e_ico_share
            // 
            this.e_ico_share.Image = global::User.Properties.Resources.share;
            this.e_ico_share.Location = new System.Drawing.Point(20, 121);
            this.e_ico_share.Name = "e_ico_share";
            this.e_ico_share.Size = new System.Drawing.Size(30, 30);
            this.e_ico_share.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_share.TabIndex = 35;
            this.e_ico_share.TabStop = false;
            this.e_ico_share.Click += new System.EventHandler(this.click_share);
            // 
            // e_ico_appointments
            // 
            this.e_ico_appointments.Image = global::User.Properties.Resources.calendar;
            this.e_ico_appointments.Location = new System.Drawing.Point(20, 86);
            this.e_ico_appointments.Name = "e_ico_appointments";
            this.e_ico_appointments.Size = new System.Drawing.Size(30, 30);
            this.e_ico_appointments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_appointments.TabIndex = 37;
            this.e_ico_appointments.TabStop = false;
            this.e_ico_appointments.Click += new System.EventHandler(this.click_appointment);
            // 
            // e_inp_topic
            // 
            this.e_inp_topic.AcceptsReturn = true;
            this.e_inp_topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_inp_topic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_topic.Font = new System.Drawing.Font("Logico Sans", 12F);
            this.e_inp_topic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_inp_topic.Location = new System.Drawing.Point(56, 6);
            this.e_inp_topic.Name = "e_inp_topic";
            this.e_inp_topic.Size = new System.Drawing.Size(191, 19);
            this.e_inp_topic.TabIndex = 65;
            this.e_inp_topic.Text = "Topic";
            this.e_inp_topic.TextChanged += new System.EventHandler(this.event_edittopic);
            this.e_inp_topic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.event_entertext);
            // 
            // o_lesson
            // 
            this.o_lesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.o_lesson.Cursor = System.Windows.Forms.Cursors.Default;
            this.o_lesson.ForeColor = System.Drawing.Color.White;
            this.o_lesson.Location = new System.Drawing.Point(1, 37);
            this.o_lesson.Name = "o_lesson";
            this.o_lesson.Size = new System.Drawing.Size(180, 179);
            this.o_lesson.TabIndex = 21;
            // 
            // ucpboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(605, 308);
            this.Controls.Add(this.e_inp_topic);
            this.Controls.Add(this.o_lesson);
            this.Controls.Add(this.e_hider);
            this.Controls.Add(this.e_nav_logo);
            this.Controls.Add(this.e_nav);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ucpboard";
            this.ShowInTaskbar = false;
            this.Text = "WINDOWNAME";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.event_focus);
            this.Deactivate += new System.EventHandler(this.event_unfocus);
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).EndInit();
            this.e_hider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_manger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_general)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_one)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_all)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_create)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_share)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_appointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox e_nav_logo;
        private System.Windows.Forms.PictureBox e_nav;
        private System.Windows.Forms.Panel e_hider;
        private System.Windows.Forms.PictureBox e_ico_manger;
        private System.Windows.Forms.PictureBox e_ico_general;
        private System.Windows.Forms.PictureBox e_div_one;
        private System.Windows.Forms.PictureBox e_ico_all;
        private System.Windows.Forms.PictureBox e_ico_create;
        private System.Windows.Forms.PictureBox e_ico_share;
        private System.Windows.Forms.PictureBox e_ico_appointments;
        private ActionWindow.Lesson.ucplessondisp o_lesson;
        private System.Windows.Forms.TextBox e_inp_topic;
    }
}