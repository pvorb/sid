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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Home");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.Navigation = new System.Windows.Forms.TabControl();
            this.StructTab = new System.Windows.Forms.TabPage();
            this.Content = new System.Windows.Forms.TabControl();
            this.ContentTab = new System.Windows.Forms.TabPage();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.savePageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.recentlyOpenedPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentlyOpenedProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.StructureTools = new System.Windows.Forms.ToolStrip();
            this.SiteStructure = new System.Windows.Forms.TreeView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.Navigation.SuspendLayout();
            this.StructTab.SuspendLayout();
            this.Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.StructureTools.SuspendLayout();
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
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.newPageToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveDocumentToolStripMenuItem,
            this.savePageAsToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.toolStripSeparator3,
            this.recentlyOpenedPagesToolStripMenuItem,
            this.recentlyOpenedProjectsToolStripMenuItem,
            this.toolStripSeparator4,
            this.quitToolStripMenuItem});
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
            this.StructTab.Controls.Add(this.splitContainer1);
            this.StructTab.Location = new System.Drawing.Point(4, 22);
            this.StructTab.Name = "StructTab";
            this.StructTab.Padding = new System.Windows.Forms.Padding(3);
            this.StructTab.Size = new System.Drawing.Size(206, 403);
            this.StructTab.TabIndex = 0;
            this.StructTab.Text = "Website Structure";
            this.StructTab.UseVisualStyleBackColor = true;
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
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.newProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.N)));
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.newProjectToolStripMenuItem.Text = "New Project…";
            // 
            // newPageToolStripMenuItem
            // 
            this.newPageToolStripMenuItem.Name = "newPageToolStripMenuItem";
            this.newPageToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.newPageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newPageToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.newPageToolStripMenuItem.Text = "New Page…";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.O)));
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project…";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            // 
            // saveDocumentToolStripMenuItem
            // 
            this.saveDocumentToolStripMenuItem.Name = "saveDocumentToolStripMenuItem";
            this.saveDocumentToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveDocumentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveDocumentToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.saveDocumentToolStripMenuItem.Text = "Save Page";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.openFileToolStripMenuItem.Text = "Open Page…";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
            // 
            // savePageAsToolStripMenuItem
            // 
            this.savePageAsToolStripMenuItem.Name = "savePageAsToolStripMenuItem";
            this.savePageAsToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.savePageAsToolStripMenuItem.Text = "Save Page as…";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(277, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(277, 6);
            // 
            // recentlyOpenedPagesToolStripMenuItem
            // 
            this.recentlyOpenedPagesToolStripMenuItem.Name = "recentlyOpenedPagesToolStripMenuItem";
            this.recentlyOpenedPagesToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.recentlyOpenedPagesToolStripMenuItem.Text = "Recently opened Pages";
            // 
            // recentlyOpenedProjectsToolStripMenuItem
            // 
            this.recentlyOpenedProjectsToolStripMenuItem.Name = "recentlyOpenedProjectsToolStripMenuItem";
            this.recentlyOpenedProjectsToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.recentlyOpenedProjectsToolStripMenuItem.Text = "Recently opened Projects";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(277, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.StructureTools);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SiteStructure);
            this.splitContainer1.Size = new System.Drawing.Size(200, 397);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // StructureTools
            // 
            this.StructureTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StructureTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.StructureTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.StructureTools.Location = new System.Drawing.Point(0, 0);
            this.StructureTools.Name = "StructureTools";
            this.StructureTools.Size = new System.Drawing.Size(200, 25);
            this.StructureTools.TabIndex = 0;
            this.StructureTools.Text = "toolStrip1";
            // 
            // SiteStructure
            // 
            this.SiteStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SiteStructure.Location = new System.Drawing.Point(0, 0);
            this.SiteStructure.Name = "SiteStructure";
            treeNode2.Name = "Home";
            treeNode2.Text = "Home";
            this.SiteStructure.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.SiteStructure.PathSeparator = "/";
            this.SiteStructure.ShowNodeToolTips = true;
            this.SiteStructure.Size = new System.Drawing.Size(200, 368);
            this.SiteStructure.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.StructureTools.ResumeLayout(false);
            this.StructureTools.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem savePageAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem recentlyOpenedPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentlyOpenedProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip StructureTools;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TreeView SiteStructure;
    }
}

