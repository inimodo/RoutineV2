namespace User.ActionWindow.Lesson
{
    partial class ucplessondisp
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.e_inp_file = new System.Windows.Forms.TextBox();
            this.e_but_file_deletelesson = new System.Windows.Forms.PictureBox();
            this.e_but_file_folder = new System.Windows.Forms.PictureBox();
            this.e_but_file_append = new System.Windows.Forms.PictureBox();
            this.e_but_file_rename = new System.Windows.Forms.PictureBox();
            this.e_but_file_remove = new System.Windows.Forms.PictureBox();
            this.e_but_file_add = new System.Windows.Forms.PictureBox();
            this.e_div_five = new System.Windows.Forms.PictureBox();
            this.e_files = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_deletelesson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_folder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_append)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_rename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_five)).BeginInit();
            this.SuspendLayout();
            // 
            // e_inp_file
            // 
            this.e_inp_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.e_inp_file.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_file.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_file.ForeColor = System.Drawing.Color.White;
            this.e_inp_file.Location = new System.Drawing.Point(65, 294);
            this.e_inp_file.MaxLength = 100;
            this.e_inp_file.Name = "e_inp_file";
            this.e_inp_file.Size = new System.Drawing.Size(181, 21);
            this.e_inp_file.TabIndex = 77;
            // 
            // e_but_file_deletelesson
            // 
            this.e_but_file_deletelesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_deletelesson.Image = global::User.Properties.Resources.deletelesson;
            this.e_but_file_deletelesson.Location = new System.Drawing.Point(7, 195);
            this.e_but_file_deletelesson.Name = "e_but_file_deletelesson";
            this.e_but_file_deletelesson.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_deletelesson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_deletelesson.TabIndex = 81;
            this.e_but_file_deletelesson.TabStop = false;
            this.e_but_file_deletelesson.Click += new System.EventHandler(this.click_deletelesson);
            // 
            // e_but_file_folder
            // 
            this.e_but_file_folder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_folder.Image = global::User.Properties.Resources.openinfolder;
            this.e_but_file_folder.Location = new System.Drawing.Point(7, 159);
            this.e_but_file_folder.Name = "e_but_file_folder";
            this.e_but_file_folder.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_folder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_folder.TabIndex = 81;
            this.e_but_file_folder.TabStop = false;
            this.e_but_file_folder.Click += new System.EventHandler(this.click_openfolder);
            // 
            // e_but_file_append
            // 
            this.e_but_file_append.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_append.Image = global::User.Properties.Resources.adddexternal;
            this.e_but_file_append.Location = new System.Drawing.Point(7, 123);
            this.e_but_file_append.Name = "e_but_file_append";
            this.e_but_file_append.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_append.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_append.TabIndex = 80;
            this.e_but_file_append.TabStop = false;
            this.e_but_file_append.Click += new System.EventHandler(this.click_externaladd);
            // 
            // e_but_file_rename
            // 
            this.e_but_file_rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_rename.Image = global::User.Properties.Resources.edit;
            this.e_but_file_rename.Location = new System.Drawing.Point(7, 87);
            this.e_but_file_rename.Name = "e_but_file_rename";
            this.e_but_file_rename.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_rename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_rename.TabIndex = 80;
            this.e_but_file_rename.TabStop = false;
            this.e_but_file_rename.Click += new System.EventHandler(this.click_rename);
            // 
            // e_but_file_remove
            // 
            this.e_but_file_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_remove.Image = global::User.Properties.Resources.delete;
            this.e_but_file_remove.Location = new System.Drawing.Point(7, 51);
            this.e_but_file_remove.Name = "e_but_file_remove";
            this.e_but_file_remove.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_remove.TabIndex = 80;
            this.e_but_file_remove.TabStop = false;
            this.e_but_file_remove.Click += new System.EventHandler(this.click_remove);
            // 
            // e_but_file_add
            // 
            this.e_but_file_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_add.Image = global::User.Properties.Resources.create;
            this.e_but_file_add.Location = new System.Drawing.Point(7, 15);
            this.e_but_file_add.Name = "e_but_file_add";
            this.e_but_file_add.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_add.TabIndex = 80;
            this.e_but_file_add.TabStop = false;
            this.e_but_file_add.Click += new System.EventHandler(this.click_add);
            // 
            // e_div_five
            // 
            this.e_div_five.BackColor = System.Drawing.Color.White;
            this.e_div_five.Location = new System.Drawing.Point(65, 314);
            this.e_div_five.Name = "e_div_five";
            this.e_div_five.Size = new System.Drawing.Size(181, 1);
            this.e_div_five.TabIndex = 78;
            this.e_div_five.TabStop = false;
            // 
            // e_files
            // 
            this.e_files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_files.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_files.ForeColor = System.Drawing.Color.White;
            this.e_files.HideSelection = false;
            this.e_files.Location = new System.Drawing.Point(43, 15);
            this.e_files.MultiSelect = false;
            this.e_files.Name = "e_files";
            this.e_files.Size = new System.Drawing.Size(330, 174);
            this.e_files.TabIndex = 124;
            this.e_files.TileSize = new System.Drawing.Size(20, 20);
            this.e_files.UseCompatibleStateImageBehavior = false;
            this.e_files.View = System.Windows.Forms.View.SmallIcon;
            this.e_files.DoubleClick += new System.EventHandler(this.event_doubleclick);
            // 
            // ucplessondisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.e_files);
            this.Controls.Add(this.e_but_file_deletelesson);
            this.Controls.Add(this.e_but_file_folder);
            this.Controls.Add(this.e_but_file_append);
            this.Controls.Add(this.e_but_file_rename);
            this.Controls.Add(this.e_but_file_remove);
            this.Controls.Add(this.e_but_file_add);
            this.Controls.Add(this.e_div_five);
            this.Controls.Add(this.e_inp_file);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucplessondisp";
            this.Size = new System.Drawing.Size(588, 464);
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_deletelesson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_folder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_append)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_rename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_five)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox e_div_five;
        private System.Windows.Forms.TextBox e_inp_file;
        private System.Windows.Forms.PictureBox e_but_file_add;
        private System.Windows.Forms.PictureBox e_but_file_remove;
        private System.Windows.Forms.PictureBox e_but_file_rename;
        private System.Windows.Forms.PictureBox e_but_file_append;
        private System.Windows.Forms.PictureBox e_but_file_folder;
        private System.Windows.Forms.PictureBox e_but_file_deletelesson;
        private System.Windows.Forms.ListView e_files;
    }
}
