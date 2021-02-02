namespace User.Action
{
    partial class ucpsettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucpsettings));
            this.e_nav_title = new System.Windows.Forms.Label();
            this.e_hider = new System.Windows.Forms.Panel();
            this.e_but_create = new System.Windows.Forms.Button();
            this.e_but_subjects_remove = new System.Windows.Forms.PictureBox();
            this.e_but_subjects_rename = new System.Windows.Forms.PictureBox();
            this.e_but_subjects_add = new System.Windows.Forms.PictureBox();
            this.e_disp_subjects = new System.Windows.Forms.ListView();
            this.e_nav_close = new System.Windows.Forms.PictureBox();
            this.e_nav_logo = new System.Windows.Forms.PictureBox();
            this.e_nav = new System.Windows.Forms.PictureBox();
            this.e_but_subjects_extern = new System.Windows.Forms.PictureBox();
            this.e_hider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_rename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_extern)).BeginInit();
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
            // e_hider
            // 
            this.e_hider.Controls.Add(this.e_but_create);
            this.e_hider.Controls.Add(this.e_but_subjects_remove);
            this.e_hider.Controls.Add(this.e_but_subjects_extern);
            this.e_hider.Controls.Add(this.e_but_subjects_rename);
            this.e_hider.Controls.Add(this.e_but_subjects_add);
            this.e_hider.Controls.Add(this.e_disp_subjects);
            this.e_hider.Location = new System.Drawing.Point(1, 31);
            this.e_hider.Name = "e_hider";
            this.e_hider.Size = new System.Drawing.Size(520, 195);
            this.e_hider.TabIndex = 20;
            // 
            // e_but_create
            // 
            this.e_but_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_create.Location = new System.Drawing.Point(423, 159);
            this.e_but_create.Name = "e_but_create";
            this.e_but_create.Size = new System.Drawing.Size(87, 23);
            this.e_but_create.TabIndex = 130;
            this.e_but_create.Text = "Updates";
            this.e_but_create.UseVisualStyleBackColor = true;

            // 
            // e_but_subjects_remove
            // 
            this.e_but_subjects_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_subjects_remove.Image = global::User.Properties.Resources.delete;
            this.e_but_subjects_remove.Location = new System.Drawing.Point(101, 142);
            this.e_but_subjects_remove.Name = "e_but_subjects_remove";
            this.e_but_subjects_remove.Size = new System.Drawing.Size(40, 40);
            this.e_but_subjects_remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_subjects_remove.TabIndex = 127;
            this.e_but_subjects_remove.TabStop = false;
            // 
            // e_but_subjects_rename
            // 
            this.e_but_subjects_rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_subjects_rename.Image = global::User.Properties.Resources.edit;
            this.e_but_subjects_rename.Location = new System.Drawing.Point(147, 142);
            this.e_but_subjects_rename.Name = "e_but_subjects_rename";
            this.e_but_subjects_rename.Size = new System.Drawing.Size(40, 40);
            this.e_but_subjects_rename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_subjects_rename.TabIndex = 128;
            this.e_but_subjects_rename.TabStop = false;
            // 
            // e_but_subjects_add
            // 
            this.e_but_subjects_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_subjects_add.Image = global::User.Properties.Resources.create;
            this.e_but_subjects_add.Location = new System.Drawing.Point(9, 142);
            this.e_but_subjects_add.Name = "e_but_subjects_add";
            this.e_but_subjects_add.Size = new System.Drawing.Size(40, 40);
            this.e_but_subjects_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_subjects_add.TabIndex = 129;
            this.e_but_subjects_add.TabStop = false;
            // 
            // e_disp_subjects
            // 
            this.e_disp_subjects.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.e_disp_subjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_disp_subjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_disp_subjects.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_disp_subjects.ForeColor = System.Drawing.Color.White;
            this.e_disp_subjects.HideSelection = false;
            this.e_disp_subjects.Location = new System.Drawing.Point(9, 6);
            this.e_disp_subjects.MultiSelect = false;
            this.e_disp_subjects.Name = "e_disp_subjects";
            this.e_disp_subjects.Size = new System.Drawing.Size(501, 130);
            this.e_disp_subjects.TabIndex = 124;
            this.e_disp_subjects.TileSize = new System.Drawing.Size(20, 20);
            this.e_disp_subjects.UseCompatibleStateImageBehavior = false;
            this.e_disp_subjects.View = System.Windows.Forms.View.SmallIcon;
            // 
            // e_nav_close
            // 
            this.e_nav_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_close.Image = ((System.Drawing.Image)(resources.GetObject("e_nav_close.Image")));
            this.e_nav_close.Location = new System.Drawing.Point(504, 5);
            this.e_nav_close.Name = "e_nav_close";
            this.e_nav_close.Size = new System.Drawing.Size(20, 20);
            this.e_nav_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_close.TabIndex = 22;
            this.e_nav_close.TabStop = false;
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
            this.e_nav.Size = new System.Drawing.Size(534, 30);
            this.e_nav.TabIndex = 16;
            this.e_nav.TabStop = false;
            // 
            // e_but_subjects_extern
            // 
            this.e_but_subjects_extern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_subjects_extern.Image = global::User.Properties.Resources.import;
            this.e_but_subjects_extern.Location = new System.Drawing.Point(55, 142);
            this.e_but_subjects_extern.Name = "e_but_subjects_extern";
            this.e_but_subjects_extern.Size = new System.Drawing.Size(40, 40);
            this.e_but_subjects_extern.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_subjects_extern.TabIndex = 128;
            this.e_but_subjects_extern.TabStop = false;
            // 
            // ucpsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(536, 472);
            this.Controls.Add(this.e_nav_close);
            this.Controls.Add(this.e_hider);
            this.Controls.Add(this.e_nav_title);
            this.Controls.Add(this.e_nav_logo);
            this.Controls.Add(this.e_nav);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ucpsettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WINDOWNAME";
            this.e_hider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_rename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_extern)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label e_nav_title;
        private System.Windows.Forms.PictureBox e_nav_logo;
        private System.Windows.Forms.PictureBox e_nav;
        private System.Windows.Forms.Panel e_hider;
        private System.Windows.Forms.PictureBox e_nav_close;
        private System.Windows.Forms.ListView e_disp_subjects;
        private System.Windows.Forms.PictureBox e_but_subjects_remove;
        private System.Windows.Forms.PictureBox e_but_subjects_rename;
        private System.Windows.Forms.PictureBox e_but_subjects_add;
        private System.Windows.Forms.Button e_but_create;
        private System.Windows.Forms.PictureBox e_but_subjects_extern;
    }
}