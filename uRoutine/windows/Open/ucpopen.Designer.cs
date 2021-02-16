namespace User.Action
{
    partial class ucpopen
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Files");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucpopen));
            this.e_nav_title = new System.Windows.Forms.Label();
            this.e_hider = new System.Windows.Forms.Panel();
            this.e_list = new System.Windows.Forms.TreeView();
            this.e_nav_close = new System.Windows.Forms.PictureBox();
            this.e_nav_logo = new System.Windows.Forms.PictureBox();
            this.e_nav_grab = new System.Windows.Forms.PictureBox();
            this.e_hider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_grab)).BeginInit();
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
            // e_hider
            // 
            this.e_hider.Controls.Add(this.e_list);
            this.e_hider.Location = new System.Drawing.Point(1, 31);
            this.e_hider.Name = "e_hider";
            this.e_hider.Size = new System.Drawing.Size(340, 400);
            this.e_hider.TabIndex = 20;
            // 
            // e_list
            // 
            this.e_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_list.Font = new System.Drawing.Font("Logico Sans", 10F);
            this.e_list.ForeColor = System.Drawing.Color.White;
            this.e_list.Indent = 19;
            this.e_list.LineColor = System.Drawing.Color.White;
            this.e_list.Location = new System.Drawing.Point(11, 6);
            this.e_list.Name = "e_list";
            treeNode1.Name = "e_n_files";
            treeNode1.Text = "Files";
            this.e_list.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.e_list.Size = new System.Drawing.Size(320, 364);
            this.e_list.TabIndex = 65;
            this.e_list.DoubleClick += new System.EventHandler(this.OpenSessionClick);
            // 
            // e_nav_close
            // 
            this.e_nav_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.e_nav_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_close.Image = ((System.Drawing.Image)(resources.GetObject("e_nav_close.Image")));
            this.e_nav_close.Location = new System.Drawing.Point(329, 5);
            this.e_nav_close.Name = "e_nav_close";
            this.e_nav_close.Size = new System.Drawing.Size(20, 20);
            this.e_nav_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_close.TabIndex = 22;
            this.e_nav_close.TabStop = false;
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
            this.e_nav_grab.Size = new System.Drawing.Size(359, 30);
            this.e_nav_grab.TabIndex = 16;
            this.e_nav_grab.TabStop = false;
            // 
            // ucpopen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(361, 476);
            this.Controls.Add(this.e_nav_close);
            this.Controls.Add(this.e_hider);
            this.Controls.Add(this.e_nav_title);
            this.Controls.Add(this.e_nav_logo);
            this.Controls.Add(this.e_nav_grab);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ucpopen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WINDOWNAME";
            this.e_hider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_grab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label e_nav_title;
        private System.Windows.Forms.PictureBox e_nav_logo;
        private System.Windows.Forms.PictureBox e_nav_grab;
        private System.Windows.Forms.Panel e_hider;
        private System.Windows.Forms.PictureBox e_nav_close;
        private System.Windows.Forms.TreeView e_list;
    }
}