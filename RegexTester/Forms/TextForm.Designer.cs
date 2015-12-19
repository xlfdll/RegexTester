namespace RegexTester.Forms
{
    partial class TextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextForm));
            this.contentToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.contentToolStrip = new System.Windows.Forms.ToolStrip();
            this.contentFirstToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.contentOpenToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.styleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.contentStyleToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.wordWrapToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.wordWrapToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.positionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.positionToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.contentRichTextBoxContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoOrRedoActionToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedTextActionsToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteActionsToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleFontDialog = new System.Windows.Forms.FontDialog();
            this.contentToolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.contentToolStripContainer.ContentPanel.SuspendLayout();
            this.contentToolStripContainer.SuspendLayout();
            this.contentToolStrip.SuspendLayout();
            this.contentRichTextBoxContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentToolStripContainer
            // 
            // 
            // contentToolStripContainer.BottomToolStripPanel
            // 
            this.contentToolStripContainer.BottomToolStripPanel.Controls.Add(this.contentToolStrip);
            // 
            // contentToolStripContainer.ContentPanel
            // 
            this.contentToolStripContainer.ContentPanel.Controls.Add(this.contentRichTextBox);
            resources.ApplyResources(this.contentToolStripContainer.ContentPanel, "contentToolStripContainer.ContentPanel");
            resources.ApplyResources(this.contentToolStripContainer, "contentToolStripContainer");
            this.contentToolStripContainer.Name = "contentToolStripContainer";
            // 
            // contentToolStrip
            // 
            resources.ApplyResources(this.contentToolStrip, "contentToolStrip");
            this.contentToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.contentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentFirstToolStripSeparator,
            this.openToolStripButton,
            this.contentOpenToolStripSeparator,
            this.styleToolStripButton,
            this.contentStyleToolStripSeparator,
            this.wordWrapToolStripButton,
            this.wordWrapToolStripSeparator,
            this.positionToolStripLabel,
            this.positionToolStripSeparator});
            this.contentToolStrip.Name = "contentToolStrip";
            this.contentToolStrip.Stretch = true;
            this.contentToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contentToolStrip_ItemClicked);
            // 
            // contentFirstToolStripSeparator
            // 
            this.contentFirstToolStripSeparator.Name = "contentFirstToolStripSeparator";
            resources.ApplyResources(this.contentFirstToolStripSeparator, "contentFirstToolStripSeparator");
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.Image = global::RegexTester.Properties.Resources.Open;
            resources.ApplyResources(this.openToolStripButton, "openToolStripButton");
            this.openToolStripButton.Name = "openToolStripButton";
            // 
            // contentOpenToolStripSeparator
            // 
            this.contentOpenToolStripSeparator.Name = "contentOpenToolStripSeparator";
            resources.ApplyResources(this.contentOpenToolStripSeparator, "contentOpenToolStripSeparator");
            // 
            // styleToolStripButton
            // 
            this.styleToolStripButton.Image = global::RegexTester.Properties.Resources.Style;
            resources.ApplyResources(this.styleToolStripButton, "styleToolStripButton");
            this.styleToolStripButton.Name = "styleToolStripButton";
            // 
            // contentStyleToolStripSeparator
            // 
            this.contentStyleToolStripSeparator.Name = "contentStyleToolStripSeparator";
            resources.ApplyResources(this.contentStyleToolStripSeparator, "contentStyleToolStripSeparator");
            // 
            // wordWrapToolStripButton
            // 
            this.wordWrapToolStripButton.Checked = true;
            this.wordWrapToolStripButton.CheckOnClick = true;
            this.wordWrapToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordWrapToolStripButton.Image = global::RegexTester.Properties.Resources.WordWarp;
            resources.ApplyResources(this.wordWrapToolStripButton, "wordWrapToolStripButton");
            this.wordWrapToolStripButton.Name = "wordWrapToolStripButton";
            this.wordWrapToolStripButton.CheckedChanged += new System.EventHandler(this.wordWrapToolStripButton_CheckedChanged);
            // 
            // wordWrapToolStripSeparator
            // 
            this.wordWrapToolStripSeparator.Name = "wordWrapToolStripSeparator";
            resources.ApplyResources(this.wordWrapToolStripSeparator, "wordWrapToolStripSeparator");
            // 
            // positionToolStripLabel
            // 
            this.positionToolStripLabel.Name = "positionToolStripLabel";
            resources.ApplyResources(this.positionToolStripLabel, "positionToolStripLabel");
            // 
            // positionToolStripSeparator
            // 
            this.positionToolStripSeparator.Name = "positionToolStripSeparator";
            resources.ApplyResources(this.positionToolStripSeparator, "positionToolStripSeparator");
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contentRichTextBox.ContextMenuStrip = this.contentRichTextBoxContextMenuStrip;
            this.contentRichTextBox.DetectUrls = false;
            resources.ApplyResources(this.contentRichTextBox, "contentRichTextBox");
            this.contentRichTextBox.HideSelection = false;
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.SelectionChanged += new System.EventHandler(this.contentRichTextBox_EnterOrSelectionChanged);
            this.contentRichTextBox.TextChanged += new System.EventHandler(this.contentRichTextBox_TextChanged);
            // 
            // contentRichTextBoxContextMenuStrip
            // 
            this.contentRichTextBoxContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.undoOrRedoActionToolStripSeparator,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectedTextActionsToolStripSeparator,
            this.deleteToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.deleteActionsToolStripSeparator,
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem});
            this.contentRichTextBoxContextMenuStrip.Name = "contentRichTextBoxContextMenuStrip";
            resources.ApplyResources(this.contentRichTextBoxContextMenuStrip, "contentRichTextBoxContextMenuStrip");
            this.contentRichTextBoxContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contentRichTextBoxContextMenuStrip_Opening);
            this.contentRichTextBoxContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contentRichTextBoxContextMenuStrip_ItemClicked);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::RegexTester.Properties.Resources.Undo;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            this.undoToolStripMenuItem.Tag = "";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::RegexTester.Properties.Resources.Redo;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            this.redoToolStripMenuItem.Tag = "";
            // 
            // undoOrRedoActionToolStripSeparator
            // 
            this.undoOrRedoActionToolStripSeparator.Name = "undoOrRedoActionToolStripSeparator";
            resources.ApplyResources(this.undoOrRedoActionToolStripSeparator, "undoOrRedoActionToolStripSeparator");
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::RegexTester.Properties.Resources.Cut;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            this.cutToolStripMenuItem.Tag = "";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::RegexTester.Properties.Resources.Copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Tag = "";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::RegexTester.Properties.Resources.Paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Tag = "";
            // 
            // selectedTextActionsToolStripSeparator
            // 
            this.selectedTextActionsToolStripSeparator.Name = "selectedTextActionsToolStripSeparator";
            resources.ApplyResources(this.selectedTextActionsToolStripSeparator, "selectedTextActionsToolStripSeparator");
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::RegexTester.Properties.Resources.Delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Tag = "";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Tag = "";
            // 
            // deleteActionsToolStripSeparator
            // 
            this.deleteActionsToolStripSeparator.Name = "deleteActionsToolStripSeparator";
            resources.ApplyResources(this.deleteActionsToolStripSeparator, "deleteActionsToolStripSeparator");
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::RegexTester.Properties.Resources.Select;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            this.selectAllToolStripMenuItem.Tag = "";
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            resources.ApplyResources(this.deselectAllToolStripMenuItem, "deselectAllToolStripMenuItem");
            this.deselectAllToolStripMenuItem.Tag = "";
            // 
            // styleFontDialog
            // 
            this.styleFontDialog.AllowVerticalFonts = false;
            this.styleFontDialog.FontMustExist = true;
            this.styleFontDialog.ShowApply = true;
            this.styleFontDialog.ShowEffects = false;
            this.styleFontDialog.Apply += new System.EventHandler(this.styleFontDialog_Apply);
            // 
            // TextForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.contentToolStripContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.TextForm_Load);
            this.contentToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.contentToolStripContainer.BottomToolStripPanel.PerformLayout();
            this.contentToolStripContainer.ContentPanel.ResumeLayout(false);
            this.contentToolStripContainer.ResumeLayout(false);
            this.contentToolStripContainer.PerformLayout();
            this.contentToolStrip.ResumeLayout(false);
            this.contentToolStrip.PerformLayout();
            this.contentRichTextBoxContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contentRichTextBoxContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator undoOrRedoActionToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator deleteActionsToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator selectedTextActionsToolStripSeparator;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.ToolStrip contentToolStrip;
        private System.Windows.Forms.ToolStripSeparator contentFirstToolStripSeparator;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripSeparator contentOpenToolStripSeparator;
        private System.Windows.Forms.ToolStripButton wordWrapToolStripButton;
        private System.Windows.Forms.ToolStripSeparator wordWrapToolStripSeparator;
        private System.Windows.Forms.ToolStripLabel positionToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator positionToolStripSeparator;
        private System.Windows.Forms.ToolStripContainer contentToolStripContainer;
        private System.Windows.Forms.ToolStripSeparator contentStyleToolStripSeparator;
        private System.Windows.Forms.ToolStripButton styleToolStripButton;
        private System.Windows.Forms.FontDialog styleFontDialog;

    }
}