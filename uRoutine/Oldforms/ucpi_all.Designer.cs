namespace User.Forms
{
    partial class ucpi_all
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Files");
            this.e_list = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // e_list
            // 
            this.e_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.e_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e_list.Font = new System.Drawing.Font("Logico Sans", 10F);
            this.e_list.ForeColor = System.Drawing.Color.White;
            this.e_list.Indent = 19;
            this.e_list.LineColor = System.Drawing.Color.White;
            this.e_list.Location = new System.Drawing.Point(3, 3);
            this.e_list.Name = "e_list";
            treeNode1.Name = "e_n_files";
            treeNode1.Text = "Files";
            this.e_list.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.e_list.Size = new System.Drawing.Size(450, 274);
            this.e_list.TabIndex = 64;
            this.e_list.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.event_sel);
            this.e_list.DoubleClick += new System.EventHandler(this.event_open);
            // 
            // ucpi_all
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.e_list);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucpi_all";
            this.Size = new System.Drawing.Size(460, 280);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView   e_list;
    }
}
