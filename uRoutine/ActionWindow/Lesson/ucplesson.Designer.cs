namespace User
{
    partial class ucplesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucplesson));
            this.e_info_date = new System.Windows.Forms.Label();
            this.e_tree = new System.Windows.Forms.TreeView();
            this.e_inp_topic = new System.Windows.Forms.TextBox();
            this.e_inp_file = new System.Windows.Forms.TextBox();
            this.e_but_file_deletelesson = new System.Windows.Forms.PictureBox();
            this.e_but_file_folder = new System.Windows.Forms.PictureBox();
            this.e_but_file_append = new System.Windows.Forms.PictureBox();
            this.e_but_file_rename = new System.Windows.Forms.PictureBox();
            this.e_but_file_remove = new System.Windows.Forms.PictureBox();
            this.e_but_file_add = new System.Windows.Forms.PictureBox();
            this.e_div_five = new System.Windows.Forms.PictureBox();
            this.e_nav_close = new System.Windows.Forms.PictureBox();
            this.e_div = new System.Windows.Forms.PictureBox();
            this.e_nav = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_deletelesson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_folder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_append)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_rename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_five)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).BeginInit();
            this.SuspendLayout();
            // 
            // e_info_date
            // 
            this.e_info_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_info_date.Font = new System.Drawing.Font("Logico Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_info_date.ForeColor = System.Drawing.Color.White;
            this.e_info_date.Location = new System.Drawing.Point(9, 315);
            this.e_info_date.Name = "e_info_date";
            this.e_info_date.Size = new System.Drawing.Size(220, 18);
            this.e_info_date.TabIndex = 51;
            this.e_info_date.Text = "00.00.0000 00:00";
            this.e_info_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // e_tree
            // 
            this.e_tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.e_tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_tree.Font = new System.Drawing.Font("Logico Sans", 10F);
            this.e_tree.ForeColor = System.Drawing.Color.White;
            this.e_tree.Location = new System.Drawing.Point(48, 45);
            this.e_tree.Name = "e_tree";
            treeNode1.Name = "e_n_files";
            treeNode1.Text = "Files";
            this.e_tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.e_tree.ShowLines = false;
            this.e_tree.ShowPlusMinus = false;
            this.e_tree.ShowRootLines = false;
            this.e_tree.Size = new System.Drawing.Size(181, 240);
            this.e_tree.TabIndex = 63;
            this.e_tree.DoubleClick += new System.EventHandler(this.event_doubleclick);
            // 
            // e_inp_topic
            // 
            this.e_inp_topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_inp_topic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_topic.Font = new System.Drawing.Font("Logico Sans", 12F);
            this.e_inp_topic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.e_inp_topic.Location = new System.Drawing.Point(12, 6);
            this.e_inp_topic.Name = "e_inp_topic";
            this.e_inp_topic.Size = new System.Drawing.Size(191, 19);
            this.e_inp_topic.TabIndex = 64;
            this.e_inp_topic.Text = "Topic";
            this.e_inp_topic.TextChanged += new System.EventHandler(this.event_edittopic);
            // 
            // e_inp_file
            // 
            this.e_inp_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.e_inp_file.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_inp_file.Font = new System.Drawing.Font("Logico Sans", 13F);
            this.e_inp_file.ForeColor = System.Drawing.Color.White;
            this.e_inp_file.Location = new System.Drawing.Point(48, 291);
            this.e_inp_file.MaxLength = 100;
            this.e_inp_file.Name = "e_inp_file";
            this.e_inp_file.Size = new System.Drawing.Size(181, 21);
            this.e_inp_file.TabIndex = 77;
            // 
            // e_but_file_deletelesson
            // 
            this.e_but_file_deletelesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_deletelesson.Image = global::User.Properties.Resources.deletelesson;
            this.e_but_file_deletelesson.Location = new System.Drawing.Point(12, 282);
            this.e_but_file_deletelesson.Name = "e_but_file_deletelesson";
            this.e_but_file_deletelesson.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_deletelesson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_deletelesson.TabIndex = 81;
            this.e_but_file_deletelesson.TabStop = false;
            this.e_but_file_deletelesson.Click += new System.EventHandler(this.click_deletelesson);
            // 
            // e_but_file_folder
            // 
            this.e_but_file_folder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_folder.Image = global::User.Properties.Resources.openinfolder;
            this.e_but_file_folder.Location = new System.Drawing.Point(12, 246);
            this.e_but_file_folder.Name = "e_but_file_folder";
            this.e_but_file_folder.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_folder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_folder.TabIndex = 81;
            this.e_but_file_folder.TabStop = false;
            this.e_but_file_folder.Click += new System.EventHandler(this.click_openfolder);
            // 
            // e_but_file_append
            // 
            this.e_but_file_append.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_append.Image = global::User.Properties.Resources.adddexternal;
            this.e_but_file_append.Location = new System.Drawing.Point(12, 153);
            this.e_but_file_append.Name = "e_but_file_append";
            this.e_but_file_append.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_append.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_append.TabIndex = 80;
            this.e_but_file_append.TabStop = false;
            this.e_but_file_append.Click += new System.EventHandler(this.click_externaladd);
            // 
            // e_but_file_rename
            // 
            this.e_but_file_rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_rename.Image = global::User.Properties.Resources.edit;
            this.e_but_file_rename.Location = new System.Drawing.Point(12, 117);
            this.e_but_file_rename.Name = "e_but_file_rename";
            this.e_but_file_rename.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_rename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_rename.TabIndex = 80;
            this.e_but_file_rename.TabStop = false;
            this.e_but_file_rename.Click += new System.EventHandler(this.click_rename);
            // 
            // e_but_file_remove
            // 
            this.e_but_file_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_remove.Image = global::User.Properties.Resources.delete;
            this.e_but_file_remove.Location = new System.Drawing.Point(12, 81);
            this.e_but_file_remove.Name = "e_but_file_remove";
            this.e_but_file_remove.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_remove.TabIndex = 80;
            this.e_but_file_remove.TabStop = false;
            this.e_but_file_remove.Click += new System.EventHandler(this.click_remove);
            // 
            // e_but_file_add
            // 
            this.e_but_file_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_but_file_add.Image = global::User.Properties.Resources.create;
            this.e_but_file_add.Location = new System.Drawing.Point(12, 45);
            this.e_but_file_add.Name = "e_but_file_add";
            this.e_but_file_add.Size = new System.Drawing.Size(30, 30);
            this.e_but_file_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_but_file_add.TabIndex = 80;
            this.e_but_file_add.TabStop = false;
            this.e_but_file_add.Click += new System.EventHandler(this.click_add);
            // 
            // e_div_five
            // 
            this.e_div_five.BackColor = System.Drawing.Color.White;
            this.e_div_five.Location = new System.Drawing.Point(48, 311);
            this.e_div_five.Name = "e_div_five";
            this.e_div_five.Size = new System.Drawing.Size(181, 1);
            this.e_div_five.TabIndex = 78;
            this.e_div_five.TabStop = false;
            // 
            // e_nav_close
            // 
            this.e_nav_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav_close.Image = ((System.Drawing.Image)(resources.GetObject("e_nav_close.Image")));
            this.e_nav_close.Location = new System.Drawing.Point(209, 5);
            this.e_nav_close.Name = "e_nav_close";
            this.e_nav_close.Size = new System.Drawing.Size(20, 20);
            this.e_nav_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_nav_close.TabIndex = 66;
            this.e_nav_close.TabStop = false;
            this.e_nav_close.Click += new System.EventHandler(this.click_close);
            // 
            // e_div
            // 
            this.e_div.BackColor = System.Drawing.Color.White;
            this.e_div.Location = new System.Drawing.Point(0, 0);
            this.e_div.Name = "e_div";
            this.e_div.Size = new System.Drawing.Size(1, 750);
            this.e_div.TabIndex = 48;
            this.e_div.TabStop = false;
            // 
            // e_nav
            // 
            this.e_nav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.e_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.e_nav.Location = new System.Drawing.Point(0, 0);
            this.e_nav.Name = "e_nav";
            this.e_nav.Size = new System.Drawing.Size(1090, 30);
            this.e_nav.TabIndex = 68;
            this.e_nav.TabStop = false;
            // 
            // ucplesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(240, 340);
            this.Controls.Add(this.e_nav_close);
            this.Controls.Add(this.e_but_file_deletelesson);
            this.Controls.Add(this.e_but_file_folder);
            this.Controls.Add(this.e_but_file_append);
            this.Controls.Add(this.e_but_file_rename);
            this.Controls.Add(this.e_but_file_remove);
            this.Controls.Add(this.e_but_file_add);
            this.Controls.Add(this.e_div_five);
            this.Controls.Add(this.e_inp_file);
            this.Controls.Add(this.e_inp_topic);
            this.Controls.Add(this.e_tree);
            this.Controls.Add(this.e_info_date);
            this.Controls.Add(this.e_div);
            this.Controls.Add(this.e_nav);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ucplesson";
            this.Text = "Lesson";
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_deletelesson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_folder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_append)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_rename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_but_file_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div_five)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_nav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox e_div;
        private System.Windows.Forms.Label e_info_date;
        private System.Windows.Forms.TreeView e_tree;
        private System.Windows.Forms.TextBox e_inp_topic;
        private System.Windows.Forms.PictureBox e_nav_close;
        private System.Windows.Forms.PictureBox e_nav;
        private System.Windows.Forms.PictureBox e_div_five;
        private System.Windows.Forms.TextBox e_inp_file;
        private System.Windows.Forms.PictureBox e_but_file_add;
        private System.Windows.Forms.PictureBox e_but_file_remove;
        private System.Windows.Forms.PictureBox e_but_file_rename;
        private System.Windows.Forms.PictureBox e_but_file_append;
        private System.Windows.Forms.PictureBox e_but_file_folder;
        private System.Windows.Forms.PictureBox e_but_file_deletelesson;
    }
}