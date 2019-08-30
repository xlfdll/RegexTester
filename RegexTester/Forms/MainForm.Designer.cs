namespace RegexTester
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.expressionToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.expressionPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.regexGroupBox = new System.Windows.Forms.GroupBox();
            this.regexComboBox = new System.Windows.Forms.ComboBox();
            this.regexEditButton = new System.Windows.Forms.Button();
            this.matchButton = new System.Windows.Forms.Button();
            this.spiltButton = new System.Windows.Forms.Button();
            this.replacementGroupBox = new System.Windows.Forms.GroupBox();
            this.replacementComboBox = new System.Windows.Forms.ComboBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.replacementEditButton = new System.Windows.Forms.Button();
            this.expressionToolStrip = new System.Windows.Forms.ToolStrip();
            this.openSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.regexOptionsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.regexOptionsToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.measureTimeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.resultToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.resultTreeView = new System.Windows.Forms.TreeView();
            this.resultToolStrip = new System.Windows.Forms.ToolStrip();
            this.copySelectedResultToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copySelectedResultToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.resultReportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.textToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.textRichTextBox = new System.Windows.Forms.RichTextBox();
            this.textToolStrip = new System.Windows.Forms.ToolStrip();
            this.openTextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openTextToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.textFontToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.textFontToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.wordWrapToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.wordWrapToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cursorPositionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.expressionGroupBox = new System.Windows.Forms.GroupBox();
            this.contentSplitContainer = new System.Windows.Forms.SplitContainer();
            this.textGroupBox = new System.Windows.Forms.GroupBox();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.expressionToolStripContainer.ContentPanel.SuspendLayout();
            this.expressionToolStripContainer.LeftToolStripPanel.SuspendLayout();
            this.expressionToolStripContainer.SuspendLayout();
            this.expressionPanel.SuspendLayout();
            this.regexGroupBox.SuspendLayout();
            this.replacementGroupBox.SuspendLayout();
            this.expressionToolStrip.SuspendLayout();
            this.resultToolStripContainer.ContentPanel.SuspendLayout();
            this.resultToolStripContainer.LeftToolStripPanel.SuspendLayout();
            this.resultToolStripContainer.SuspendLayout();
            this.resultToolStrip.SuspendLayout();
            this.textToolStripContainer.ContentPanel.SuspendLayout();
            this.textToolStripContainer.LeftToolStripPanel.SuspendLayout();
            this.textToolStripContainer.SuspendLayout();
            this.textToolStrip.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.expressionGroupBox.SuspendLayout();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            this.textGroupBox.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // expressionToolStripContainer
            // 
            this.expressionToolStripContainer.BottomToolStripPanelVisible = false;
            // 
            // expressionToolStripContainer.ContentPanel
            // 
            this.expressionToolStripContainer.ContentPanel.Controls.Add(this.expressionPanel);
            resources.ApplyResources(this.expressionToolStripContainer.ContentPanel, "expressionToolStripContainer.ContentPanel");
            resources.ApplyResources(this.expressionToolStripContainer, "expressionToolStripContainer");
            // 
            // expressionToolStripContainer.LeftToolStripPanel
            // 
            this.expressionToolStripContainer.LeftToolStripPanel.Controls.Add(this.expressionToolStrip);
            this.expressionToolStripContainer.Name = "expressionToolStripContainer";
            this.expressionToolStripContainer.RightToolStripPanelVisible = false;
            this.expressionToolStripContainer.TopToolStripPanelVisible = false;
            // 
            // expressionPanel
            // 
            this.expressionPanel.Controls.Add(this.clearButton);
            this.expressionPanel.Controls.Add(this.regexGroupBox);
            this.expressionPanel.Controls.Add(this.replacementGroupBox);
            resources.ApplyResources(this.expressionPanel, "expressionPanel");
            this.expressionPanel.Name = "expressionPanel";
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // regexGroupBox
            // 
            resources.ApplyResources(this.regexGroupBox, "regexGroupBox");
            this.regexGroupBox.Controls.Add(this.regexComboBox);
            this.regexGroupBox.Controls.Add(this.regexEditButton);
            this.regexGroupBox.Controls.Add(this.matchButton);
            this.regexGroupBox.Controls.Add(this.spiltButton);
            this.regexGroupBox.Name = "regexGroupBox";
            this.regexGroupBox.TabStop = false;
            // 
            // regexComboBox
            // 
            resources.ApplyResources(this.regexComboBox, "regexComboBox");
            this.regexComboBox.Name = "regexComboBox";
            // 
            // regexEditButton
            // 
            resources.ApplyResources(this.regexEditButton, "regexEditButton");
            this.regexEditButton.Image = global::RegexTester.Properties.Resources.Edit;
            this.regexEditButton.Name = "regexEditButton";
            this.regexEditButton.UseVisualStyleBackColor = true;
            this.regexEditButton.Click += new System.EventHandler(this.patternEditButton_Click);
            // 
            // matchButton
            // 
            resources.ApplyResources(this.matchButton, "matchButton");
            this.matchButton.Name = "matchButton";
            this.matchButton.UseVisualStyleBackColor = true;
            // 
            // spiltButton
            // 
            resources.ApplyResources(this.spiltButton, "spiltButton");
            this.spiltButton.Name = "spiltButton";
            this.spiltButton.UseVisualStyleBackColor = true;
            // 
            // replacementGroupBox
            // 
            resources.ApplyResources(this.replacementGroupBox, "replacementGroupBox");
            this.replacementGroupBox.Controls.Add(this.replacementComboBox);
            this.replacementGroupBox.Controls.Add(this.replaceButton);
            this.replacementGroupBox.Controls.Add(this.replacementEditButton);
            this.replacementGroupBox.Name = "replacementGroupBox";
            this.replacementGroupBox.TabStop = false;
            // 
            // replacementComboBox
            // 
            resources.ApplyResources(this.replacementComboBox, "replacementComboBox");
            this.replacementComboBox.Name = "replacementComboBox";
            // 
            // replaceButton
            // 
            resources.ApplyResources(this.replaceButton, "replaceButton");
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.UseVisualStyleBackColor = true;
            // 
            // replacementEditButton
            // 
            resources.ApplyResources(this.replacementEditButton, "replacementEditButton");
            this.replacementEditButton.Image = global::RegexTester.Properties.Resources.Edit;
            this.replacementEditButton.Name = "replacementEditButton";
            this.replacementEditButton.UseVisualStyleBackColor = true;
            this.replacementEditButton.Click += new System.EventHandler(this.patternEditButton_Click);
            // 
            // expressionToolStrip
            // 
            this.expressionToolStrip.CanOverflow = false;
            resources.ApplyResources(this.expressionToolStrip, "expressionToolStrip");
            this.expressionToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.expressionToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSearchToolStripButton,
            this.saveSearchToolStripButton,
            this.searchToolStripSeparator,
            this.regexOptionsToolStripButton,
            this.regexOptionsToolStripSeparator,
            this.measureTimeToolStripButton});
            this.expressionToolStrip.Name = "expressionToolStrip";
            this.expressionToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.expressionToolStrip.Stretch = true;
            // 
            // openSearchToolStripButton
            // 
            this.openSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openSearchToolStripButton.Image = global::RegexTester.Properties.Resources.Open;
            resources.ApplyResources(this.openSearchToolStripButton, "openSearchToolStripButton");
            this.openSearchToolStripButton.Name = "openSearchToolStripButton";
            // 
            // saveSearchToolStripButton
            // 
            this.saveSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveSearchToolStripButton.Image = global::RegexTester.Properties.Resources.Save;
            resources.ApplyResources(this.saveSearchToolStripButton, "saveSearchToolStripButton");
            this.saveSearchToolStripButton.Name = "saveSearchToolStripButton";
            // 
            // searchToolStripSeparator
            // 
            this.searchToolStripSeparator.Name = "searchToolStripSeparator";
            resources.ApplyResources(this.searchToolStripSeparator, "searchToolStripSeparator");
            // 
            // regexOptionsToolStripButton
            // 
            this.regexOptionsToolStripButton.CheckOnClick = true;
            this.regexOptionsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.regexOptionsToolStripButton.Image = global::RegexTester.Properties.Resources.RegexOptions;
            resources.ApplyResources(this.regexOptionsToolStripButton, "regexOptionsToolStripButton");
            this.regexOptionsToolStripButton.Name = "regexOptionsToolStripButton";
            // 
            // regexOptionsToolStripSeparator
            // 
            this.regexOptionsToolStripSeparator.Name = "regexOptionsToolStripSeparator";
            resources.ApplyResources(this.regexOptionsToolStripSeparator, "regexOptionsToolStripSeparator");
            // 
            // measureTimeToolStripButton
            // 
            this.measureTimeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.measureTimeToolStripButton.Image = global::RegexTester.Properties.Resources.Timer;
            resources.ApplyResources(this.measureTimeToolStripButton, "measureTimeToolStripButton");
            this.measureTimeToolStripButton.Name = "measureTimeToolStripButton";
            // 
            // resultToolStripContainer
            // 
            this.resultToolStripContainer.BottomToolStripPanelVisible = false;
            // 
            // resultToolStripContainer.ContentPanel
            // 
            this.resultToolStripContainer.ContentPanel.Controls.Add(this.resultTreeView);
            resources.ApplyResources(this.resultToolStripContainer.ContentPanel, "resultToolStripContainer.ContentPanel");
            resources.ApplyResources(this.resultToolStripContainer, "resultToolStripContainer");
            // 
            // resultToolStripContainer.LeftToolStripPanel
            // 
            this.resultToolStripContainer.LeftToolStripPanel.Controls.Add(this.resultToolStrip);
            this.resultToolStripContainer.Name = "resultToolStripContainer";
            this.resultToolStripContainer.RightToolStripPanelVisible = false;
            this.resultToolStripContainer.TopToolStripPanelVisible = false;
            // 
            // resultTreeView
            // 
            resources.ApplyResources(this.resultTreeView, "resultTreeView");
            this.resultTreeView.Name = "resultTreeView";
            // 
            // resultToolStrip
            // 
            resources.ApplyResources(this.resultToolStrip, "resultToolStrip");
            this.resultToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.resultToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySelectedResultToolStripButton,
            this.copySelectedResultToolStripSeparator,
            this.resultReportToolStripButton});
            this.resultToolStrip.Name = "resultToolStrip";
            this.resultToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.resultToolStrip.Stretch = true;
            // 
            // copySelectedResultToolStripButton
            // 
            this.copySelectedResultToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copySelectedResultToolStripButton.Image = global::RegexTester.Properties.Resources.Copy;
            resources.ApplyResources(this.copySelectedResultToolStripButton, "copySelectedResultToolStripButton");
            this.copySelectedResultToolStripButton.Name = "copySelectedResultToolStripButton";
            // 
            // copySelectedResultToolStripSeparator
            // 
            this.copySelectedResultToolStripSeparator.Name = "copySelectedResultToolStripSeparator";
            resources.ApplyResources(this.copySelectedResultToolStripSeparator, "copySelectedResultToolStripSeparator");
            // 
            // resultReportToolStripButton
            // 
            this.resultReportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resultReportToolStripButton.Image = global::RegexTester.Properties.Resources.Report;
            resources.ApplyResources(this.resultReportToolStripButton, "resultReportToolStripButton");
            this.resultReportToolStripButton.Name = "resultReportToolStripButton";
            // 
            // textToolStripContainer
            // 
            this.textToolStripContainer.BottomToolStripPanelVisible = false;
            // 
            // textToolStripContainer.ContentPanel
            // 
            this.textToolStripContainer.ContentPanel.Controls.Add(this.textRichTextBox);
            resources.ApplyResources(this.textToolStripContainer.ContentPanel, "textToolStripContainer.ContentPanel");
            resources.ApplyResources(this.textToolStripContainer, "textToolStripContainer");
            // 
            // textToolStripContainer.LeftToolStripPanel
            // 
            this.textToolStripContainer.LeftToolStripPanel.Controls.Add(this.textToolStrip);
            this.textToolStripContainer.Name = "textToolStripContainer";
            this.textToolStripContainer.RightToolStripPanelVisible = false;
            this.textToolStripContainer.TopToolStripPanelVisible = false;
            // 
            // textRichTextBox
            // 
            this.textRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRichTextBox.DetectUrls = false;
            resources.ApplyResources(this.textRichTextBox, "textRichTextBox");
            this.textRichTextBox.Name = "textRichTextBox";
            // 
            // textToolStrip
            // 
            resources.ApplyResources(this.textToolStrip, "textToolStrip");
            this.textToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.textToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTextToolStripButton,
            this.openTextToolStripSeparator,
            this.textFontToolStripButton,
            this.textFontToolStripSeparator,
            this.wordWrapToolStripButton,
            this.wordWrapToolStripSeparator,
            this.cursorPositionToolStripLabel});
            this.textToolStrip.Name = "textToolStrip";
            this.textToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.textToolStrip.Stretch = true;
            // 
            // openTextToolStripButton
            // 
            this.openTextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openTextToolStripButton.Image = global::RegexTester.Properties.Resources.OpenFile;
            resources.ApplyResources(this.openTextToolStripButton, "openTextToolStripButton");
            this.openTextToolStripButton.Name = "openTextToolStripButton";
            // 
            // openTextToolStripSeparator
            // 
            this.openTextToolStripSeparator.Name = "openTextToolStripSeparator";
            resources.ApplyResources(this.openTextToolStripSeparator, "openTextToolStripSeparator");
            // 
            // textFontToolStripButton
            // 
            this.textFontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textFontToolStripButton.Image = global::RegexTester.Properties.Resources.Font;
            resources.ApplyResources(this.textFontToolStripButton, "textFontToolStripButton");
            this.textFontToolStripButton.Name = "textFontToolStripButton";
            // 
            // textFontToolStripSeparator
            // 
            this.textFontToolStripSeparator.Name = "textFontToolStripSeparator";
            resources.ApplyResources(this.textFontToolStripSeparator, "textFontToolStripSeparator");
            // 
            // wordWrapToolStripButton
            // 
            this.wordWrapToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wordWrapToolStripButton.Image = global::RegexTester.Properties.Resources.WordWarp;
            resources.ApplyResources(this.wordWrapToolStripButton, "wordWrapToolStripButton");
            this.wordWrapToolStripButton.Name = "wordWrapToolStripButton";
            // 
            // wordWrapToolStripSeparator
            // 
            this.wordWrapToolStripSeparator.Name = "wordWrapToolStripSeparator";
            resources.ApplyResources(this.wordWrapToolStripSeparator, "wordWrapToolStripSeparator");
            // 
            // cursorPositionToolStripLabel
            // 
            this.cursorPositionToolStripLabel.Name = "cursorPositionToolStripLabel";
            resources.ApplyResources(this.cursorPositionToolStripLabel, "cursorPositionToolStripLabel");
            // 
            // mainSplitContainer
            // 
            resources.ApplyResources(this.mainSplitContainer, "mainSplitContainer");
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.expressionGroupBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.contentSplitContainer);
            // 
            // expressionGroupBox
            // 
            this.expressionGroupBox.Controls.Add(this.expressionToolStripContainer);
            resources.ApplyResources(this.expressionGroupBox, "expressionGroupBox");
            this.expressionGroupBox.Name = "expressionGroupBox";
            this.expressionGroupBox.TabStop = false;
            // 
            // contentSplitContainer
            // 
            resources.ApplyResources(this.contentSplitContainer, "contentSplitContainer");
            this.contentSplitContainer.Name = "contentSplitContainer";
            // 
            // contentSplitContainer.Panel1
            // 
            this.contentSplitContainer.Panel1.Controls.Add(this.textGroupBox);
            // 
            // contentSplitContainer.Panel2
            // 
            this.contentSplitContainer.Panel2.Controls.Add(this.resultGroupBox);
            // 
            // textGroupBox
            // 
            this.textGroupBox.Controls.Add(this.textToolStripContainer);
            resources.ApplyResources(this.textGroupBox, "textGroupBox");
            this.textGroupBox.Name = "textGroupBox";
            this.textGroupBox.TabStop = false;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.resultToolStripContainer);
            resources.ApplyResources(this.resultGroupBox, "resultGroupBox");
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "MainForm";
            this.expressionToolStripContainer.ContentPanel.ResumeLayout(false);
            this.expressionToolStripContainer.LeftToolStripPanel.ResumeLayout(false);
            this.expressionToolStripContainer.LeftToolStripPanel.PerformLayout();
            this.expressionToolStripContainer.ResumeLayout(false);
            this.expressionToolStripContainer.PerformLayout();
            this.expressionPanel.ResumeLayout(false);
            this.regexGroupBox.ResumeLayout(false);
            this.replacementGroupBox.ResumeLayout(false);
            this.expressionToolStrip.ResumeLayout(false);
            this.expressionToolStrip.PerformLayout();
            this.resultToolStripContainer.ContentPanel.ResumeLayout(false);
            this.resultToolStripContainer.LeftToolStripPanel.ResumeLayout(false);
            this.resultToolStripContainer.LeftToolStripPanel.PerformLayout();
            this.resultToolStripContainer.ResumeLayout(false);
            this.resultToolStripContainer.PerformLayout();
            this.resultToolStrip.ResumeLayout(false);
            this.resultToolStrip.PerformLayout();
            this.textToolStripContainer.ContentPanel.ResumeLayout(false);
            this.textToolStripContainer.LeftToolStripPanel.ResumeLayout(false);
            this.textToolStripContainer.LeftToolStripPanel.PerformLayout();
            this.textToolStripContainer.ResumeLayout(false);
            this.textToolStripContainer.PerformLayout();
            this.textToolStrip.ResumeLayout(false);
            this.textToolStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.expressionGroupBox.ResumeLayout(false);
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            this.contentSplitContainer.ResumeLayout(false);
            this.textGroupBox.ResumeLayout(false);
            this.resultGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.GroupBox expressionGroupBox;
        private System.Windows.Forms.ToolStripContainer expressionToolStripContainer;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox replacementGroupBox;
        private System.Windows.Forms.ComboBox replacementComboBox;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button replacementEditButton;
        private System.Windows.Forms.GroupBox regexGroupBox;
        private System.Windows.Forms.ComboBox regexComboBox;
        private System.Windows.Forms.Button regexEditButton;
        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.Button spiltButton;
        private System.Windows.Forms.ToolStrip expressionToolStrip;
        private System.Windows.Forms.SplitContainer contentSplitContainer;
        private System.Windows.Forms.GroupBox textGroupBox;
        private System.Windows.Forms.ToolStripContainer textToolStripContainer;
        private System.Windows.Forms.RichTextBox textRichTextBox;
        private System.Windows.Forms.ToolStrip textToolStrip;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.ToolStripContainer resultToolStripContainer;
        private System.Windows.Forms.TreeView resultTreeView;
        private System.Windows.Forms.ToolStrip resultToolStrip;
        private System.Windows.Forms.Panel expressionPanel;
        private System.Windows.Forms.ToolStripButton openSearchToolStripButton;
        private System.Windows.Forms.ToolStripButton saveSearchToolStripButton;
        private System.Windows.Forms.ToolStripSeparator searchToolStripSeparator;
        private System.Windows.Forms.ToolStripButton measureTimeToolStripButton;
        private System.Windows.Forms.ToolStripSeparator regexOptionsToolStripSeparator;
        private System.Windows.Forms.ToolStripButton copySelectedResultToolStripButton;
        private System.Windows.Forms.ToolStripSeparator copySelectedResultToolStripSeparator;
        private System.Windows.Forms.ToolStripButton resultReportToolStripButton;
        private System.Windows.Forms.ToolStripButton openTextToolStripButton;
        private System.Windows.Forms.ToolStripSeparator openTextToolStripSeparator;
        private System.Windows.Forms.ToolStripButton textFontToolStripButton;
        private System.Windows.Forms.ToolStripSeparator textFontToolStripSeparator;
        private System.Windows.Forms.ToolStripButton wordWrapToolStripButton;
        private System.Windows.Forms.ToolStripSeparator wordWrapToolStripSeparator;
        private System.Windows.Forms.ToolStripLabel cursorPositionToolStripLabel;
        private System.Windows.Forms.ToolStripButton regexOptionsToolStripButton;
    }
}

