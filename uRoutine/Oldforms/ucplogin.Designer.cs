namespace Source
{
    partial class ucplogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucplogin));
            this.e_check = new System.Windows.Forms.Button();
            this.e_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.e_input_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.e_wrong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.e_register = new System.Windows.Forms.Button();
            this.e_break = new System.Windows.Forms.Button();
            this.e_nav = new System.Windows.Forms.PictureBox();
            this.e_hide = new System.Windows.Forms.PictureBox();
            this.e_nav_minimize = new System.Windows.Forms.PictureBox();
            this.e_nav_close = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).BeginInit();
            this.SuspendLayout();
            // 
            // e_check
            // 
            this.e_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.e_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_check.Font = new System.Drawing.Font("Logico Sans", 14.25F);
            this.e_check.ForeColor = System.Drawing.Color.White;
            this.e_check.Location = new System.Drawing.Point(22, 443);
            this.e_check.Name = "e_check";
            this.e_check.Size = new System.Drawing.Size(234, 36);
            this.e_check.TabIndex = 13;
            this.e_check.Text = "CHECK";
            this.e_check.UseVisualStyleBackColor = false;
            this.e_check.Click += new System.EventHandler(this.login);
            // 
            // e_login
            // 
            this.e_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.e_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_login.Font = new System.Drawing.Font("Logico Sans", 14.25F);
            this.e_login.ForeColor = System.Drawing.Color.White;
            this.e_login.Location = new System.Drawing.Point(25, 124);
            this.e_login.Name = "e_login";
            this.e_login.Size = new System.Drawing.Size(234, 36);
            this.e_login.TabIndex = 16;
            this.e_login.Text = "LOGIN";
            this.e_login.UseVisualStyleBackColor = false;
            this.e_login.Click += new System.EventHandler(this.openbrw);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Logico Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "CODE";
            // 
            // e_input_name
            // 
            this.e_input_name.BackColor = System.Drawing.Color.White;
            this.e_input_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_input_name.Font = new System.Drawing.Font("Logico Sans", 14.25F);
            this.e_input_name.Location = new System.Drawing.Point(40, 394);
            this.e_input_name.MaxLength = 5;
            this.e_input_name.Name = "e_input_name";
            this.e_input_name.Size = new System.Drawing.Size(216, 23);
            this.e_input_name.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Logico Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "#";
            // 
            // e_wrong
            // 
            this.e_wrong.AutoSize = true;
            this.e_wrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.e_wrong.Font = new System.Drawing.Font("Logico Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_wrong.ForeColor = System.Drawing.Color.Red;
            this.e_wrong.Location = new System.Drawing.Point(19, 426);
            this.e_wrong.Name = "e_wrong";
            this.e_wrong.Size = new System.Drawing.Size(182, 14);
            this.e_wrong.TabIndex = 19;
            this.e_wrong.Text = "Try again! Your code is not valid!";
            this.e_wrong.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Logico Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 38);
            this.label3.TabIndex = 20;
            this.label3.Text = "When logged in a code will appear which needs to be entered in the box above!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.Image = global::User.Properties.Resources.ucp_logo;
            this.pictureBox1.Location = new System.Drawing.Point(25, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // e_register
            // 
            this.e_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.e_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_register.Font = new System.Drawing.Font("Logico Sans", 14.25F);
            this.e_register.ForeColor = System.Drawing.Color.White;
            this.e_register.Location = new System.Drawing.Point(25, 174);
            this.e_register.Name = "e_register";
            this.e_register.Size = new System.Drawing.Size(234, 36);
            this.e_register.TabIndex = 22;
            this.e_register.Text = "REGISTER";
            this.e_register.UseVisualStyleBackColor = false;
            this.e_register.Click += new System.EventHandler(this.openreg);
            // 
            // e_break
            // 
            this.e_break.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.e_break.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_break.Font = new System.Drawing.Font("Logico Sans", 14.25F);
            this.e_break.ForeColor = System.Drawing.Color.White;
            this.e_break.Location = new System.Drawing.Point(25, 224);
            this.e_break.Name = "e_break";
            this.e_break.Size = new System.Drawing.Size(234, 36);
            this.e_break.TabIndex = 23;
            this.e_break.Text = "SKIP";
            this.e_break.UseVisualStyleBackColor = false;
            this.e_break.Click += new System.EventHandler(this.skipreg);
            // 
            // e_nav
            // 
            this.e_nav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav.Location = new System.Drawing.Point(0, 0);
            this.e_nav.Name = "e_nav";
            this.e_nav.Size = new System.Drawing.Size(289, 30);
            this.e_nav.TabIndex = 18;
            this.e_nav.TabStop = false;
            this.e_nav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_start);
            this.e_nav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.move);
            this.e_nav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.move_stop);
            // 
            // e_hide
            // 
            this.e_hide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.e_hide.Location = new System.Drawing.Point(25, 333);
            this.e_hide.Name = "e_hide";
            this.e_hide.Size = new System.Drawing.Size(60, 43);
            this.e_hide.TabIndex = 18;
            this.e_hide.TabStop = false;
            // 
            // e_nav_minimize
            // 
            this.e_nav_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_minimize.Image = ((System.Drawing.Image)(resources.GetObject("e_nav_minimize.Image")));
            this.e_nav_minimize.Location = new System.Drawing.Point(232, 5);
            this.e_nav_minimize.Name = "e_nav_minimize";
            this.e_nav_minimize.Size = new System.Drawing.Size(20, 20);
            this.e_nav_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_minimize.TabIndex = 25;
            this.e_nav_minimize.TabStop = false;
            this.e_nav_minimize.Click += new System.EventHandler(this.minimize);
            this.e_nav_minimize.MouseLeave += new System.EventHandler(this.minimize_hover_leave);
            this.e_nav_minimize.MouseHover += new System.EventHandler(this.minimize_hover);
            // 
            // e_nav_close
            // 
            this.e_nav_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_close.Image = ((System.Drawing.Image)(resources.GetObject("e_nav_close.Image")));
            this.e_nav_close.Location = new System.Drawing.Point(258, 5);
            this.e_nav_close.Name = "e_nav_close";
            this.e_nav_close.Size = new System.Drawing.Size(20, 20);
            this.e_nav_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_close.TabIndex = 24;
            this.e_nav_close.TabStop = false;
            this.e_nav_close.Click += new System.EventHandler(this.close);
            this.e_nav_close.MouseLeave += new System.EventHandler(this.close_hover_leave);
            this.e_nav_close.MouseHover += new System.EventHandler(this.close_hover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Logico Sans", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "SETTINGS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.clicksettup);
            // 
            // ucplogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(290, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.e_nav_minimize);
            this.Controls.Add(this.e_nav_close);
            this.Controls.Add(this.e_break);
            this.Controls.Add(this.e_nav);
            this.Controls.Add(this.e_register);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.e_wrong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.e_login);
            this.Controls.Add(this.e_input_name);
            this.Controls.Add(this.e_check);
            this.Controls.Add(this.e_hide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ucplogin";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.ucplogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button e_check;
        private System.Windows.Forms.Button e_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox e_input_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label e_wrong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button e_register;
        private System.Windows.Forms.Button e_break;
        private System.Windows.Forms.PictureBox e_nav;
        private System.Windows.Forms.PictureBox e_hide;
        private System.Windows.Forms.PictureBox e_nav_minimize;
        private System.Windows.Forms.PictureBox e_nav_close;
        private System.Windows.Forms.Button button1;
    }
}