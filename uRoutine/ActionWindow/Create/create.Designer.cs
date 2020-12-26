namespace User.Action
{
    partial class ucpcreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucpcreate));
            this.e_nav_title = new System.Windows.Forms.Label();
            this.e_nav_logo = new System.Windows.Forms.PictureBox();
            this.e_nav = new System.Windows.Forms.PictureBox();
            this.e_hider = new System.Windows.Forms.Panel();
            this.e_inp_fileending_remove = new System.Windows.Forms.PictureBox();
            this.e_inp_fileending_add = new System.Windows.Forms.PictureBox();
            this.e_inp_topic = new System.Windows.Forms.TextBox();
            this.e_div_five = new System.Windows.Forms.PictureBox();
            this.e_but_create = new System.Windows.Forms.Button();
            this.e_inp_fileending = new System.Windows.Forms.TextBox();
            this.e_div_six = new System.Windows.Forms.PictureBox();
            this.e_disp_fileending = new System.Windows.Forms.ListView();
            this.e_sel_subject = new System.Windows.Forms.DomainUpDown();
            this.e_div_two = new System.Windows.Forms.PictureBox();
            this.e_div_three = new System.Windows.Forms.PictureBox();
            this.e_nav_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).BeginInit();
            this.e_hider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_inp_fileending_remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_inp_fileending_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_five)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_six)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_three)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).BeginInit();
            this.SuspendLayout();
            // 
            // e_nav_title
            // 
            this.e_nav_title.AutoSize = true;
            this.e_nav_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_title.Font = new System.Drawing.Font("Logico Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_nav_title.ForeColor = System.Drawing.Color.White;
            this.e_nav_title.Location = new System.Drawing.Point(47, 6);
            this.e_nav_title.Name = "e_nav_title";
            this.e_nav_title.Size = new System.Drawing.Size(222, 19);
            this.e_nav_title.TabIndex = 18;
            this.e_nav_title.Text = "THENAMEOFTHESOFTWARE";
            // 
            // e_nav_logo
            // 
            this.e_nav_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_logo.Image = global::User.Properties.Resources.LOGO;
            this.e_nav_logo.Location = new System.Drawing.Point(10, 1);
            this.e_nav_logo.Name = "e_nav_logo";
            this.e_nav_logo.Size = new System.Drawing.Size(30, 30);
            this.e_nav_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_logo.TabIndex = 17;
            this.e_nav_logo.TabStop = false;
            // 
            // e_nav
            // 
            this.e_nav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav.Location = new System.Drawing.Point(1, 1);
            this.e_nav.Name = "e_nav";
            this.e_nav.Size = new System.Drawing.Size(551, 30);
            this.e_nav.TabIndex = 16;
            this.e_nav.TabStop = false;
            this.e_nav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_start);
            this.e_nav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_run);
            this.e_nav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_stop);
            // 
            // e_hider
            // 
            this.e_hider.Controls.Add(this.e_inp_fileending_remove);
            this.e_hider.Controls.Add(this.e_inp_fileending_add);
            this.e_hider.Controls.Add(this.e_inp_topic);
            this.e_hider.Controls.Add(this.e_div_five);
            this.e_hider.Controls.Add(this.e_but_create);
            this.e_hider.Controls.Add(this.e_inp_fileending);
            this.e_hider.Controls.Add(this.e_div_six);
            this.e_hider.Controls.Add(this.e_disp_fileending);
            this.e_hider.Controls.Add(this.e_sel_subject);
            this.e_hider.Controls.Add(this.e_div_two);
            this.e_hider.Controls.Add(this.e_div_three);
            this.e_hider.Location = new System.Drawing.Point(1, 31);
            this.e_hider.Name = "e_hider";
            this.e_hider.Size = new System.Drawing.Size(275, 200);
            this.e_hider.TabIndex = 20;
            // 
            // e_inp_fileending_remove
            // 
            this.e_inp_fileending_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_inp_fileending_remove.Image = global::User.Properties.Resources.delete;
            this.e_inp_fileending_remove.Location = new System.Drawing.Point(204, 118);
            this.e_inp_fileending_remove.Name = "e_inp_fileending_remove";
            this.e_inp_fileending_remove.Size = new System.Drawing.Size(30, 30);
            this.e_inp_fileending_remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_inp_fileending_remove.TabIndex = 82;
            this.e_inp_fileending_remove.TabStop = false;
            this.e_inp_fileending_remove.Click += new System.EventHandler(this.click_fe_remove);
            // 
            // e_inp_fileending_add
            // 
            this.e_inp_fileending_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_inp_fileending_add.Image = global::User.Properties.Resources.create;
            this.e_inp_fileending_add.Location = new System.Drawing.Point(168, 118);
            this.e_inp_fileending_add.Name = "e_inp_fileending_add";
            this.e_inp_fileending_add.Size = new System.Drawing.Size(30, 30);
            this.e_inp_fileending_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_inp_fileending_add.TabIndex = 83;
            this.e_inp_fileending_add.TabStop = false;
            this.e_inp_fileending_add.Click += new System.EventHandler(this.click_fe_add);
            // 
            // e_inp_topic
            // 
            this.e_inp_topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_inp_topic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_topic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.e_inp_topic.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_topic.ForeColor = System.Drawing.Color.White;
            this.e_inp_topic.Location = new System.Drawing.Point(16, 17);
            this.e_inp_topic.MaxLength = 100;
            this.e_inp_topic.Name = "e_inp_topic";
            this.e_inp_topic.Size = new System.Drawing.Size(239, 21);
            this.e_inp_topic.TabIndex = 49;
            this.e_inp_topic.Text = "DEFAULT TOPIC";
            // 
            // e_div_five
            // 
            this.e_div_five.BackColor = System.Drawing.Color.White;
            this.e_div_five.Location = new System.Drawing.Point(168, 111);
            this.e_div_five.Name = "e_div_five";
            this.e_div_five.Size = new System.Drawing.Size(87, 1);
            this.e_div_five.TabIndex = 76;
            this.e_div_five.TabStop = false;
            // 
            // e_but_create
            // 
            this.e_but_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_create.Location = new System.Drawing.Point(168, 154);
            this.e_but_create.Name = "e_but_create";
            this.e_but_create.Size = new System.Drawing.Size(87, 23);
            this.e_but_create.TabIndex = 52;
            this.e_but_create.Text = "Create";
            this.e_but_create.UseVisualStyleBackColor = true;
            this.e_but_create.Click += new System.EventHandler(this.click_fe);
            // 
            // e_inp_fileending
            // 
            this.e_inp_fileending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_inp_fileending.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_fileending.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_fileending.ForeColor = System.Drawing.Color.White;
            this.e_inp_fileending.Location = new System.Drawing.Point(168, 91);
            this.e_inp_fileending.MaxLength = 8;
            this.e_inp_fileending.Name = "e_inp_fileending";
            this.e_inp_fileending.Size = new System.Drawing.Size(87, 21);
            this.e_inp_fileending.TabIndex = 60;
            // 
            // e_div_six
            // 
            this.e_div_six.BackColor = System.Drawing.Color.White;
            this.e_div_six.Location = new System.Drawing.Point(16, 176);
            this.e_div_six.Name = "e_div_six";
            this.e_div_six.Size = new System.Drawing.Size(144, 1);
            this.e_div_six.TabIndex = 75;
            this.e_div_six.TabStop = false;
            // 
            // e_disp_fileending
            // 
            this.e_disp_fileending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_disp_fileending.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_disp_fileending.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_disp_fileending.ForeColor = System.Drawing.Color.White;
            this.e_disp_fileending.HideSelection = false;
            this.e_disp_fileending.Location = new System.Drawing.Point(16, 91);
            this.e_disp_fileending.MultiSelect = false;
            this.e_disp_fileending.Name = "e_disp_fileending";
            this.e_disp_fileending.Size = new System.Drawing.Size(144, 86);
            this.e_disp_fileending.TabIndex = 71;
            this.e_disp_fileending.TileSize = new System.Drawing.Size(20, 20);
            this.e_disp_fileending.UseCompatibleStateImageBehavior = false;
            this.e_disp_fileending.View = System.Windows.Forms.View.SmallIcon;
            // 
            // e_sel_subject
            // 
            this.e_sel_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_sel_subject.Font = new System.Drawing.Font("Logico Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_sel_subject.InterceptArrowKeys = false;
            this.e_sel_subject.Location = new System.Drawing.Point(16, 55);
            this.e_sel_subject.Name = "e_sel_subject";
            this.e_sel_subject.ReadOnly = true;
            this.e_sel_subject.Size = new System.Drawing.Size(239, 21);
            this.e_sel_subject.TabIndex = 53;
            this.e_sel_subject.SelectedItemChanged += new System.EventHandler(this.click_fe_sel);
            // 
            // e_div_two
            // 
            this.e_div_two.BackColor = System.Drawing.Color.White;
            this.e_div_two.Location = new System.Drawing.Point(16, 37);
            this.e_div_two.Name = "e_div_two";
            this.e_div_two.Size = new System.Drawing.Size(239, 1);
            this.e_div_two.TabIndex = 72;
            this.e_div_two.TabStop = false;
            // 
            // e_div_three
            // 
            this.e_div_three.BackColor = System.Drawing.Color.White;
            this.e_div_three.Location = new System.Drawing.Point(16, 75);
            this.e_div_three.Name = "e_div_three";
            this.e_div_three.Size = new System.Drawing.Size(239, 1);
            this.e_div_three.TabIndex = 73;
            this.e_div_three.TabStop = false;
            // 
            // e_nav_close
            // 
            this.e_nav_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_close.Image = ((System.Drawing.Image)(resources.GetObject("e_nav_close.Image")));
            this.e_nav_close.Location = new System.Drawing.Point(520, 5);
            this.e_nav_close.Name = "e_nav_close";
            this.e_nav_close.Size = new System.Drawing.Size(20, 20);
            this.e_nav_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_close.TabIndex = 21;
            this.e_nav_close.TabStop = false;
            this.e_nav_close.Click += new System.EventHandler(this.event_close);
            // 
            // ucpcreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(552, 375);
            this.Controls.Add(this.e_nav_close);
            this.Controls.Add(this.e_nav_title);
            this.Controls.Add(this.e_nav_logo);
            this.Controls.Add(this.e_nav);
            this.Controls.Add(this.e_hider);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ucpcreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WINDOWNAME";
            this.Activated += new System.EventHandler(this.event_focus);
            this.Deactivate += new System.EventHandler(this.event_unfocus);
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).EndInit();
            this.e_hider.ResumeLayout(false);
            this.e_hider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_inp_fileending_remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_inp_fileending_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_five)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_six)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_three)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label e_nav_title;
        private System.Windows.Forms.PictureBox e_nav_logo;
        private System.Windows.Forms.PictureBox e_nav;
        private System.Windows.Forms.Panel e_hider;
        private System.Windows.Forms.DomainUpDown e_sel_subject;
        private System.Windows.Forms.Button e_but_create;
        private System.Windows.Forms.TextBox e_inp_topic;
        private System.Windows.Forms.TextBox e_inp_fileending;
        private System.Windows.Forms.ListView e_disp_fileending;
        private System.Windows.Forms.PictureBox e_div_two;
        private System.Windows.Forms.PictureBox e_div_three;
        private System.Windows.Forms.PictureBox e_div_six;
        private System.Windows.Forms.PictureBox e_div_five;
        private System.Windows.Forms.PictureBox e_inp_fileending_remove;
        private System.Windows.Forms.PictureBox e_inp_fileending_add;
        private System.Windows.Forms.PictureBox e_nav_close;
    }
}