namespace User.Forms
{
    partial class ucpi_manager
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
            this.e_info_grade = new System.Windows.Forms.Label();
            this.e_inp_grade = new System.Windows.Forms.TextBox();
            this.e_but_grade = new System.Windows.Forms.Button();
            this.e_info_subjects = new System.Windows.Forms.Label();
            this.e_inp_subjects = new System.Windows.Forms.TextBox();
            this.e_div_two = new System.Windows.Forms.PictureBox();
            this.e_div_three = new System.Windows.Forms.PictureBox();
            this.e_div_six = new System.Windows.Forms.PictureBox();
            this.e_disp_subjects = new System.Windows.Forms.ListView();
            this.e_but_subjects_add = new System.Windows.Forms.PictureBox();
            this.e_but_subjects_rename = new System.Windows.Forms.PictureBox();
            this.e_but_subjects_remove = new System.Windows.Forms.PictureBox();
            this.e_info_subject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_three)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_six)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_rename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_remove)).BeginInit();
            this.SuspendLayout();
            // 
            // e_info_grade
            // 
            this.e_info_grade.AutoSize = true;
            this.e_info_grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_grade.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_grade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_grade.Location = new System.Drawing.Point(3, 0);
            this.e_info_grade.Name = "e_info_grade";
            this.e_info_grade.Size = new System.Drawing.Size(102, 18);
            this.e_info_grade.TabIndex = 47;
            this.e_info_grade.Text = "Current Grade";
            // 
            // e_inp_grade
            // 
            this.e_inp_grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_inp_grade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_grade.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_grade.ForeColor = System.Drawing.Color.White;
            this.e_inp_grade.Location = new System.Drawing.Point(7, 22);
            this.e_inp_grade.Name = "e_inp_grade";
            this.e_inp_grade.Size = new System.Drawing.Size(251, 21);
            this.e_inp_grade.TabIndex = 48;
            // 
            // e_but_grade
            // 
            this.e_but_grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_grade.Location = new System.Drawing.Point(282, 23);
            this.e_but_grade.Name = "e_but_grade";
            this.e_but_grade.Size = new System.Drawing.Size(79, 21);
            this.e_but_grade.TabIndex = 49;
            this.e_but_grade.Text = "Save";
            this.e_but_grade.UseVisualStyleBackColor = true;
            this.e_but_grade.Click += new System.EventHandler(this.save_grade);
            // 
            // e_info_subjects
            // 
            this.e_info_subjects.AutoSize = true;
            this.e_info_subjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_subjects.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_subjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_subjects.Location = new System.Drawing.Point(3, 57);
            this.e_info_subjects.Name = "e_info_subjects";
            this.e_info_subjects.Size = new System.Drawing.Size(67, 18);
            this.e_info_subjects.TabIndex = 51;
            this.e_info_subjects.Text = "Subjects";
            // 
            // e_inp_subjects
            // 
            this.e_inp_subjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_inp_subjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_subjects.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_subjects.ForeColor = System.Drawing.Color.White;
            this.e_inp_subjects.Location = new System.Drawing.Point(282, 78);
            this.e_inp_subjects.Name = "e_inp_subjects";
            this.e_inp_subjects.Size = new System.Drawing.Size(132, 21);
            this.e_inp_subjects.TabIndex = 52;
            this.e_inp_subjects.TextChanged += new System.EventHandler(this.event_subject);
            // 
            // e_div_two
            // 
            this.e_div_two.BackColor = System.Drawing.Color.White;
            this.e_div_two.Location = new System.Drawing.Point(7, 42);
            this.e_div_two.Name = "e_div_two";
            this.e_div_two.Size = new System.Drawing.Size(251, 1);
            this.e_div_two.TabIndex = 73;
            this.e_div_two.TabStop = false;
            // 
            // e_div_three
            // 
            this.e_div_three.BackColor = System.Drawing.Color.White;
            this.e_div_three.Location = new System.Drawing.Point(282, 98);
            this.e_div_three.Name = "e_div_three";
            this.e_div_three.Size = new System.Drawing.Size(132, 1);
            this.e_div_three.TabIndex = 76;
            this.e_div_three.TabStop = false;
            // 
            // e_div_six
            // 
            this.e_div_six.BackColor = System.Drawing.Color.White;
            this.e_div_six.Location = new System.Drawing.Point(6, 268);
            this.e_div_six.Name = "e_div_six";
            this.e_div_six.Size = new System.Drawing.Size(251, 1);
            this.e_div_six.TabIndex = 77;
            this.e_div_six.TabStop = false;
            // 
            // e_disp_subjects
            // 
            this.e_disp_subjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_disp_subjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_disp_subjects.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_disp_subjects.ForeColor = System.Drawing.Color.White;
            this.e_disp_subjects.HideSelection = false;
            this.e_disp_subjects.Location = new System.Drawing.Point(7, 78);
            this.e_disp_subjects.MultiSelect = false;
            this.e_disp_subjects.Name = "e_disp_subjects";
            this.e_disp_subjects.Size = new System.Drawing.Size(251, 190);
            this.e_disp_subjects.TabIndex = 119;
            this.e_disp_subjects.TileSize = new System.Drawing.Size(20, 20);
            this.e_disp_subjects.UseCompatibleStateImageBehavior = false;
            this.e_disp_subjects.View = System.Windows.Forms.View.SmallIcon;
            // 
            // e_but_subjects_add
            // 
            this.e_but_subjects_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_subjects_add.Image = global::User.Properties.Resources.create;
            this.e_but_subjects_add.Location = new System.Drawing.Point(282, 105);
            this.e_but_subjects_add.Name = "e_but_subjects_add";
            this.e_but_subjects_add.Size = new System.Drawing.Size(40, 40);
            this.e_but_subjects_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_subjects_add.TabIndex = 120;
            this.e_but_subjects_add.TabStop = false;
            this.e_but_subjects_add.Click += new System.EventHandler(this.sub_add);
            // 
            // e_but_subjects_rename
            // 
            this.e_but_subjects_rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_subjects_rename.Image = global::User.Properties.Resources.edit;
            this.e_but_subjects_rename.Location = new System.Drawing.Point(328, 105);
            this.e_but_subjects_rename.Name = "e_but_subjects_rename";
            this.e_but_subjects_rename.Size = new System.Drawing.Size(40, 40);
            this.e_but_subjects_rename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_subjects_rename.TabIndex = 120;
            this.e_but_subjects_rename.TabStop = false;
            this.e_but_subjects_rename.Click += new System.EventHandler(this.sub_rename);
            // 
            // e_but_subjects_remove
            // 
            this.e_but_subjects_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_subjects_remove.Image = global::User.Properties.Resources.delete;
            this.e_but_subjects_remove.Location = new System.Drawing.Point(374, 105);
            this.e_but_subjects_remove.Name = "e_but_subjects_remove";
            this.e_but_subjects_remove.Size = new System.Drawing.Size(40, 40);
            this.e_but_subjects_remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_subjects_remove.TabIndex = 120;
            this.e_but_subjects_remove.TabStop = false;
            this.e_but_subjects_remove.Click += new System.EventHandler(this.sub_remove);
            // 
            // e_info_subject
            // 
            this.e_info_subject.AutoSize = true;
            this.e_info_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_subject.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_subject.Location = new System.Drawing.Point(279, 57);
            this.e_info_subject.Name = "e_info_subject";
            this.e_info_subject.Size = new System.Drawing.Size(60, 18);
            this.e_info_subject.TabIndex = 121;
            this.e_info_subject.Text = "Subject";
            // 
            // ucpi_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.e_info_subject);
            this.Controls.Add(this.e_but_subjects_remove);
            this.Controls.Add(this.e_but_subjects_rename);
            this.Controls.Add(this.e_but_subjects_add);
            this.Controls.Add(this.e_disp_subjects);
            this.Controls.Add(this.e_div_six);
            this.Controls.Add(this.e_div_three);
            this.Controls.Add(this.e_div_two);
            this.Controls.Add(this.e_inp_subjects);
            this.Controls.Add(this.e_info_subjects);
            this.Controls.Add(this.e_info_grade);
            this.Controls.Add(this.e_inp_grade);
            this.Controls.Add(this.e_but_grade);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucpi_manager";
            this.Size = new System.Drawing.Size(460, 280);
            ((System.ComponentModel.ISupportInitialize)(this.e_div_two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_three)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_six)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_rename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_subjects_remove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label e_info_grade;
        private System.Windows.Forms.TextBox e_inp_grade;
        private System.Windows.Forms.Button e_but_grade;
        private System.Windows.Forms.Label e_info_subjects;
        private System.Windows.Forms.TextBox e_inp_subjects;
        private System.Windows.Forms.PictureBox e_div_two;
        private System.Windows.Forms.PictureBox e_div_three;
        private System.Windows.Forms.PictureBox e_div_six;
        private System.Windows.Forms.ListView e_disp_subjects;
        private System.Windows.Forms.PictureBox e_but_subjects_add;
        private System.Windows.Forms.PictureBox e_but_subjects_rename;
        private System.Windows.Forms.PictureBox e_but_subjects_remove;
        private System.Windows.Forms.Label e_info_subject;
    }
}
