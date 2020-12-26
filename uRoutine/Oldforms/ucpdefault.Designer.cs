namespace User
{
    partial class ucpdefault
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucpdefault));
            this.e_nav_title = new System.Windows.Forms.Label();
            this.e_nav_user = new System.Windows.Forms.Label();
            this.e_windows = new System.Windows.Forms.NotifyIcon(this.components);
            this.e_nav_pad = new System.Windows.Forms.PictureBox();
            this.e_nav_minimize = new System.Windows.Forms.PictureBox();
            this.e_nav_close = new System.Windows.Forms.PictureBox();
            this.e_nav_loggout = new System.Windows.Forms.PictureBox();
            this.e_nav_logo = new System.Windows.Forms.PictureBox();
            this.e_nav = new System.Windows.Forms.PictureBox();
            this.e_hider = new System.Windows.Forms.PictureBox();
            this.e_tog_smartstart = new System.Windows.Forms.CheckBox();
            this.e_info_version = new System.Windows.Forms.Label();
            this.e_ucplogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_pad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_loggout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_hider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ucplogo)).BeginInit();
            this.SuspendLayout();
            // 
            // e_nav_title
            // 
            this.e_nav_title.AutoSize = true;
            this.e_nav_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_title.Font = new System.Drawing.Font("Logico Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_nav_title.ForeColor = System.Drawing.Color.White;
            this.e_nav_title.Location = new System.Drawing.Point(48, 6);
            this.e_nav_title.Name = "e_nav_title";
            this.e_nav_title.Size = new System.Drawing.Size(222, 19);
            this.e_nav_title.TabIndex = 9;
            this.e_nav_title.Text = "THENAMEOFTHESOFTWARE";
            // 
            // e_nav_user
            // 
            this.e_nav_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_user.Font = new System.Drawing.Font("Logico Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_nav_user.ForeColor = System.Drawing.Color.White;
            this.e_nav_user.Location = new System.Drawing.Point(898, 5);
            this.e_nav_user.Name = "e_nav_user";
            this.e_nav_user.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.e_nav_user.Size = new System.Drawing.Size(140, 20);
            this.e_nav_user.TabIndex = 12;
            this.e_nav_user.Text = "username";
            // 
            // e_windows
            // 
            this.e_windows.BalloonTipText = "Tip";
            this.e_windows.BalloonTipTitle = "Title";
            this.e_windows.Icon = ((System.Drawing.Icon)(resources.GetObject("e_windows.Icon")));
            this.e_windows.Text = "THENAMEOFTHESOFTWARE";
            this.e_windows.Visible = true;
            this.e_windows.Click += new System.EventHandler(this.event_reopen);
            // 
            // e_nav_pad
            // 
            this.e_nav_pad.BackColor = System.Drawing.Color.White;
            this.e_nav_pad.Location = new System.Drawing.Point(1079, 5);
            this.e_nav_pad.Name = "e_nav_pad";
            this.e_nav_pad.Size = new System.Drawing.Size(1, 20);
            this.e_nav_pad.TabIndex = 17;
            this.e_nav_pad.TabStop = false;
            // 
            // e_nav_minimize
            // 
            this.e_nav_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_minimize.Image = ((System.Drawing.Image)(resources.GetObject("e_nav_minimize.Image")));
            this.e_nav_minimize.Location = new System.Drawing.Point(1094, 5);
            this.e_nav_minimize.Name = "e_nav_minimize";
            this.e_nav_minimize.Size = new System.Drawing.Size(20, 20);
            this.e_nav_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_minimize.TabIndex = 16;
            this.e_nav_minimize.TabStop = false;
            this.e_nav_minimize.Click += new System.EventHandler(this.Minimize);
            this.e_nav_minimize.MouseLeave += new System.EventHandler(this.Minimize_hover_leave);
            this.e_nav_minimize.MouseHover += new System.EventHandler(this.Minimize_hover);
            // 
            // e_nav_close
            // 
            this.e_nav_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_close.Image = ((System.Drawing.Image)(resources.GetObject("e_nav_close.Image")));
            this.e_nav_close.Location = new System.Drawing.Point(1120, 5);
            this.e_nav_close.Name = "e_nav_close";
            this.e_nav_close.Size = new System.Drawing.Size(20, 20);
            this.e_nav_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_close.TabIndex = 15;
            this.e_nav_close.TabStop = false;
            this.e_nav_close.Click += new System.EventHandler(this.Close);
            this.e_nav_close.MouseLeave += new System.EventHandler(this.Close_hover_leave);
            this.e_nav_close.MouseHover += new System.EventHandler(this.Close_hover);
            // 
            // e_nav_loggout
            // 
            this.e_nav_loggout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_loggout.Image = global::User.Properties.Resources.login;
            this.e_nav_loggout.Location = new System.Drawing.Point(1044, 5);
            this.e_nav_loggout.Name = "e_nav_loggout";
            this.e_nav_loggout.Size = new System.Drawing.Size(20, 20);
            this.e_nav_loggout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_loggout.TabIndex = 13;
            this.e_nav_loggout.TabStop = false;
            this.e_nav_loggout.Click += new System.EventHandler(this.Loggout);
            // 
            // e_nav_logo
            // 
            this.e_nav_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_logo.Image = global::User.Properties.Resources.LOGO;
            this.e_nav_logo.Location = new System.Drawing.Point(12, 0);
            this.e_nav_logo.Name = "e_nav_logo";
            this.e_nav_logo.Size = new System.Drawing.Size(30, 30);
            this.e_nav_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_logo.TabIndex = 8;
            this.e_nav_logo.TabStop = false;
            // 
            // e_nav
            // 
            this.e_nav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav.Location = new System.Drawing.Point(0, 0);
            this.e_nav.Name = "e_nav";
            this.e_nav.Size = new System.Drawing.Size(1150, 30);
            this.e_nav.TabIndex = 7;
            this.e_nav.TabStop = false;
            this.e_nav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_start);
            this.e_nav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_run);
            this.e_nav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_stop);
            // 
            // e_hider
            // 
            this.e_hider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_hider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.e_hider.Location = new System.Drawing.Point(1, 31);
            this.e_hider.Name = "e_hider";
            this.e_hider.Size = new System.Drawing.Size(334, 40);
            this.e_hider.TabIndex = 7;
            this.e_hider.TabStop = false;
            // 
            // e_tog_smartstart
            // 
            this.e_tog_smartstart.AutoSize = true;
            this.e_tog_smartstart.Font = new System.Drawing.Font("Logico Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_tog_smartstart.Location = new System.Drawing.Point(156, 38);
            this.e_tog_smartstart.Name = "e_tog_smartstart";
            this.e_tog_smartstart.Size = new System.Drawing.Size(162, 22);
            this.e_tog_smartstart.TabIndex = 122;
            this.e_tog_smartstart.Text = "Checks for Updates ";
            this.e_tog_smartstart.UseVisualStyleBackColor = true;
            this.e_tog_smartstart.CheckedChanged += new System.EventHandler(this.sel_smartstart);
            // 
            // e_info_version
            // 
            this.e_info_version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_version.Font = new System.Drawing.Font("Logico Sans", 9F);
            this.e_info_version.ForeColor = System.Drawing.Color.White;
            this.e_info_version.Location = new System.Drawing.Point(49, 36);
            this.e_info_version.Name = "e_info_version";
            this.e_info_version.Size = new System.Drawing.Size(101, 24);
            this.e_info_version.TabIndex = 125;
            this.e_info_version.Text = "Version 1.0";
            this.e_info_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // e_ucplogo
            // 
            this.e_ucplogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_ucplogo.Image = global::User.Properties.Resources.ucp_logo;
            this.e_ucplogo.Location = new System.Drawing.Point(12, 36);
            this.e_ucplogo.Name = "e_ucplogo";
            this.e_ucplogo.Size = new System.Drawing.Size(23, 23);
            this.e_ucplogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ucplogo.TabIndex = 126;
            this.e_ucplogo.TabStop = false;
            // 
            // ucpdefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 532);
            this.Controls.Add(this.e_ucplogo);
            this.Controls.Add(this.e_tog_smartstart);
            this.Controls.Add(this.e_info_version);
            this.Controls.Add(this.e_nav_pad);
            this.Controls.Add(this.e_nav_minimize);
            this.Controls.Add(this.e_nav_close);
            this.Controls.Add(this.e_nav_loggout);
            this.Controls.Add(this.e_nav_user);
            this.Controls.Add(this.e_nav_title);
            this.Controls.Add(this.e_nav_logo);
            this.Controls.Add(this.e_nav);
            this.Controls.Add(this.e_hider);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ucpdefault";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THENAMEOFTHESOFTWARE";
            this.Activated += new System.EventHandler(this.event_focus);
            this.Deactivate += new System.EventHandler(this.event_unfocus);
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_pad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_loggout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_hider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ucplogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label      e_nav_title;
        private System.Windows.Forms.PictureBox e_nav_logo;
        private System.Windows.Forms.PictureBox e_nav;
        private System.Windows.Forms.Label      e_nav_user;
        private System.Windows.Forms.PictureBox e_nav_loggout;
        private System.Windows.Forms.PictureBox e_nav_minimize;
        private System.Windows.Forms.PictureBox e_nav_close;
        private System.Windows.Forms.PictureBox e_nav_pad;
        private System.Windows.Forms.NotifyIcon e_windows;
        public System.Windows.Forms.PictureBox e_hider;
        private System.Windows.Forms.CheckBox e_tog_smartstart;
        private System.Windows.Forms.Label e_info_version;
        private System.Windows.Forms.PictureBox e_ucplogo;
    }
}

