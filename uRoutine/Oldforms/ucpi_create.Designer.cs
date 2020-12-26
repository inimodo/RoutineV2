namespace User.Forms
{
    partial class ucpi_create
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
            this.e_tog_project = new System.Windows.Forms.CheckBox();
            this.e_tog_createdef = new System.Windows.Forms.CheckBox();
            this.e_but_create = new System.Windows.Forms.Button();
            this.e_inp_topic = new System.Windows.Forms.TextBox();
            this.e_info_topic = new System.Windows.Forms.Label();
            this.e_sel_subject = new System.Windows.Forms.DomainUpDown();
            this.e_inp_fileending_remove = new System.Windows.Forms.Button();
            this.e_inp_fileending_add = new System.Windows.Forms.Button();
            this.e_inp_fileending = new System.Windows.Forms.TextBox();
            this.e_disp_fileending = new System.Windows.Forms.ListView();
            this.e_info_subject_one = new System.Windows.Forms.Label();
            this.e_info_settings = new System.Windows.Forms.Label();
            this.e_info_filetypes = new System.Windows.Forms.Label();
            this.e_info_fileend = new System.Windows.Forms.Label();
            this.e_div_five = new System.Windows.Forms.PictureBox();
            this.e_div_six = new System.Windows.Forms.PictureBox();
            this.e_div_three = new System.Windows.Forms.PictureBox();
            this.e_div_two = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_five)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_six)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_three)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_two)).BeginInit();
            this.SuspendLayout();
            // 
            // e_tog_project
            // 
            this.e_tog_project.AutoSize = true;
            this.e_tog_project.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_tog_project.Location = new System.Drawing.Point(290, 48);
            this.e_tog_project.Name = "e_tog_project";
            this.e_tog_project.Size = new System.Drawing.Size(142, 22);
            this.e_tog_project.TabIndex = 54;
            this.e_tog_project.Text = "Longterm Project";
            this.e_tog_project.UseVisualStyleBackColor = true;
            // 
            // e_tog_createdef
            // 
            this.e_tog_createdef.AutoSize = true;
            this.e_tog_createdef.Checked = true;
            this.e_tog_createdef.CheckState = System.Windows.Forms.CheckState.Checked;
            this.e_tog_createdef.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_tog_createdef.Location = new System.Drawing.Point(290, 20);
            this.e_tog_createdef.Name = "e_tog_createdef";
            this.e_tog_createdef.Size = new System.Drawing.Size(131, 22);
            this.e_tog_createdef.TabIndex = 50;
            this.e_tog_createdef.Text = "Create Defaults";
            this.e_tog_createdef.UseVisualStyleBackColor = true;
            // 
            // e_but_create
            // 
            this.e_but_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_create.Location = new System.Drawing.Point(290, 76);
            this.e_but_create.Name = "e_but_create";
            this.e_but_create.Size = new System.Drawing.Size(87, 23);
            this.e_but_create.TabIndex = 52;
            this.e_but_create.Text = "Create";
            this.e_but_create.UseVisualStyleBackColor = true;
            this.e_but_create.Click += new System.EventHandler(this.click_fe);
            // 
            // e_inp_topic
            // 
            this.e_inp_topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_inp_topic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_topic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.e_inp_topic.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_topic.ForeColor = System.Drawing.Color.White;
            this.e_inp_topic.Location = new System.Drawing.Point(6, 22);
            this.e_inp_topic.MaxLength = 100;
            this.e_inp_topic.Name = "e_inp_topic";
            this.e_inp_topic.Size = new System.Drawing.Size(239, 21);
            this.e_inp_topic.TabIndex = 49;
            this.e_inp_topic.Text = "DEFAULT TOPIC";
            // 
            // e_info_topic
            // 
            this.e_info_topic.AutoSize = true;
            this.e_info_topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_topic.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_topic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_topic.Location = new System.Drawing.Point(3, 0);
            this.e_info_topic.Name = "e_info_topic";
            this.e_info_topic.Size = new System.Drawing.Size(45, 18);
            this.e_info_topic.TabIndex = 55;
            this.e_info_topic.Text = "Topic";
            // 
            // e_sel_subject
            // 
            this.e_sel_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_sel_subject.Font = new System.Drawing.Font("Logico Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_sel_subject.InterceptArrowKeys = false;
            this.e_sel_subject.Location = new System.Drawing.Point(6, 79);
            this.e_sel_subject.Name = "e_sel_subject";
            this.e_sel_subject.ReadOnly = true;
            this.e_sel_subject.Size = new System.Drawing.Size(239, 21);
            this.e_sel_subject.TabIndex = 53;
            this.e_sel_subject.SelectedItemChanged += new System.EventHandler(this.click_fe_sel);
            // 
            // e_inp_fileending_remove
            // 
            this.e_inp_fileending_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_inp_fileending_remove.Location = new System.Drawing.Point(290, 217);
            this.e_inp_fileending_remove.Name = "e_inp_fileending_remove";
            this.e_inp_fileending_remove.Size = new System.Drawing.Size(87, 21);
            this.e_inp_fileending_remove.TabIndex = 62;
            this.e_inp_fileending_remove.Text = "Remove";
            this.e_inp_fileending_remove.UseVisualStyleBackColor = true;
            this.e_inp_fileending_remove.Click += new System.EventHandler(this.click_fe_remove);
            // 
            // e_inp_fileending_add
            // 
            this.e_inp_fileending_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_inp_fileending_add.Location = new System.Drawing.Point(290, 190);
            this.e_inp_fileending_add.Name = "e_inp_fileending_add";
            this.e_inp_fileending_add.Size = new System.Drawing.Size(87, 21);
            this.e_inp_fileending_add.TabIndex = 61;
            this.e_inp_fileending_add.Text = "Add";
            this.e_inp_fileending_add.UseVisualStyleBackColor = true;
            this.e_inp_fileending_add.Click += new System.EventHandler(this.click_fe_add);
            // 
            // e_inp_fileending
            // 
            this.e_inp_fileending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_inp_fileending.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_fileending.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_fileending.ForeColor = System.Drawing.Color.White;
            this.e_inp_fileending.Location = new System.Drawing.Point(290, 163);
            this.e_inp_fileending.MaxLength = 8;
            this.e_inp_fileending.Name = "e_inp_fileending";
            this.e_inp_fileending.Size = new System.Drawing.Size(87, 21);
            this.e_inp_fileending.TabIndex = 60;
            // 
            // e_disp_fileending
            // 
            this.e_disp_fileending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_disp_fileending.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_disp_fileending.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_disp_fileending.ForeColor = System.Drawing.Color.White;
            this.e_disp_fileending.HideSelection = false;
            this.e_disp_fileending.Location = new System.Drawing.Point(6, 163);
            this.e_disp_fileending.MultiSelect = false;
            this.e_disp_fileending.Name = "e_disp_fileending";
            this.e_disp_fileending.Size = new System.Drawing.Size(239, 103);
            this.e_disp_fileending.TabIndex = 71;
            this.e_disp_fileending.TileSize = new System.Drawing.Size(20, 20);
            this.e_disp_fileending.UseCompatibleStateImageBehavior = false;
            this.e_disp_fileending.View = System.Windows.Forms.View.SmallIcon;
            // 
            // e_info_subject_one
            // 
            this.e_info_subject_one.AutoSize = true;
            this.e_info_subject_one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_subject_one.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_subject_one.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_subject_one.Location = new System.Drawing.Point(3, 57);
            this.e_info_subject_one.Name = "e_info_subject_one";
            this.e_info_subject_one.Size = new System.Drawing.Size(60, 18);
            this.e_info_subject_one.TabIndex = 77;
            this.e_info_subject_one.Text = "Subject";
            // 
            // e_info_settings
            // 
            this.e_info_settings.AutoSize = true;
            this.e_info_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_settings.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_settings.Location = new System.Drawing.Point(292, 0);
            this.e_info_settings.Name = "e_info_settings";
            this.e_info_settings.Size = new System.Drawing.Size(63, 18);
            this.e_info_settings.TabIndex = 78;
            this.e_info_settings.Text = "Settings";
            // 
            // e_info_filetypes
            // 
            this.e_info_filetypes.AutoSize = true;
            this.e_info_filetypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_filetypes.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_filetypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_filetypes.Location = new System.Drawing.Point(3, 142);
            this.e_info_filetypes.Name = "e_info_filetypes";
            this.e_info_filetypes.Size = new System.Drawing.Size(120, 18);
            this.e_info_filetypes.TabIndex = 80;
            this.e_info_filetypes.Text = "Default Filetypes";
            // 
            // e_info_fileend
            // 
            this.e_info_fileend.AutoSize = true;
            this.e_info_fileend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_fileend.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_fileend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_fileend.Location = new System.Drawing.Point(292, 141);
            this.e_info_fileend.Name = "e_info_fileend";
            this.e_info_fileend.Size = new System.Drawing.Size(74, 18);
            this.e_info_fileend.TabIndex = 81;
            this.e_info_fileend.Text = "Fileending";
            // 
            // e_div_five
            // 
            this.e_div_five.BackColor = System.Drawing.Color.White;
            this.e_div_five.Location = new System.Drawing.Point(290, 183);
            this.e_div_five.Name = "e_div_five";
            this.e_div_five.Size = new System.Drawing.Size(87, 1);
            this.e_div_five.TabIndex = 76;
            this.e_div_five.TabStop = false;
            // 
            // e_div_six
            // 
            this.e_div_six.BackColor = System.Drawing.Color.White;
            this.e_div_six.Location = new System.Drawing.Point(6, 265);
            this.e_div_six.Name = "e_div_six";
            this.e_div_six.Size = new System.Drawing.Size(239, 1);
            this.e_div_six.TabIndex = 75;
            this.e_div_six.TabStop = false;
            // 
            // e_div_three
            // 
            this.e_div_three.BackColor = System.Drawing.Color.White;
            this.e_div_three.Location = new System.Drawing.Point(6, 99);
            this.e_div_three.Name = "e_div_three";
            this.e_div_three.Size = new System.Drawing.Size(239, 1);
            this.e_div_three.TabIndex = 73;
            this.e_div_three.TabStop = false;
            // 
            // e_div_two
            // 
            this.e_div_two.BackColor = System.Drawing.Color.White;
            this.e_div_two.Location = new System.Drawing.Point(6, 42);
            this.e_div_two.Name = "e_div_two";
            this.e_div_two.Size = new System.Drawing.Size(239, 1);
            this.e_div_two.TabIndex = 72;
            this.e_div_two.TabStop = false;
            // 
            // ucpi_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.e_info_fileend);
            this.Controls.Add(this.e_info_filetypes);
            this.Controls.Add(this.e_info_settings);
            this.Controls.Add(this.e_info_subject_one);
            this.Controls.Add(this.e_div_five);
            this.Controls.Add(this.e_div_six);
            this.Controls.Add(this.e_div_three);
            this.Controls.Add(this.e_div_two);
            this.Controls.Add(this.e_disp_fileending);
            this.Controls.Add(this.e_inp_fileending_remove);
            this.Controls.Add(this.e_inp_fileending_add);
            this.Controls.Add(this.e_inp_fileending);
            this.Controls.Add(this.e_info_topic);
            this.Controls.Add(this.e_tog_project);
            this.Controls.Add(this.e_sel_subject);
            this.Controls.Add(this.e_tog_createdef);
            this.Controls.Add(this.e_but_create);
            this.Controls.Add(this.e_inp_topic);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucpi_create";
            this.Size = new System.Drawing.Size(460, 280);
            ((System.ComponentModel.ISupportInitialize)(this.e_div_five)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_six)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_three)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_two)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox       e_tog_project;
        private System.Windows.Forms.DomainUpDown   e_sel_subject;
        private System.Windows.Forms.CheckBox       e_tog_createdef;
        private System.Windows.Forms.Button         e_but_create;
        private System.Windows.Forms.TextBox        e_inp_topic;
        private System.Windows.Forms.Label          e_info_topic;
        private System.Windows.Forms.Button         e_inp_fileending_remove;
        private System.Windows.Forms.Button         e_inp_fileending_add;
        private System.Windows.Forms.TextBox        e_inp_fileending;
        private System.Windows.Forms.ListView       e_disp_fileending;
        private System.Windows.Forms.PictureBox     e_div_two;
        private System.Windows.Forms.PictureBox     e_div_three;
        private System.Windows.Forms.PictureBox     e_div_six;
        private System.Windows.Forms.PictureBox     e_div_five;
        private System.Windows.Forms.Label          e_info_subject_one;
        private System.Windows.Forms.Label          e_info_settings;
        private System.Windows.Forms.Label          e_info_filetypes;
        private System.Windows.Forms.Label          e_info_fileend;
    }
}
