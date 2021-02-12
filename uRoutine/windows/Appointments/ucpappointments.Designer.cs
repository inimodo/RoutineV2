namespace User.Action
{
    partial class ucpappointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucpappointments));
            this.e_nav_title = new System.Windows.Forms.Label();
            this.e_nav_logo = new System.Windows.Forms.PictureBox();
            this.e_nav = new System.Windows.Forms.PictureBox();
            this.e_hider = new System.Windows.Forms.Panel();
            this.e_but_file_rename = new System.Windows.Forms.PictureBox();
            this.e_inp_addiontional = new System.Windows.Forms.RichTextBox();
            this.e_disp_homework = new System.Windows.Forms.ListView();
            this.e_but_file_remove = new System.Windows.Forms.PictureBox();
            this.e_but_file_add = new System.Windows.Forms.PictureBox();
            this.e_nav_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).BeginInit();
            this.e_hider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_rename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_add)).BeginInit();
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
            this.e_nav_logo.Image = global::User.Properties.Resources.logo;
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
            this.e_nav.Size = new System.Drawing.Size(467, 30);
            this.e_nav.TabIndex = 16;
            this.e_nav.TabStop = false;
            // 
            // e_hider
            // 
            this.e_hider.Controls.Add(this.e_but_file_rename);
            this.e_hider.Controls.Add(this.e_inp_addiontional);
            this.e_hider.Controls.Add(this.e_disp_homework);
            this.e_hider.Controls.Add(this.e_but_file_remove);
            this.e_hider.Controls.Add(this.e_but_file_add);
            this.e_hider.Location = new System.Drawing.Point(1, 31);
            this.e_hider.Name = "e_hider";
            this.e_hider.Size = new System.Drawing.Size(280, 320);
            this.e_hider.TabIndex = 20;
            // 
            // e_but_file_rename
            // 
            this.e_but_file_rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_rename.Image = global::User.Properties.Resources.edit;
            this.e_but_file_rename.Location = new System.Drawing.Point(238, 231);
            this.e_but_file_rename.Name = "e_but_file_rename";
            this.e_but_file_rename.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_rename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_rename.TabIndex = 120;
            this.e_but_file_rename.TabStop = false;
            // 
            // e_inp_addiontional
            // 
            this.e_inp_addiontional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_addiontional.DetectUrls = false;
            this.e_inp_addiontional.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_addiontional.Location = new System.Drawing.Point(9, 159);
            this.e_inp_addiontional.Name = "e_inp_addiontional";
            this.e_inp_addiontional.RightMargin = 420;
            this.e_inp_addiontional.Size = new System.Drawing.Size(223, 149);
            this.e_inp_addiontional.TabIndex = 118;
            this.e_inp_addiontional.Text = "";
            // 
            // e_disp_homework
            // 
            this.e_disp_homework.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.e_disp_homework.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_disp_homework.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_disp_homework.Font = new System.Drawing.Font("Logico Sans", 10F);
            this.e_disp_homework.ForeColor = System.Drawing.Color.White;
            this.e_disp_homework.HideSelection = false;
            this.e_disp_homework.Location = new System.Drawing.Point(11, 6);
            this.e_disp_homework.MultiSelect = false;
            this.e_disp_homework.Name = "e_disp_homework";
            this.e_disp_homework.Size = new System.Drawing.Size(257, 147);
            this.e_disp_homework.TabIndex = 104;
            this.e_disp_homework.TileSize = new System.Drawing.Size(100, 20);
            this.e_disp_homework.UseCompatibleStateImageBehavior = false;
            this.e_disp_homework.View = System.Windows.Forms.View.SmallIcon;
            // 
            // e_but_file_remove
            // 
            this.e_but_file_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_remove.Image = global::User.Properties.Resources.delete;
            this.e_but_file_remove.Location = new System.Drawing.Point(238, 195);
            this.e_but_file_remove.Name = "e_but_file_remove";
            this.e_but_file_remove.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_remove.TabIndex = 121;
            this.e_but_file_remove.TabStop = false;
            // 
            // e_but_file_add
            // 
            this.e_but_file_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_add.Image = global::User.Properties.Resources.create;
            this.e_but_file_add.Location = new System.Drawing.Point(238, 159);
            this.e_but_file_add.Name = "e_but_file_add";
            this.e_but_file_add.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_add.TabIndex = 122;
            this.e_but_file_add.TabStop = false;
            // 
            // e_nav_close
            // 
            this.e_nav_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_close.Image = ((System.Drawing.Image)(resources.GetObject("e_nav_close.Image")));
            this.e_nav_close.Location = new System.Drawing.Point(329, 5);
            this.e_nav_close.Name = "e_nav_close";
            this.e_nav_close.Size = new System.Drawing.Size(20, 20);
            this.e_nav_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_close.TabIndex = 22;
            this.e_nav_close.TabStop = false;
            // 
            // ucpappointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(469, 386);
            this.Controls.Add(this.e_nav_close);
            this.Controls.Add(this.e_hider);
            this.Controls.Add(this.e_nav_title);
            this.Controls.Add(this.e_nav_logo);
            this.Controls.Add(this.e_nav);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ucpappointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WINDOWNAME";
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).EndInit();
            this.e_hider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_rename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label e_nav_title;
        private System.Windows.Forms.PictureBox e_nav_logo;
        private System.Windows.Forms.PictureBox e_nav;
        private System.Windows.Forms.Panel e_hider;
        private System.Windows.Forms.PictureBox e_nav_close;
        private System.Windows.Forms.ListView e_disp_homework;
        public System.Windows.Forms.RichTextBox e_inp_addiontional;
        private System.Windows.Forms.PictureBox e_but_file_rename;
        private System.Windows.Forms.PictureBox e_but_file_remove;
        private System.Windows.Forms.PictureBox e_but_file_add;
    }
}