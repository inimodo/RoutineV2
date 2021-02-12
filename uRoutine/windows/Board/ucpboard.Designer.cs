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
            this.e_nav_grab = new System.Windows.Forms.PictureBox();
            this.e_hider = new System.Windows.Forms.Panel();
            this.e_ico_manger = new System.Windows.Forms.PictureBox();
            this.e_ico_general = new System.Windows.Forms.PictureBox();
            this.e_ico_all = new System.Windows.Forms.PictureBox();
            this.e_ico_create = new System.Windows.Forms.PictureBox();
            this.e_ico_share = new System.Windows.Forms.PictureBox();
            this.e_ico_appointments = new System.Windows.Forms.PictureBox();
            this.e_nav_topic = new System.Windows.Forms.TextBox();
            this.e_disp_subjects = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_grab)).BeginInit();
            this.e_hider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_manger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_general)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_all)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_create)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_share)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_appointments)).BeginInit();
            this.SuspendLayout();
            // 
            // e_nav_logo
            // 
            this.e_nav_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_logo.Image = global::User.Properties.Resources.logo;
            this.e_nav_logo.Location = new System.Drawing.Point(10, 1);
            this.e_nav_logo.Name = "e_nav_logo";
            this.e_nav_logo.Size = new System.Drawing.Size(30, 30);
            this.e_nav_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_logo.TabIndex = 17;
            this.e_nav_logo.TabStop = false;
            this.e_nav_logo.Click += new System.EventHandler(this.CloseSession);
            // 
            // e_nav_grab
            // 
            this.e_nav_grab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_nav_grab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_grab.Location = new System.Drawing.Point(1, 1);
            this.e_nav_grab.Name = "e_nav_grab";
            this.e_nav_grab.Size = new System.Drawing.Size(424, 30);
            this.e_nav_grab.TabIndex = 16;
            this.e_nav_grab.TabStop = false;
            // 
            // e_hider
            // 
            this.e_hider.Controls.Add(this.e_ico_manger);
            this.e_hider.Controls.Add(this.e_ico_general);
            this.e_hider.Controls.Add(this.e_ico_all);
            this.e_hider.Controls.Add(this.e_ico_create);
            this.e_hider.Controls.Add(this.e_ico_share);
            this.e_hider.Controls.Add(this.e_ico_appointments);
            this.e_hider.Location = new System.Drawing.Point(321, 31);
            this.e_hider.Name = "e_hider";
            this.e_hider.Size = new System.Drawing.Size(70, 235);
            this.e_hider.TabIndex = 20;
            // 
            // e_ico_manger
            // 
            this.e_ico_manger.Image = global::User.Properties.Resources.settings2;
            this.e_ico_manger.Location = new System.Drawing.Point(20, 155);
            this.e_ico_manger.Name = "e_ico_manger";
            this.e_ico_manger.Size = new System.Drawing.Size(30, 30);
            this.e_ico_manger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_manger.TabIndex = 33;
            this.e_ico_manger.TabStop = false;
            this.e_ico_manger.Click += new System.EventHandler(this.OpenSubjects);
            // 
            // e_ico_general
            // 
            this.e_ico_general.Image = global::User.Properties.Resources.settings;
            this.e_ico_general.Location = new System.Drawing.Point(20, 190);
            this.e_ico_general.Name = "e_ico_general";
            this.e_ico_general.Size = new System.Drawing.Size(30, 30);
            this.e_ico_general.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_general.TabIndex = 31;
            this.e_ico_general.TabStop = false;
            this.e_ico_general.Click += new System.EventHandler(this.OpenSettings);
            // 
            // e_ico_all
            // 
            this.e_ico_all.Image = global::User.Properties.Resources.homework;
            this.e_ico_all.Location = new System.Drawing.Point(20, 50);
            this.e_ico_all.Name = "e_ico_all";
            this.e_ico_all.Size = new System.Drawing.Size(30, 30);
            this.e_ico_all.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_all.TabIndex = 34;
            this.e_ico_all.TabStop = false;
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
            this.e_ico_create.Click += new System.EventHandler(this.CreateSession);
            // 
            // e_ico_share
            // 
            this.e_ico_share.Image = global::User.Properties.Resources.share;
            this.e_ico_share.Location = new System.Drawing.Point(20, 120);
            this.e_ico_share.Name = "e_ico_share";
            this.e_ico_share.Size = new System.Drawing.Size(30, 30);
            this.e_ico_share.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_share.TabIndex = 35;
            this.e_ico_share.TabStop = false;
            // 
            // e_ico_appointments
            // 
            this.e_ico_appointments.Image = global::User.Properties.Resources.calendar;
            this.e_ico_appointments.Location = new System.Drawing.Point(20, 85);
            this.e_ico_appointments.Name = "e_ico_appointments";
            this.e_ico_appointments.Size = new System.Drawing.Size(30, 30);
            this.e_ico_appointments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_appointments.TabIndex = 37;
            this.e_ico_appointments.TabStop = false;
            // 
            // e_nav_topic
            // 
            this.e_nav_topic.AcceptsReturn = true;
            this.e_nav_topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_topic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_nav_topic.Font = new System.Drawing.Font("Logico Sans", 12F);
            this.e_nav_topic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_nav_topic.Location = new System.Drawing.Point(46, 6);
            this.e_nav_topic.Name = "e_nav_topic";
            this.e_nav_topic.Size = new System.Drawing.Size(191, 19);
            this.e_nav_topic.TabIndex = 65;
            this.e_nav_topic.Text = "Topic";
            // 
            // e_disp_subjects
            // 
            this.e_disp_subjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_disp_subjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_disp_subjects.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_disp_subjects.ForeColor = System.Drawing.Color.White;
            this.e_disp_subjects.HideSelection = false;
            this.e_disp_subjects.Location = new System.Drawing.Point(1, 31);
            this.e_disp_subjects.MultiSelect = false;
            this.e_disp_subjects.Name = "e_disp_subjects";
            this.e_disp_subjects.Size = new System.Drawing.Size(320, 235);
            this.e_disp_subjects.TabIndex = 124;
            this.e_disp_subjects.TileSize = new System.Drawing.Size(20, 20);
            this.e_disp_subjects.UseCompatibleStateImageBehavior = false;
            this.e_disp_subjects.View = System.Windows.Forms.View.SmallIcon;
            // 
            // ucpboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(426, 282);
            this.Controls.Add(this.e_disp_subjects);
            this.Controls.Add(this.e_nav_topic);
            this.Controls.Add(this.e_hider);
            this.Controls.Add(this.e_nav_logo);
            this.Controls.Add(this.e_nav_grab);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ucpboard";
            this.ShowInTaskbar = false;
            this.Text = "WINDOWNAME";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Loading);
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_grab)).EndInit();
            this.e_hider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_manger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_general)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_all)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_create)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_share)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_appointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox e_nav_logo;
        private System.Windows.Forms.PictureBox e_nav_grab;
        private System.Windows.Forms.Panel e_hider;
        private System.Windows.Forms.PictureBox e_ico_manger;
        private System.Windows.Forms.PictureBox e_ico_general;
        private System.Windows.Forms.PictureBox e_ico_all;
        private System.Windows.Forms.PictureBox e_ico_create;
        private System.Windows.Forms.PictureBox e_ico_share;
        private System.Windows.Forms.PictureBox e_ico_appointments;
        private System.Windows.Forms.TextBox e_nav_topic;
        private System.Windows.Forms.ListView e_disp_subjects;
    }
}