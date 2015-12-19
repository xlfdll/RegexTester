namespace RegexTester.Forms
{
    partial class ResultForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.resultToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.resultTreeView = new System.Windows.Forms.TreeView();
            this.resultToolStrip = new System.Windows.Forms.ToolStrip();
            this.resultFirstToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.resultValueCopyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.resultToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.resultReportImportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.resultReportExportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.resultStateToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.resultNodeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripContainer.ContentPanel.SuspendLayout();
            this.resultToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.resultToolStripContainer.SuspendLayout();
            this.resultToolStrip.SuspendLayout();
            this.resultNodeContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultToolStripContainer
            // 
            // 
            // resultToolStripContainer.ContentPanel
            // 
            this.resultToolStripContainer.ContentPanel.Controls.Add(this.resultTreeView);
            resources.ApplyResources(this.resultToolStripContainer.ContentPanel, "resultToolStripContainer.ContentPanel");
            resources.ApplyResources(this.resultToolStripContainer, "resultToolStripContainer");
            this.resultToolStripContainer.Name = "resultToolStripContainer";
            // 
            // resultToolStripContainer.TopToolStripPanel
            // 
            this.resultToolStripContainer.TopToolStripPanel.Controls.Add(this.resultToolStrip);
            // 
            // resultTreeView
            // 
            resources.ApplyResources(this.resultTreeView, "resultTreeView");
            this.resultTreeView.HideSelection = false;
            this.resultTreeView.HotTracking = true;
            this.resultTreeView.ItemHeight = 20;
            this.resultTreeView.Name = "resultTreeView";
            this.resultTreeView.ShowNodeToolTips = true;
            this.resultTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.resultTreeView_AfterSelect);
            this.resultTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.resultTreeView_NodeMouseClick);
            this.resultTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.resultTreeView_NodeMouseDoubleClick);
            // 
            // resultToolStrip
            // 
            resources.ApplyResources(this.resultToolStrip, "resultToolStrip");
            this.resultToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.resultToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultFirstToolStripSeparator,
            this.resultValueCopyToolStripButton,
            this.resultToolStripSeparator,
            this.resultReportImportToolStripButton,
            this.resultReportExportToolStripButton,
            this.resultStateToolStripSeparator});
            this.resultToolStrip.Name = "resultToolStrip";
            this.resultToolStrip.Stretch = true;
            this.resultToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.resultToolStrip_ItemClicked);
            // 
            // resultFirstToolStripSeparator
            // 
            this.resultFirstToolStripSeparator.Name = "resultFirstToolStripSeparator";
            resources.ApplyResources(this.resultFirstToolStripSeparator, "resultFirstToolStripSeparator");
            // 
            // resultValueCopyToolStripButton
            // 
            resources.ApplyResources(this.resultValueCopyToolStripButton, "resultValueCopyToolStripButton");
            this.resultValueCopyToolStripButton.Image = global::RegexTester.Properties.Resources.Copy;
            this.resultValueCopyToolStripButton.Name = "resultValueCopyToolStripButton";
            // 
            // resultToolStripSeparator
            // 
            this.resultToolStripSeparator.Name = "resultToolStripSeparator";
            resources.ApplyResources(this.resultToolStripSeparator, "resultToolStripSeparator");
            // 
            // resultReportImportToolStripButton
            // 
            this.resultReportImportToolStripButton.Image = global::RegexTester.Properties.Resources.Import;
            resources.ApplyResources(this.resultReportImportToolStripButton, "resultReportImportToolStripButton");
            this.resultReportImportToolStripButton.Name = "resultReportImportToolStripButton";
            // 
            // resultReportExportToolStripButton
            // 
            resources.ApplyResources(this.resultReportExportToolStripButton, "resultReportExportToolStripButton");
            this.resultReportExportToolStripButton.Image = global::RegexTester.Properties.Resources.Export;
            this.resultReportExportToolStripButton.Name = "resultReportExportToolStripButton";
            // 
            // resultStateToolStripSeparator
            // 
            this.resultStateToolStripSeparator.Name = "resultStateToolStripSeparator";
            resources.ApplyResources(this.resultStateToolStripSeparator, "resultStateToolStripSeparator");
            // 
            // resultNodeContextMenuStrip
            // 
            this.resultNodeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.resultNodeContextMenuStrip.Name = "resultTreeViewContextMenuStrip";
            resources.ApplyResources(this.resultNodeContextMenuStrip, "resultNodeContextMenuStrip");
            this.resultNodeContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.resultTreeViewContextMenuStrip_Opening);
            this.resultNodeContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.resultTreeViewContextMenuStrip_ItemClicked);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::RegexTester.Properties.Resources.Copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            // 
            // ResultForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.resultToolStripContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm";
            this.ShowInTaskbar = false;
            this.TextChanged += new System.EventHandler(this.ResultForm_TextChanged);
            this.resultToolStripContainer.ContentPanel.ResumeLayout(false);
            this.resultToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.resultToolStripContainer.TopToolStripPanel.PerformLayout();
            this.resultToolStripContainer.ResumeLayout(false);
            this.resultToolStripContainer.PerformLayout();
            this.resultToolStrip.ResumeLayout(false);
            this.resultToolStrip.PerformLayout();
            this.resultNodeContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView resultTreeView;
        private System.Windows.Forms.ToolStrip resultToolStrip;
        private System.Windows.Forms.ToolStripSeparator resultFirstToolStripSeparator;
        private System.Windows.Forms.ToolStripButton resultValueCopyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator resultToolStripSeparator;
        private System.Windows.Forms.ToolStripButton resultReportImportToolStripButton;
        private System.Windows.Forms.ToolStripButton resultReportExportToolStripButton;
        private System.Windows.Forms.ToolStripSeparator resultStateToolStripSeparator;
        private System.Windows.Forms.ContextMenuStrip resultNodeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer resultToolStripContainer;


    }
}