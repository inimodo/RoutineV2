namespace User.Forms
{
    partial class ucpi_general
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
            this.e_but_loadedp = new System.Windows.Forms.Button();
            this.e_inp_loadedp = new System.Windows.Forms.TextBox();
            this.e_but_cnewp = new System.Windows.Forms.Button();
            this.e_info_cnewp = new System.Windows.Forms.Label();
            this.e_but_unloadp = new System.Windows.Forms.Button();
            this.e_info_unloadp = new System.Windows.Forms.Label();
            this.e_info_autostart = new System.Windows.Forms.Label();
            this.e_tog_autostart = new System.Windows.Forms.CheckBox();
            this.e_tog_smartstart = new System.Windows.Forms.CheckBox();
            this.e_info_smartstart = new System.Windows.Forms.Label();
            this.e_div_four = new System.Windows.Forms.PictureBox();
            this.e_info_infotext = new System.Windows.Forms.RichTextBox();
            this.e_info_copyright = new System.Windows.Forms.Label();
            this.e_info_version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_four)).BeginInit();
            this.SuspendLayout();
            // 
            // e_but_loadedp
            // 
            this.e_but_loadedp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_loadedp.Location = new System.Drawing.Point(295, 3);
            this.e_but_loadedp.Name = "e_but_loadedp";
            this.e_but_loadedp.Size = new System.Drawing.Size(79, 21);
            this.e_but_loadedp.TabIndex = 32;
            this.e_but_loadedp.Text = "...";
            this.e_but_loadedp.UseVisualStyleBackColor = true;
            this.e_but_loadedp.Click += new System.EventHandler(this.select_project);
            // 
            // e_inp_loadedp
            // 
            this.e_inp_loadedp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_inp_loadedp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_loadedp.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_loadedp.ForeColor = System.Drawing.Color.White;
            this.e_inp_loadedp.Location = new System.Drawing.Point(3, 3);
            this.e_inp_loadedp.Name = "e_inp_loadedp";
            this.e_inp_loadedp.ReadOnly = true;
            this.e_inp_loadedp.Size = new System.Drawing.Size(266, 21);
            this.e_inp_loadedp.TabIndex = 31;
            this.e_inp_loadedp.WordWrap = false;
            // 
            // e_but_cnewp
            // 
            this.e_but_cnewp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_cnewp.Location = new System.Drawing.Point(295, 40);
            this.e_but_cnewp.Name = "e_but_cnewp";
            this.e_but_cnewp.Size = new System.Drawing.Size(79, 21);
            this.e_but_cnewp.TabIndex = 37;
            this.e_but_cnewp.Text = "Create";
            this.e_but_cnewp.UseVisualStyleBackColor = true;
            this.e_but_cnewp.Click += new System.EventHandler(this.create_project);
            // 
            // e_info_cnewp
            // 
            this.e_info_cnewp.AutoSize = true;
            this.e_info_cnewp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_cnewp.Font = new System.Drawing.Font("Logico Sans", 10F);
            this.e_info_cnewp.ForeColor = System.Drawing.Color.White;
            this.e_info_cnewp.Location = new System.Drawing.Point(0, 40);
            this.e_info_cnewp.Name = "e_info_cnewp";
            this.e_info_cnewp.Size = new System.Drawing.Size(126, 16);
            this.e_info_cnewp.TabIndex = 35;
            this.e_info_cnewp.Text = "Create new Project";
            // 
            // e_but_unloadp
            // 
            this.e_but_unloadp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_unloadp.Location = new System.Drawing.Point(295, 67);
            this.e_but_unloadp.Name = "e_but_unloadp";
            this.e_but_unloadp.Size = new System.Drawing.Size(79, 21);
            this.e_but_unloadp.TabIndex = 39;
            this.e_but_unloadp.Text = "Loadout";
            this.e_but_unloadp.UseVisualStyleBackColor = true;
            this.e_but_unloadp.Click += new System.EventHandler(this.loadout_project);
            // 
            // e_info_unloadp
            // 
            this.e_info_unloadp.AutoSize = true;
            this.e_info_unloadp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_unloadp.Font = new System.Drawing.Font("Logico Sans", 10F);
            this.e_info_unloadp.ForeColor = System.Drawing.Color.White;
            this.e_info_unloadp.Location = new System.Drawing.Point(0, 67);
            this.e_info_unloadp.Name = "e_info_unloadp";
            this.e_info_unloadp.Size = new System.Drawing.Size(98, 16);
            this.e_info_unloadp.TabIndex = 38;
            this.e_info_unloadp.Text = "Unload Project";
            // 
            // e_info_autostart
            // 
            this.e_info_autostart.AutoSize = true;
            this.e_info_autostart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_autostart.Font = new System.Drawing.Font("Logico Sans", 10F);
            this.e_info_autostart.ForeColor = System.Drawing.Color.White;
            this.e_info_autostart.Location = new System.Drawing.Point(0, 97);
            this.e_info_autostart.Name = "e_info_autostart";
            this.e_info_autostart.Size = new System.Drawing.Size(179, 16);
            this.e_info_autostart.TabIndex = 40;
            this.e_info_autostart.Text = "Start Automatic on PC-Boot";
            // 
            // e_tog_autostart
            // 
            this.e_tog_autostart.AutoSize = true;
            this.e_tog_autostart.Font = new System.Drawing.Font("Logico Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_tog_autostart.Location = new System.Drawing.Point(295, 94);
            this.e_tog_autostart.Name = "e_tog_autostart";
            this.e_tog_autostart.Size = new System.Drawing.Size(93, 22);
            this.e_tog_autostart.TabIndex = 41;
            this.e_tog_autostart.Text = "Autostart";
            this.e_tog_autostart.UseVisualStyleBackColor = true;
            this.e_tog_autostart.CheckedChanged += new System.EventHandler(this.sel_autostart);
            // 
            // e_tog_smartstart
            // 
            this.e_tog_smartstart.AutoSize = true;
            this.e_tog_smartstart.Font = new System.Drawing.Font("Logico Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_tog_smartstart.Location = new System.Drawing.Point(295, 122);
            this.e_tog_smartstart.Name = "e_tog_smartstart";
            this.e_tog_smartstart.Size = new System.Drawing.Size(108, 22);
            this.e_tog_smartstart.TabIndex = 43;
            this.e_tog_smartstart.Text = "Autoupdate";
            this.e_tog_smartstart.UseVisualStyleBackColor = true;
            this.e_tog_smartstart.CheckedChanged += new System.EventHandler(this.sel_smartstart);
            // 
            // e_info_smartstart
            // 
            this.e_info_smartstart.AutoSize = true;
            this.e_info_smartstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_smartstart.Font = new System.Drawing.Font("Logico Sans", 10F);
            this.e_info_smartstart.ForeColor = System.Drawing.Color.White;
            this.e_info_smartstart.Location = new System.Drawing.Point(0, 125);
            this.e_info_smartstart.Name = "e_info_smartstart";
            this.e_info_smartstart.Size = new System.Drawing.Size(232, 16);
            this.e_info_smartstart.TabIndex = 42;
            this.e_info_smartstart.Text = "Checks for Updates (Recommended)";
            // 
            // e_div_four
            // 
            this.e_div_four.BackColor = System.Drawing.Color.White;
            this.e_div_four.Location = new System.Drawing.Point(2, 23);
            this.e_div_four.Name = "e_div_four";
            this.e_div_four.Size = new System.Drawing.Size(266, 1);
            this.e_div_four.TabIndex = 73;
            this.e_div_four.TabStop = false;
            // 
            // e_info_infotext
            // 
            this.e_info_infotext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_infotext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_info_infotext.ForeColor = System.Drawing.SystemColors.Window;
            this.e_info_infotext.Location = new System.Drawing.Point(4, 150);
            this.e_info_infotext.Name = "e_info_infotext";
            this.e_info_infotext.Size = new System.Drawing.Size(370, 94);
            this.e_info_infotext.TabIndex = 118;
            this.e_info_infotext.Text = "";
            // 
            // e_info_copyright
            // 
            this.e_info_copyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_copyright.Font = new System.Drawing.Font("Logico Sans", 9F);
            this.e_info_copyright.ForeColor = System.Drawing.Color.White;
            this.e_info_copyright.Location = new System.Drawing.Point(-1, 247);
            this.e_info_copyright.Name = "e_info_copyright";
            this.e_info_copyright.Size = new System.Drawing.Size(375, 33);
            this.e_info_copyright.TabIndex = 119;
            this.e_info_copyright.Text = "UCP-Systems 2016-2020. All rights reserved. Logo and graphics copyright to UCP-Sy" +
    "stems. Software specific icons created by Philip Keusch.";
            // 
            // e_info_version
            // 
            this.e_info_version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_version.Font = new System.Drawing.Font("Logico Sans", 9F);
            this.e_info_version.ForeColor = System.Drawing.Color.White;
            this.e_info_version.Location = new System.Drawing.Point(302, 256);
            this.e_info_version.Name = "e_info_version";
            this.e_info_version.Size = new System.Drawing.Size(155, 24);
            this.e_info_version.TabIndex = 120;
            this.e_info_version.Text = "Version 1.0";
            this.e_info_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucpi_general
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.e_info_copyright);
            this.Controls.Add(this.e_info_infotext);
            this.Controls.Add(this.e_div_four);
            this.Controls.Add(this.e_tog_smartstart);
            this.Controls.Add(this.e_info_smartstart);
            this.Controls.Add(this.e_tog_autostart);
            this.Controls.Add(this.e_info_autostart);
            this.Controls.Add(this.e_but_unloadp);
            this.Controls.Add(this.e_info_unloadp);
            this.Controls.Add(this.e_but_cnewp);
            this.Controls.Add(this.e_info_cnewp);
            this.Controls.Add(this.e_inp_loadedp);
            this.Controls.Add(this.e_but_loadedp);
            this.Controls.Add(this.e_info_version);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucpi_general";
            this.Size = new System.Drawing.Size(460, 280);
            ((System.ComponentModel.ISupportInitialize)(this.e_div_four)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button e_but_loadedp;
        private System.Windows.Forms.TextBox e_inp_loadedp;
        private System.Windows.Forms.Button e_but_unloadp;
        private System.Windows.Forms.Label e_info_unloadp;
        private System.Windows.Forms.Button e_but_cnewp;
        private System.Windows.Forms.Label e_info_cnewp;
        private System.Windows.Forms.Label e_info_autostart;
        private System.Windows.Forms.CheckBox e_tog_autostart;
        private System.Windows.Forms.CheckBox e_tog_smartstart;
        private System.Windows.Forms.Label e_info_smartstart;
        private System.Windows.Forms.PictureBox e_div_four;
        private System.Windows.Forms.RichTextBox e_info_infotext;
        private System.Windows.Forms.Label e_info_copyright;
        private System.Windows.Forms.Label e_info_version;
    }
}
