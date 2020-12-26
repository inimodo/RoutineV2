namespace User.Forms { 
    partial class ucpi_board
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
            this.e_gens = new System.Windows.Forms.Panel();
            this.e_ico_manger = new System.Windows.Forms.PictureBox();
            this.e_ico_general = new System.Windows.Forms.PictureBox();
            this.e_ico_all = new System.Windows.Forms.PictureBox();
            this.e_ico_create = new System.Windows.Forms.PictureBox();
            this.e_ico_share = new System.Windows.Forms.PictureBox();
            this.e_ico_appointments = new System.Windows.Forms.PictureBox();
            this.e_div_one = new System.Windows.Forms.PictureBox();
            this.e_gens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_manger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_general)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_all)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_create)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_share)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_appointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_one)).BeginInit();
            this.SuspendLayout();
            // 
            // e_gens
            // 
            this.e_gens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_gens.Controls.Add(this.e_ico_manger);
            this.e_gens.Controls.Add(this.e_ico_general);
            this.e_gens.Controls.Add(this.e_div_one);
            this.e_gens.Controls.Add(this.e_ico_all);
            this.e_gens.Controls.Add(this.e_ico_create);
            this.e_gens.Controls.Add(this.e_ico_share);
            this.e_gens.Controls.Add(this.e_ico_appointments);
            this.e_gens.Location = new System.Drawing.Point(0, 0);
            this.e_gens.Name = "e_gens";
            this.e_gens.Size = new System.Drawing.Size(80, 257);
            this.e_gens.TabIndex = 1;
            // 
            // e_ico_manger
            // 
            this.e_ico_manger.Image = global::User.Properties.Resources.markus_manager;
            this.e_ico_manger.Location = new System.Drawing.Point(25, 205);
            this.e_ico_manger.Name = "e_ico_manger";
            this.e_ico_manger.Size = new System.Drawing.Size(30, 30);
            this.e_ico_manger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_manger.TabIndex = 12;
            this.e_ico_manger.TabStop = false;
            this.e_ico_manger.Click += new System.EventHandler(this.click_manager);
            // 
            // e_ico_general
            // 
            this.e_ico_general.Image = global::User.Properties.Resources.settings;
            this.e_ico_general.Location = new System.Drawing.Point(25, 169);
            this.e_ico_general.Name = "e_ico_general";
            this.e_ico_general.Size = new System.Drawing.Size(30, 30);
            this.e_ico_general.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_general.TabIndex = 1;
            this.e_ico_general.TabStop = false;
            this.e_ico_general.Click += new System.EventHandler(this.click_general);
            // 
            // e_ico_all
            // 
            this.e_ico_all.Image = global::User.Properties.Resources.homework;
            this.e_ico_all.Location = new System.Drawing.Point(25, 56);
            this.e_ico_all.Name = "e_ico_all";
            this.e_ico_all.Size = new System.Drawing.Size(30, 30);
            this.e_ico_all.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_all.TabIndex = 22;
            this.e_ico_all.TabStop = false;
            this.e_ico_all.Click += new System.EventHandler(this.click_all);
            // 
            // e_ico_create
            // 
            this.e_ico_create.Image = global::User.Properties.Resources.create;
            this.e_ico_create.Location = new System.Drawing.Point(25, 20);
            this.e_ico_create.Name = "e_ico_create";
            this.e_ico_create.Size = new System.Drawing.Size(30, 30);
            this.e_ico_create.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_create.TabIndex = 26;
            this.e_ico_create.TabStop = false;
            this.e_ico_create.Click += new System.EventHandler(this.click_create);
            // 
            // e_ico_share
            // 
            this.e_ico_share.Image = global::User.Properties.Resources.share;
            this.e_ico_share.Location = new System.Drawing.Point(25, 126);
            this.e_ico_share.Name = "e_ico_share";
            this.e_ico_share.Size = new System.Drawing.Size(30, 30);
            this.e_ico_share.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_share.TabIndex = 24;
            this.e_ico_share.TabStop = false;
            this.e_ico_share.Click += new System.EventHandler(this.click_share);
            // 
            // e_ico_appointments
            // 
            this.e_ico_appointments.Image = global::User.Properties.Resources.calendar;
            this.e_ico_appointments.Location = new System.Drawing.Point(25, 91);
            this.e_ico_appointments.Name = "e_ico_appointments";
            this.e_ico_appointments.Size = new System.Drawing.Size(30, 30);
            this.e_ico_appointments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_ico_appointments.TabIndex = 30;
            this.e_ico_appointments.TabStop = false;
            this.e_ico_appointments.Click += new System.EventHandler(this.click_appointment);
            // 
            // e_div_one
            // 
            this.e_div_one.BackColor = System.Drawing.Color.White;
            this.e_div_one.Location = new System.Drawing.Point(15, 162);
            this.e_div_one.Name = "e_div_one";
            this.e_div_one.Size = new System.Drawing.Size(50, 1);
            this.e_div_one.TabIndex = 1;
            this.e_div_one.TabStop = false;
            // 
            // ucpi_board
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.e_gens);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucpi_board";
            this.Size = new System.Drawing.Size(81, 258);
            this.e_gens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_manger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_general)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_all)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_create)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_share)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ico_appointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_one)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel      e_gens;
        private System.Windows.Forms.PictureBox e_ico_general;
        private System.Windows.Forms.PictureBox e_ico_manger;
        private System.Windows.Forms.PictureBox e_ico_share;
        private System.Windows.Forms.PictureBox e_ico_all;
        private System.Windows.Forms.PictureBox e_ico_create;
        private System.Windows.Forms.PictureBox e_ico_appointments;
        private System.Windows.Forms.PictureBox e_div_one;
    }
}
