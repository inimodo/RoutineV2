namespace User.Forms
{
    partial class ucpi_share
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
            this.e_info_hashcode = new System.Windows.Forms.Label();
            this.e_inp_hashcode = new System.Windows.Forms.TextBox();
            this.e_but_load = new System.Windows.Forms.Button();
            this.e_but_searchhash = new System.Windows.Forms.Button();
            this.e_out_files = new System.Windows.Forms.Label();
            this.e_out_topic = new System.Windows.Forms.Label();
            this.e_info_subject = new System.Windows.Forms.Label();
            this.e_out_subject = new System.Windows.Forms.Label();
            this.e_info_date = new System.Windows.Forms.Label();
            this.e_out_date = new System.Windows.Forms.Label();
            this.e_infopanel = new System.Windows.Forms.Panel();
            this.e_out_hashcode = new System.Windows.Forms.Label();
            this.e_info_lesson = new System.Windows.Forms.Label();
            this.e_but_search = new System.Windows.Forms.Button();
            this.e_info_filepath = new System.Windows.Forms.Label();
            this.e_inp_path = new System.Windows.Forms.TextBox();
            this.e_but_export = new System.Windows.Forms.Button();
            this.e_but_import = new System.Windows.Forms.Button();
            this.e_sel_subject = new System.Windows.Forms.DomainUpDown();
            this.e_div_five = new System.Windows.Forms.PictureBox();
            this.e_div_four = new System.Windows.Forms.PictureBox();
            this.e_div_two = new System.Windows.Forms.PictureBox();
            this.e_infopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_five)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_four)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_two)).BeginInit();
            this.SuspendLayout();
            // 
            // e_info_hashcode
            // 
            this.e_info_hashcode.AutoSize = true;
            this.e_info_hashcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_hashcode.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_hashcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_hashcode.Location = new System.Drawing.Point(3, 0);
            this.e_info_hashcode.Name = "e_info_hashcode";
            this.e_info_hashcode.Size = new System.Drawing.Size(74, 18);
            this.e_info_hashcode.TabIndex = 74;
            this.e_info_hashcode.Text = "Hashcode";
            // 
            // e_inp_hashcode
            // 
            this.e_inp_hashcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_inp_hashcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_hashcode.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_hashcode.ForeColor = System.Drawing.Color.White;
            this.e_inp_hashcode.Location = new System.Drawing.Point(6, 21);
            this.e_inp_hashcode.Name = "e_inp_hashcode";
            this.e_inp_hashcode.Size = new System.Drawing.Size(247, 21);
            this.e_inp_hashcode.TabIndex = 75;
            this.e_inp_hashcode.TextChanged += new System.EventHandler(this.click_load);
            // 
            // e_but_load
            // 
            this.e_but_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_load.Location = new System.Drawing.Point(356, 21);
            this.e_but_load.Name = "e_but_load";
            this.e_but_load.Size = new System.Drawing.Size(79, 21);
            this.e_but_load.TabIndex = 76;
            this.e_but_load.Text = "Load";
            this.e_but_load.UseVisualStyleBackColor = true;
            this.e_but_load.Visible = false;
            this.e_but_load.Click += new System.EventHandler(this.click_load);
            // 
            // e_but_searchhash
            // 
            this.e_but_searchhash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_searchhash.Location = new System.Drawing.Point(267, 22);
            this.e_but_searchhash.Name = "e_but_searchhash";
            this.e_but_searchhash.Size = new System.Drawing.Size(79, 21);
            this.e_but_searchhash.TabIndex = 78;
            this.e_but_searchhash.Text = "Search";
            this.e_but_searchhash.UseVisualStyleBackColor = true;
            this.e_but_searchhash.Click += new System.EventHandler(this.click_searchcode);
            // 
            // e_out_files
            // 
            this.e_out_files.AutoSize = true;
            this.e_out_files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.e_out_files.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_out_files.ForeColor = System.Drawing.Color.White;
            this.e_out_files.Location = new System.Drawing.Point(17, 53);
            this.e_out_files.Name = "e_out_files";
            this.e_out_files.Size = new System.Drawing.Size(104, 18);
            this.e_out_files.TabIndex = 79;
            this.e_out_files.Text = "Cotains ? Files\r\n";
            // 
            // e_out_topic
            // 
            this.e_out_topic.AutoSize = true;
            this.e_out_topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.e_out_topic.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_out_topic.ForeColor = System.Drawing.Color.White;
            this.e_out_topic.Location = new System.Drawing.Point(17, 12);
            this.e_out_topic.Name = "e_out_topic";
            this.e_out_topic.Size = new System.Drawing.Size(16, 18);
            this.e_out_topic.TabIndex = 84;
            this.e_out_topic.Text = "?";
            // 
            // e_info_subject
            // 
            this.e_info_subject.AutoSize = true;
            this.e_info_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.e_info_subject.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_subject.Location = new System.Drawing.Point(241, 53);
            this.e_info_subject.Name = "e_info_subject";
            this.e_info_subject.Size = new System.Drawing.Size(60, 18);
            this.e_info_subject.TabIndex = 83;
            this.e_info_subject.Text = "Subject";
            // 
            // e_out_subject
            // 
            this.e_out_subject.AutoSize = true;
            this.e_out_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.e_out_subject.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_out_subject.ForeColor = System.Drawing.Color.White;
            this.e_out_subject.Location = new System.Drawing.Point(258, 71);
            this.e_out_subject.Name = "e_out_subject";
            this.e_out_subject.Size = new System.Drawing.Size(16, 18);
            this.e_out_subject.TabIndex = 82;
            this.e_out_subject.Text = "?";
            // 
            // e_info_date
            // 
            this.e_info_date.AutoSize = true;
            this.e_info_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.e_info_date.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_date.Location = new System.Drawing.Point(241, 12);
            this.e_info_date.Name = "e_info_date";
            this.e_info_date.Size = new System.Drawing.Size(39, 18);
            this.e_info_date.TabIndex = 81;
            this.e_info_date.Text = "Date";
            // 
            // e_out_date
            // 
            this.e_out_date.AutoSize = true;
            this.e_out_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.e_out_date.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_out_date.ForeColor = System.Drawing.Color.White;
            this.e_out_date.Location = new System.Drawing.Point(258, 30);
            this.e_out_date.Name = "e_out_date";
            this.e_out_date.Size = new System.Drawing.Size(16, 18);
            this.e_out_date.TabIndex = 80;
            this.e_out_date.Text = "?";
            // 
            // e_infopanel
            // 
            this.e_infopanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.e_infopanel.Controls.Add(this.e_out_subject);
            this.e_infopanel.Controls.Add(this.e_out_date);
            this.e_infopanel.Controls.Add(this.e_info_subject);
            this.e_infopanel.Controls.Add(this.e_info_date);
            this.e_infopanel.Controls.Add(this.e_out_hashcode);
            this.e_infopanel.Controls.Add(this.e_out_topic);
            this.e_infopanel.Controls.Add(this.e_out_files);
            this.e_infopanel.Location = new System.Drawing.Point(6, 66);
            this.e_infopanel.Name = "e_infopanel";
            this.e_infopanel.Size = new System.Drawing.Size(429, 97);
            this.e_infopanel.TabIndex = 85;
            // 
            // e_out_hashcode
            // 
            this.e_out_hashcode.AutoSize = true;
            this.e_out_hashcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.e_out_hashcode.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_out_hashcode.ForeColor = System.Drawing.Color.White;
            this.e_out_hashcode.Location = new System.Drawing.Point(17, 30);
            this.e_out_hashcode.Name = "e_out_hashcode";
            this.e_out_hashcode.Size = new System.Drawing.Size(16, 18);
            this.e_out_hashcode.TabIndex = 85;
            this.e_out_hashcode.Text = "?";
            // 
            // e_info_lesson
            // 
            this.e_info_lesson.AutoSize = true;
            this.e_info_lesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_lesson.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_lesson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_lesson.Location = new System.Drawing.Point(3, 45);
            this.e_info_lesson.Name = "e_info_lesson";
            this.e_info_lesson.Size = new System.Drawing.Size(84, 18);
            this.e_info_lesson.TabIndex = 86;
            this.e_info_lesson.Text = "Lesson Info";
            // 
            // e_but_search
            // 
            this.e_but_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_search.Location = new System.Drawing.Point(356, 208);
            this.e_but_search.Name = "e_but_search";
            this.e_but_search.Size = new System.Drawing.Size(79, 21);
            this.e_but_search.TabIndex = 91;
            this.e_but_search.Text = "Search";
            this.e_but_search.UseVisualStyleBackColor = true;
            this.e_but_search.Click += new System.EventHandler(this.click_search);
            // 
            // e_info_filepath
            // 
            this.e_info_filepath.AutoSize = true;
            this.e_info_filepath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_filepath.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_filepath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_filepath.Location = new System.Drawing.Point(3, 186);
            this.e_info_filepath.Name = "e_info_filepath";
            this.e_info_filepath.Size = new System.Drawing.Size(59, 18);
            this.e_info_filepath.TabIndex = 87;
            this.e_info_filepath.Text = "ZIP File";
            // 
            // e_inp_path
            // 
            this.e_inp_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_inp_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_path.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_path.ForeColor = System.Drawing.Color.White;
            this.e_inp_path.Location = new System.Drawing.Point(6, 207);
            this.e_inp_path.Name = "e_inp_path";
            this.e_inp_path.ReadOnly = true;
            this.e_inp_path.Size = new System.Drawing.Size(334, 21);
            this.e_inp_path.TabIndex = 88;
            // 
            // e_but_export
            // 
            this.e_but_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_export.Location = new System.Drawing.Point(356, 169);
            this.e_but_export.Name = "e_but_export";
            this.e_but_export.Size = new System.Drawing.Size(79, 21);
            this.e_but_export.TabIndex = 92;
            this.e_but_export.Text = "Export";
            this.e_but_export.UseVisualStyleBackColor = true;
            this.e_but_export.Click += new System.EventHandler(this.click_export);
            // 
            // e_but_import
            // 
            this.e_but_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_import.Location = new System.Drawing.Point(356, 234);
            this.e_but_import.Name = "e_but_import";
            this.e_but_import.Size = new System.Drawing.Size(79, 21);
            this.e_but_import.TabIndex = 95;
            this.e_but_import.Text = "Import";
            this.e_but_import.UseVisualStyleBackColor = true;
            this.e_but_import.Click += new System.EventHandler(this.click_import);
            // 
            // e_sel_subject
            // 
            this.e_sel_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_sel_subject.Font = new System.Drawing.Font("Logico Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_sel_subject.Location = new System.Drawing.Point(132, 234);
            this.e_sel_subject.Name = "e_sel_subject";
            this.e_sel_subject.ReadOnly = true;
            this.e_sel_subject.Size = new System.Drawing.Size(208, 21);
            this.e_sel_subject.TabIndex = 96;
            this.e_sel_subject.Text = "[SUBJECT]";
            // 
            // e_div_five
            // 
            this.e_div_five.BackColor = System.Drawing.Color.White;
            this.e_div_five.Location = new System.Drawing.Point(132, 254);
            this.e_div_five.Name = "e_div_five";
            this.e_div_five.Size = new System.Drawing.Size(208, 1);
            this.e_div_five.TabIndex = 97;
            this.e_div_five.TabStop = false;
            // 
            // e_div_four
            // 
            this.e_div_four.BackColor = System.Drawing.Color.White;
            this.e_div_four.Location = new System.Drawing.Point(6, 227);
            this.e_div_four.Name = "e_div_four";
            this.e_div_four.Size = new System.Drawing.Size(334, 1);
            this.e_div_four.TabIndex = 90;
            this.e_div_four.TabStop = false;
            // 
            // e_div_two
            // 
            this.e_div_two.BackColor = System.Drawing.Color.White;
            this.e_div_two.Location = new System.Drawing.Point(6, 41);
            this.e_div_two.Name = "e_div_two";
            this.e_div_two.Size = new System.Drawing.Size(247, 1);
            this.e_div_two.TabIndex = 77;
            this.e_div_two.TabStop = false;
            // 
            // ucpi_share
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.e_div_five);
            this.Controls.Add(this.e_sel_subject);
            this.Controls.Add(this.e_but_import);
            this.Controls.Add(this.e_but_export);
            this.Controls.Add(this.e_but_search);
            this.Controls.Add(this.e_div_four);
            this.Controls.Add(this.e_info_filepath);
            this.Controls.Add(this.e_inp_path);
            this.Controls.Add(this.e_info_lesson);
            this.Controls.Add(this.e_infopanel);
            this.Controls.Add(this.e_but_searchhash);
            this.Controls.Add(this.e_div_two);
            this.Controls.Add(this.e_info_hashcode);
            this.Controls.Add(this.e_inp_hashcode);
            this.Controls.Add(this.e_but_load);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucpi_share";
            this.Size = new System.Drawing.Size(460, 280);
            this.e_infopanel.ResumeLayout(false);
            this.e_infopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_five)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_four)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_two)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox e_div_two;
        private System.Windows.Forms.Label e_info_hashcode;
        private System.Windows.Forms.TextBox e_inp_hashcode;
        private System.Windows.Forms.Button e_but_load;
        private System.Windows.Forms.Button e_but_searchhash;
        private System.Windows.Forms.Label e_out_files;
        private System.Windows.Forms.Label e_out_topic;
        private System.Windows.Forms.Label e_info_subject;
        private System.Windows.Forms.Label e_out_subject;
        private System.Windows.Forms.Label e_info_date;
        private System.Windows.Forms.Label e_out_date;
        private System.Windows.Forms.Panel e_infopanel;
        private System.Windows.Forms.Label e_info_lesson;
        private System.Windows.Forms.Label e_out_hashcode;
        private System.Windows.Forms.Button e_but_search;
        private System.Windows.Forms.PictureBox e_div_four;
        private System.Windows.Forms.Label e_info_filepath;
        private System.Windows.Forms.TextBox e_inp_path;
        private System.Windows.Forms.Button e_but_export;
        private System.Windows.Forms.Button e_but_import;
        private System.Windows.Forms.PictureBox e_div_five;
        private System.Windows.Forms.DomainUpDown e_sel_subject;
    }
}
