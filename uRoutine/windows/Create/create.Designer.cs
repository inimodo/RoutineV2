namespace User.Action
{
    partial class ucpcreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucpcreate));
            this.e_nav_title = new System.Windows.Forms.Label();
            this.e_nav_logo = new System.Windows.Forms.PictureBox();
            this.e_nav_grab = new System.Windows.Forms.PictureBox();
            this.e_hider = new System.Windows.Forms.Panel();
            this.e_inp_topic = new System.Windows.Forms.TextBox();
            this.e_but_create = new System.Windows.Forms.Button();
            this.e_sel_subject = new System.Windows.Forms.DomainUpDown();
            this.e_div_two = new System.Windows.Forms.PictureBox();
            this.e_div_three = new System.Windows.Forms.PictureBox();
            this.e_nav_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_grab)).BeginInit();
            this.e_hider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_three)).BeginInit();
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
            this.e_nav_logo.Image = global::User.Properties.Resources.logo;
            this.e_nav_logo.Location = new System.Drawing.Point(10, 1);
            this.e_nav_logo.Name = "e_nav_logo";
            this.e_nav_logo.Size = new System.Drawing.Size(30, 30);
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
            this.e_nav_grab.Size = new System.Drawing.Size(551, 30);
            this.e_nav_grab.TabIndex = 16;
            this.e_nav_grab.TabStop = false;
            // 
            // e_hider
            // 
            this.e_hider.Controls.Add(this.e_inp_topic);
            this.e_hider.Controls.Add(this.e_but_create);
            this.e_hider.Controls.Add(this.e_sel_subject);
            this.e_hider.Controls.Add(this.e_div_two);
            this.e_hider.Controls.Add(this.e_div_three);
            this.e_hider.Location = new System.Drawing.Point(1, 31);
            this.e_hider.Name = "e_hider";
            this.e_hider.Size = new System.Drawing.Size(275, 91);
            this.e_hider.TabIndex = 20;
            // 
            // e_inp_topic
            // 
            this.e_inp_topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_inp_topic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_topic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.e_inp_topic.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_topic.ForeColor = System.Drawing.Color.White;
            this.e_inp_topic.Location = new System.Drawing.Point(16, 17);
            this.e_inp_topic.MaxLength = 100;
            this.e_inp_topic.Name = "e_inp_topic";
            this.e_inp_topic.Size = new System.Drawing.Size(239, 21);
            this.e_inp_topic.TabIndex = 49;
            this.e_inp_topic.Text = "DEFAULT TOPIC";
            // 
            // e_but_create
            // 
            this.e_but_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_but_create.Location = new System.Drawing.Point(181, 55);
            this.e_but_create.Name = "e_but_create";
            this.e_but_create.Size = new System.Drawing.Size(87, 23);
            this.e_but_create.TabIndex = 52;
            this.e_but_create.Text = "Create";
            this.e_but_create.UseVisualStyleBackColor = true;
            // 
            // e_sel_subject
            // 
            this.e_sel_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_sel_subject.Font = new System.Drawing.Font("Logico Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_sel_subject.InterceptArrowKeys = false;
            this.e_sel_subject.Location = new System.Drawing.Point(16, 55);
            this.e_sel_subject.Name = "e_sel_subject";
            this.e_sel_subject.ReadOnly = true;
            this.e_sel_subject.Size = new System.Drawing.Size(159, 21);
            this.e_sel_subject.TabIndex = 53;
            // 
            // e_div_two
            // 
            this.e_div_two.BackColor = System.Drawing.Color.White;
            this.e_div_two.Location = new System.Drawing.Point(16, 37);
            this.e_div_two.Name = "e_div_two";
            this.e_div_two.Size = new System.Drawing.Size(239, 1);
            this.e_div_two.TabIndex = 72;
            this.e_div_two.TabStop = false;
            // 
            // e_div_three
            // 
            this.e_div_three.BackColor = System.Drawing.Color.White;
            this.e_div_three.Location = new System.Drawing.Point(16, 75);
            this.e_div_three.Name = "e_div_three";
            this.e_div_three.Size = new System.Drawing.Size(159, 1);
            this.e_div_three.TabIndex = 73;
            this.e_div_three.TabStop = false;
            // 
            // e_nav_close
            // 
            this.e_nav_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_close.Image = ((System.Drawing.Image)(resources.GetObject("e_nav_close.Image")));
            this.e_nav_close.Location = new System.Drawing.Point(520, 5);
            this.e_nav_close.Name = "e_nav_close";
            this.e_nav_close.Size = new System.Drawing.Size(20, 20);
            this.e_nav_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_close.TabIndex = 21;
            this.e_nav_close.TabStop = false;
            // 
            // ucpcreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(552, 375);
            this.Controls.Add(this.e_nav_close);
            this.Controls.Add(this.e_nav_title);
            this.Controls.Add(this.e_nav_logo);
            this.Controls.Add(this.e_nav_grab);
            this.Controls.Add(this.e_hider);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ucpcreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WINDOWNAME";
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_grab)).EndInit();
            this.e_hider.ResumeLayout(false);
            this.e_hider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_three)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label e_nav_title;
        private System.Windows.Forms.PictureBox e_nav_logo;
        private System.Windows.Forms.PictureBox e_nav_grab;
        private System.Windows.Forms.Panel e_hider;
        private System.Windows.Forms.DomainUpDown e_sel_subject;
        private System.Windows.Forms.Button e_but_create;
        private System.Windows.Forms.TextBox e_inp_topic;
        private System.Windows.Forms.PictureBox e_div_two;
        private System.Windows.Forms.PictureBox e_div_three;
        private System.Windows.Forms.PictureBox e_nav_close;
    }
}