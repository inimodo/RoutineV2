namespace User.Action
{
    partial class ucpcreatep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucpcreatep));
            this.e_nav_title = new System.Windows.Forms.Label();
            this.e_nav_logo = new System.Windows.Forms.PictureBox();
            this.e_nav_grab = new System.Windows.Forms.PictureBox();
            this.e_hider = new System.Windows.Forms.Panel();
            this.e_inp_grade = new System.Windows.Forms.TextBox();
            this.e_nav_close = new System.Windows.Forms.PictureBox();
            this.e_continue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_grab)).BeginInit();
            this.e_hider.SuspendLayout();
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
            this.e_nav_logo.Image = global::User.Properties.Resources.create;
            this.e_nav_logo.Location = new System.Drawing.Point(10, 3);
            this.e_nav_logo.Name = "e_nav_logo";
            this.e_nav_logo.Size = new System.Drawing.Size(25, 25);
            this.e_nav_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_logo.TabIndex = 17;
            this.e_nav_logo.TabStop = false;
            // 
            // e_nav_grab
            // 
            this.e_nav_grab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_nav_grab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_grab.Location = new System.Drawing.Point(1, 1);
            this.e_nav_grab.Name = "e_nav_grab";
            this.e_nav_grab.Size = new System.Drawing.Size(357, 30);
            this.e_nav_grab.TabIndex = 16;
            this.e_nav_grab.TabStop = false;
            // 
            // e_hider
            // 
            this.e_hider.Controls.Add(this.e_continue);
            this.e_hider.Controls.Add(this.e_inp_grade);
            this.e_hider.Location = new System.Drawing.Point(1, 31);
            this.e_hider.Name = "e_hider";
            this.e_hider.Size = new System.Drawing.Size(350, 50);
            this.e_hider.TabIndex = 20;
            // 
            // e_inp_grade
            // 
            this.e_inp_grade.AcceptsReturn = true;
            this.e_inp_grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_inp_grade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_grade.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_grade.ForeColor = System.Drawing.Color.White;
            this.e_inp_grade.Location = new System.Drawing.Point(9, 15);
            this.e_inp_grade.Name = "e_inp_grade";
            this.e_inp_grade.Size = new System.Drawing.Size(259, 21);
            this.e_inp_grade.TabIndex = 50;
            this.e_inp_grade.Text = "eg.: \'5th Grade\'";
            this.e_inp_grade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterCheck);
            // 
            // e_nav_close
            // 
            this.e_nav_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_close.Image = ((System.Drawing.Image)(resources.GetObject("e_nav_close.Image")));
            this.e_nav_close.Location = new System.Drawing.Point(327, 5);
            this.e_nav_close.Name = "e_nav_close";
            this.e_nav_close.Size = new System.Drawing.Size(20, 20);
            this.e_nav_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_close.TabIndex = 22;
            this.e_nav_close.TabStop = false;
            // 
            // e_continue
            // 
            this.e_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_continue.Location = new System.Drawing.Point(271, 13);
            this.e_continue.Name = "e_continue";
            this.e_continue.Size = new System.Drawing.Size(75, 23);
            this.e_continue.TabIndex = 51;
            this.e_continue.Text = "Continue";
            this.e_continue.UseVisualStyleBackColor = true;
            this.e_continue.Click += new System.EventHandler(this.CloseDialog);
            // 
            // ucpcreatep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(359, 180);
            this.Controls.Add(this.e_nav_close);
            this.Controls.Add(this.e_hider);
            this.Controls.Add(this.e_nav_title);
            this.Controls.Add(this.e_nav_logo);
            this.Controls.Add(this.e_nav_grab);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ucpcreatep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WINDOWNAME";
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_grab)).EndInit();
            this.e_hider.ResumeLayout(false);
            this.e_hider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label e_nav_title;
        private System.Windows.Forms.PictureBox e_nav_logo;
        private System.Windows.Forms.PictureBox e_nav_grab;
        private System.Windows.Forms.Panel e_hider;
        private System.Windows.Forms.PictureBox e_nav_close;
        private System.Windows.Forms.TextBox e_inp_grade;
        private System.Windows.Forms.Button e_continue;
    }
}