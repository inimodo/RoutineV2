namespace User.Forms
{
    partial class ucpi_appointments
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
            this.e_info_date = new System.Windows.Forms.Label();
            this.e_sel_subject = new System.Windows.Forms.DomainUpDown();
            this.e_info_subject = new System.Windows.Forms.Label();
            this.e_inp_date = new System.Windows.Forms.DateTimePicker();
            this.e_but_add = new System.Windows.Forms.Button();
            this.e_div_two = new System.Windows.Forms.PictureBox();
            this.e_disp_homework = new System.Windows.Forms.ListView();
            this.e_but_del = new System.Windows.Forms.Button();
            this.e_tog_ao = new System.Windows.Forms.CheckBox();
            this.e_inp_addiontional = new System.Windows.Forms.RichTextBox();
            this.e_but_save = new System.Windows.Forms.Button();
            this.e_div_three = new System.Windows.Forms.PictureBox();
            this.e_out_days = new System.Windows.Forms.Label();
            this.e_div_five = new System.Windows.Forms.PictureBox();
            this.e_out_addiontional = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_three)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_five)).BeginInit();
            this.SuspendLayout();
            // 
            // e_info_date
            // 
            this.e_info_date.AutoSize = true;
            this.e_info_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_date.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_date.Location = new System.Drawing.Point(199, 0);
            this.e_info_date.Name = "e_info_date";
            this.e_info_date.Size = new System.Drawing.Size(39, 18);
            this.e_info_date.TabIndex = 77;
            this.e_info_date.Text = "Date";
            // 
            // e_sel_subject
            // 
            this.e_sel_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_sel_subject.Font = new System.Drawing.Font("Logico Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_sel_subject.Location = new System.Drawing.Point(6, 21);
            this.e_sel_subject.Name = "e_sel_subject";
            this.e_sel_subject.ReadOnly = true;
            this.e_sel_subject.Size = new System.Drawing.Size(188, 21);
            this.e_sel_subject.TabIndex = 76;
            this.e_sel_subject.SelectedItemChanged += new System.EventHandler(this.e_sel_subject_SelectedItemChanged);
            // 
            // e_info_subject
            // 
            this.e_info_subject.AutoSize = true;
            this.e_info_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_subject.Font = new System.Drawing.Font("Logico Sans", 11F);
            this.e_info_subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_info_subject.Location = new System.Drawing.Point(3, 0);
            this.e_info_subject.Name = "e_info_subject";
            this.e_info_subject.Size = new System.Drawing.Size(60, 18);
            this.e_info_subject.TabIndex = 75;
            this.e_info_subject.Text = "Subject";
            // 
            // e_inp_date
            // 
            this.e_inp_date.Cursor = System.Windows.Forms.Cursors.Default;
            this.e_inp_date.Font = new System.Drawing.Font("Logico Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_inp_date.Location = new System.Drawing.Point(200, 20);
            this.e_inp_date.Name = "e_inp_date";
            this.e_inp_date.Size = new System.Drawing.Size(132, 22);
            this.e_inp_date.TabIndex = 74;
            this.e_inp_date.ValueChanged += new System.EventHandler(this.e_inp_date_ValueChanged);
            // 
            // e_but_add
            // 
            this.e_but_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_add.Location = new System.Drawing.Point(349, 20);
            this.e_but_add.Name = "e_but_add";
            this.e_but_add.Size = new System.Drawing.Size(79, 21);
            this.e_but_add.TabIndex = 79;
            this.e_but_add.Text = "Add";
            this.e_but_add.UseVisualStyleBackColor = true;
            this.e_but_add.Click += new System.EventHandler(this.click_add);
            // 
            // e_div_two
            // 
            this.e_div_two.BackColor = System.Drawing.Color.White;
            this.e_div_two.Location = new System.Drawing.Point(6, 236);
            this.e_div_two.Name = "e_div_two";
            this.e_div_two.Size = new System.Drawing.Size(188, 1);
            this.e_div_two.TabIndex = 97;
            this.e_div_two.TabStop = false;
            // 
            // e_disp_homework
            // 
            this.e_disp_homework.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.e_disp_homework.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_disp_homework.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_disp_homework.Font = new System.Drawing.Font("Logico Sans", 10F);
            this.e_disp_homework.ForeColor = System.Drawing.Color.White;
            this.e_disp_homework.HideSelection = false;
            this.e_disp_homework.Location = new System.Drawing.Point(6, 75);
            this.e_disp_homework.MultiSelect = false;
            this.e_disp_homework.Name = "e_disp_homework";
            this.e_disp_homework.Size = new System.Drawing.Size(188, 162);
            this.e_disp_homework.TabIndex = 96;
            this.e_disp_homework.TileSize = new System.Drawing.Size(100, 20);
            this.e_disp_homework.UseCompatibleStateImageBehavior = false;
            this.e_disp_homework.View = System.Windows.Forms.View.SmallIcon;
            this.e_disp_homework.SelectedIndexChanged += new System.EventHandler(this.event_sellect);
            // 
            // e_but_del
            // 
            this.e_but_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_del.Location = new System.Drawing.Point(200, 216);
            this.e_but_del.Name = "e_but_del";
            this.e_but_del.Size = new System.Drawing.Size(79, 21);
            this.e_but_del.TabIndex = 102;
            this.e_but_del.Text = "Delete";
            this.e_but_del.UseVisualStyleBackColor = true;
            this.e_but_del.Click += new System.EventHandler(this.click_delete);
            // 
            // e_tog_ao
            // 
            this.e_tog_ao.AutoSize = true;
            this.e_tog_ao.Checked = true;
            this.e_tog_ao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.e_tog_ao.Font = new System.Drawing.Font("Logico Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_tog_ao.Location = new System.Drawing.Point(5, 243);
            this.e_tog_ao.Name = "e_tog_ao";
            this.e_tog_ao.Size = new System.Drawing.Size(104, 22);
            this.e_tog_ao.TabIndex = 103;
            this.e_tog_ao.Text = "Active Only";
            this.e_tog_ao.UseVisualStyleBackColor = true;
            this.e_tog_ao.Click += new System.EventHandler(this.event_ao);
            // 
            // e_inp_addiontional
            // 
            this.e_inp_addiontional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_addiontional.DetectUrls = false;
            this.e_inp_addiontional.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_addiontional.Location = new System.Drawing.Point(200, 75);
            this.e_inp_addiontional.Name = "e_inp_addiontional";
            this.e_inp_addiontional.RightMargin = 420;
            this.e_inp_addiontional.Size = new System.Drawing.Size(228, 115);
            this.e_inp_addiontional.TabIndex = 106;
            this.e_inp_addiontional.Text = "";
            // 
            // e_but_save
            // 
            this.e_but_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_save.Location = new System.Drawing.Point(349, 216);
            this.e_but_save.Name = "e_but_save";
            this.e_but_save.Size = new System.Drawing.Size(79, 21);
            this.e_but_save.TabIndex = 107;
            this.e_but_save.Text = "Save";
            this.e_but_save.UseVisualStyleBackColor = true;
            this.e_but_save.Click += new System.EventHandler(this.click_save);
            // 
            // e_div_three
            // 
            this.e_div_three.BackColor = System.Drawing.Color.White;
            this.e_div_three.Location = new System.Drawing.Point(200, 189);
            this.e_div_three.Name = "e_div_three";
            this.e_div_three.Size = new System.Drawing.Size(228, 1);
            this.e_div_three.TabIndex = 108;
            this.e_div_three.TabStop = false;
            // 
            // e_out_days
            // 
            this.e_out_days.AutoSize = true;
            this.e_out_days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_out_days.Font = new System.Drawing.Font("Logico Sans", 10F);
            this.e_out_days.ForeColor = System.Drawing.Color.White;
            this.e_out_days.Location = new System.Drawing.Point(197, 193);
            this.e_out_days.Name = "e_out_days";
            this.e_out_days.Size = new System.Drawing.Size(76, 16);
            this.e_out_days.TabIndex = 111;
            this.e_out_days.Text = "? days left.";
            // 
            // e_div_five
            // 
            this.e_div_five.BackColor = System.Drawing.Color.White;
            this.e_div_five.Location = new System.Drawing.Point(6, 42);
            this.e_div_five.Name = "e_div_five";
            this.e_div_five.Size = new System.Drawing.Size(188, 1);
            this.e_div_five.TabIndex = 114;
            this.e_div_five.TabStop = false;
            // 
            // e_out_addiontional
            // 
            this.e_out_addiontional.AutoSize = true;
            this.e_out_addiontional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_out_addiontional.Font = new System.Drawing.Font("Logico Sans", 10F);
            this.e_out_addiontional.ForeColor = System.Drawing.Color.White;
            this.e_out_addiontional.Location = new System.Drawing.Point(352, 193);
            this.e_out_addiontional.Name = "e_out_addiontional";
            this.e_out_addiontional.Size = new System.Drawing.Size(76, 16);
            this.e_out_addiontional.TabIndex = 116;
            this.e_out_addiontional.Text = "? days left.";
            // 
            // ucpi_appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.e_out_addiontional);
            this.Controls.Add(this.e_div_five);
            this.Controls.Add(this.e_out_days);
            this.Controls.Add(this.e_div_three);
            this.Controls.Add(this.e_but_save);
            this.Controls.Add(this.e_inp_addiontional);
            this.Controls.Add(this.e_tog_ao);
            this.Controls.Add(this.e_but_del);
            this.Controls.Add(this.e_div_two);
            this.Controls.Add(this.e_disp_homework);
            this.Controls.Add(this.e_but_add);
            this.Controls.Add(this.e_info_date);
            this.Controls.Add(this.e_sel_subject);
            this.Controls.Add(this.e_info_subject);
            this.Controls.Add(this.e_inp_date);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucpi_appointments";
            this.Size = new System.Drawing.Size(460, 280);
            ((System.ComponentModel.ISupportInitialize)(this.e_div_two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_three)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_five)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label e_info_date;
        public System.Windows.Forms.DomainUpDown e_sel_subject;
        private System.Windows.Forms.Label e_info_subject;
        public System.Windows.Forms.DateTimePicker e_inp_date;
        private System.Windows.Forms.Button e_but_add;
        private System.Windows.Forms.PictureBox e_div_two;
        private System.Windows.Forms.ListView e_disp_homework;
        private System.Windows.Forms.Button e_but_del;
        private System.Windows.Forms.CheckBox e_tog_ao;
        public System.Windows.Forms.RichTextBox e_inp_addiontional;
        private System.Windows.Forms.Button e_but_save;
        private System.Windows.Forms.PictureBox e_div_three;
        private System.Windows.Forms.Label e_out_days;
        private System.Windows.Forms.PictureBox e_div_five;
        private System.Windows.Forms.Label e_out_addiontional;
    }
}
