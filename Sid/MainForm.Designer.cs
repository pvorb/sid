namespace ContentManagement
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sample");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Home", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.Navigation = new System.Windows.Forms.TabControl();
            this.StructTab = new System.Windows.Forms.TabPage();
            this.SiteStructure = new System.Windows.Forms.TreeView();
            this.Content = new System.Windows.Forms.TabControl();
            this.ContentTab = new System.Windows.Forms.TabPage();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.Navigation.SuspendLayout();
            this.StructTab.SuspendLayout();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(643, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 453);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(643, 22);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 24);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.Navigation);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.Content);
            this.SplitContainer.Size = new System.Drawing.Size(643, 429);
            this.SplitContainer.SplitterDistance = 214;
            this.SplitContainer.TabIndex = 2;
            // 
            // Navigation
            // 
            this.Navigation.Controls.Add(this.StructTab);
            this.Navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Navigation.Location = new System.Drawing.Point(0, 0);
            this.Navigation.Name = "Navigation";
            this.Navigation.SelectedIndex = 0;
            this.Navigation.Size = new System.Drawing.Size(214, 429);
            this.Navigation.TabIndex = 0;
            // 
            // StructTab
            // 
            this.StructTab.Controls.Add(this.SiteStructure);
            this.StructTab.Location = new System.Drawing.Point(4, 22);
            this.StructTab.Name = "StructTab";
            this.StructTab.Padding = new System.Windows.Forms.Padding(3);
            this.StructTab.Size = new System.Drawing.Size(206, 403);
            this.StructTab.TabIndex = 0;
            this.StructTab.Text = "Website Structure";
            this.StructTab.UseVisualStyleBackColor = true;
            // 
            // SiteStructure
            // 
            this.SiteStructure.AllowDrop = true;
            this.SiteStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SiteStructure.Location = new System.Drawing.Point(3, 3);
            this.SiteStructure.Name = "SiteStructure";
            treeNode3.Name = "Sample Page";
            treeNode3.Text = "Sample";
            treeNode4.Name = "Home";
            treeNode4.Text = "Home";
            this.SiteStructure.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.SiteStructure.PathSeparator = "/";
            this.SiteStructure.Size = new System.Drawing.Size(200, 397);
            this.SiteStructure.TabIndex = 0;
            // 
            // Content
            // 
            this.Content.Controls.Add(this.ContentTab);
            this.Content.Controls.Add(this.InfoTab);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.SelectedIndex = 0;
            this.Content.Size = new System.Drawing.Size(425, 429);
            this.Content.TabIndex = 0;
            // 
            // ContentTab
            // 
            this.ContentTab.Location = new System.Drawing.Point(4, 22);
            this.ContentTab.Name = "ContentTab";
            this.ContentTab.Padding = new System.Windows.Forms.Padding(3);
            this.ContentTab.Size = new System.Drawing.Size(417, 403);
            this.ContentTab.TabIndex = 2;
            this.ContentTab.Text = "Content";
            this.ContentTab.UseVisualStyleBackColor = true;
            // 
            // InfoTab
            // 
            this.InfoTab.Location = new System.Drawing.Point(4, 22);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.InfoTab.Size = new System.Drawing.Size(417, 403);
            this.InfoTab.TabIndex = 3;
            this.InfoTab.Text = "Information";
            this.InfoTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 475);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "Content Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.Navigation.ResumeLayout(false);
            this.StructTab.ResumeLayout(false);
            this.Content.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.TabControl Content;
        private System.Windows.Forms.TabControl Navigation;
        private System.Windows.Forms.TabPage StructTab;
        private System.Windows.Forms.TabPage ContentTab;
        private System.Windows.Forms.TabPage InfoTab;
        private System.Windows.Forms.TreeView SiteStructure;
    }
}

