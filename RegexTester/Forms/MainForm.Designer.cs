namespace RegexTester.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.regexMSDNLinkLabel = new System.Windows.Forms.LinkLabel();
            this.replacePatternComboBox = new System.Windows.Forms.ComboBox();
            this.regexPatternComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.spiltButton = new System.Windows.Forms.Button();
            this.matchButton = new System.Windows.Forms.Button();
            this.tickButton = new System.Windows.Forms.Button();
            this.bottomSplitContainer = new System.Windows.Forms.SplitContainer();
            this.subBottomSplitContainer = new System.Windows.Forms.SplitContainer();
            this.regexPatternEditButton = new System.Windows.Forms.Button();
            this.replacePatternEditButton = new System.Windows.Forms.Button();
            this.regexGroupBox = new System.Windows.Forms.GroupBox();
            this.replaceGroupBox = new System.Windows.Forms.GroupBox();
            this.bottomSplitContainer.Panel1.SuspendLayout();
            this.bottomSplitContainer.Panel2.SuspendLayout();
            this.bottomSplitContainer.SuspendLayout();
            this.subBottomSplitContainer.Panel1.SuspendLayout();
            this.subBottomSplitContainer.Panel2.SuspendLayout();
            this.subBottomSplitContainer.SuspendLayout();
            this.regexGroupBox.SuspendLayout();
            this.replaceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // copyrightLabel
            // 
            resources.ApplyResources(this.copyrightLabel, "copyrightLabel");
            this.copyrightLabel.Name = "copyrightLabel";
            // 
            // regexMSDNLinkLabel
            // 
            resources.ApplyResources(this.regexMSDNLinkLabel, "regexMSDNLinkLabel");
            this.regexMSDNLinkLabel.Name = "regexMSDNLinkLabel";
            this.regexMSDNLinkLabel.TabStop = true;
            this.regexMSDNLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regexMSDNLinkLabel_LinkClicked);
            // 
            // replacePatternComboBox
            // 
            resources.ApplyResources(this.replacePatternComboBox, "replacePatternComboBox");
            this.replacePatternComboBox.Name = "replacePatternComboBox";
            this.replacePatternComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.patternComboBox_KeyDown);
            this.replacePatternComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patternComboBox_KeyPress);
            // 
            // regexPatternComboBox
            // 
            resources.ApplyResources(this.regexPatternComboBox, "regexPatternComboBox");
            this.regexPatternComboBox.Name = "regexPatternComboBox";
            this.regexPatternComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.patternComboBox_KeyDown);
            this.regexPatternComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patternComboBox_KeyPress);
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // replaceButton
            // 
            resources.ApplyResources(this.replaceButton, "replaceButton");
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.textProcessButton_Click);
            // 
            // spiltButton
            // 
            resources.ApplyResources(this.spiltButton, "spiltButton");
            this.spiltButton.Name = "spiltButton";
            this.spiltButton.UseVisualStyleBackColor = true;
            this.spiltButton.Click += new System.EventHandler(this.textProcessButton_Click);
            // 
            // matchButton
            // 
            resources.ApplyResources(this.matchButton, "matchButton");
            this.matchButton.Name = "matchButton";
            this.matchButton.UseVisualStyleBackColor = true;
            this.matchButton.Click += new System.EventHandler(this.matchButton_Click);
            // 
            // tickButton
            // 
            resources.ApplyResources(this.tickButton, "tickButton");
            this.tickButton.Name = "tickButton";
            this.tickButton.Tag = "";
            this.tickButton.UseVisualStyleBackColor = true;
            this.tickButton.Click += new System.EventHandler(this.tickButton_Click);
            // 
            // bottomSplitContainer
            // 
            resources.ApplyResources(this.bottomSplitContainer, "bottomSplitContainer");
            this.bottomSplitContainer.Name = "bottomSplitContainer";
            // 
            // bottomSplitContainer.Panel1
            // 
            this.bottomSplitContainer.Panel1.Controls.Add(this.copyrightLabel);
            // 
            // bottomSplitContainer.Panel2
            // 
            this.bottomSplitContainer.Panel2.Controls.Add(this.subBottomSplitContainer);
            // 
            // subBottomSplitContainer
            // 
            resources.ApplyResources(this.subBottomSplitContainer, "subBottomSplitContainer");
            this.subBottomSplitContainer.Name = "subBottomSplitContainer";
            // 
            // subBottomSplitContainer.Panel1
            // 
            this.subBottomSplitContainer.Panel1.Controls.Add(this.tickButton);
            // 
            // subBottomSplitContainer.Panel2
            // 
            this.subBottomSplitContainer.Panel2.Controls.Add(this.regexMSDNLinkLabel);
            // 
            // regexPatternEditButton
            // 
            resources.ApplyResources(this.regexPatternEditButton, "regexPatternEditButton");
            this.regexPatternEditButton.Image = global::RegexTester.Properties.Resources.Edit;
            this.regexPatternEditButton.Name = "regexPatternEditButton";
            this.regexPatternEditButton.UseVisualStyleBackColor = true;
            this.regexPatternEditButton.Click += new System.EventHandler(this.patternEditButton_Click);
            // 
            // replacePatternEditButton
            // 
            resources.ApplyResources(this.replacePatternEditButton, "replacePatternEditButton");
            this.replacePatternEditButton.Image = global::RegexTester.Properties.Resources.Edit;
            this.replacePatternEditButton.Name = "replacePatternEditButton";
            this.replacePatternEditButton.UseVisualStyleBackColor = true;
            this.replacePatternEditButton.Click += new System.EventHandler(this.patternEditButton_Click);
            // 
            // regexGroupBox
            // 
            this.regexGroupBox.Controls.Add(this.regexPatternComboBox);
            this.regexGroupBox.Controls.Add(this.regexPatternEditButton);
            this.regexGroupBox.Controls.Add(this.matchButton);
            this.regexGroupBox.Controls.Add(this.spiltButton);
            resources.ApplyResources(this.regexGroupBox, "regexGroupBox");
            this.regexGroupBox.Name = "regexGroupBox";
            this.regexGroupBox.TabStop = false;
            // 
            // replaceGroupBox
            // 
            this.replaceGroupBox.Controls.Add(this.replacePatternComboBox);
            this.replaceGroupBox.Controls.Add(this.replaceButton);
            this.replaceGroupBox.Controls.Add(this.replacePatternEditButton);
            resources.ApplyResources(this.replaceGroupBox, "replaceGroupBox");
            this.replaceGroupBox.Name = "replaceGroupBox";
            this.replaceGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.replaceGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.regexGroupBox);
            this.Controls.Add(this.bottomSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.bottomSplitContainer.Panel1.ResumeLayout(false);
            this.bottomSplitContainer.Panel2.ResumeLayout(false);
            this.bottomSplitContainer.ResumeLayout(false);
            this.subBottomSplitContainer.Panel1.ResumeLayout(false);
            this.subBottomSplitContainer.Panel2.ResumeLayout(false);
            this.subBottomSplitContainer.Panel2.PerformLayout();
            this.subBottomSplitContainer.ResumeLayout(false);
            this.regexGroupBox.ResumeLayout(false);
            this.replaceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.LinkLabel regexMSDNLinkLabel;
        private System.Windows.Forms.ComboBox replacePatternComboBox;
        private System.Windows.Forms.ComboBox regexPatternComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button spiltButton;
        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.Button tickButton;
        private System.Windows.Forms.SplitContainer bottomSplitContainer;
        private System.Windows.Forms.SplitContainer subBottomSplitContainer;
        private System.Windows.Forms.Button regexPatternEditButton;
        private System.Windows.Forms.Button replacePatternEditButton;
        private System.Windows.Forms.GroupBox regexGroupBox;
        private System.Windows.Forms.GroupBox replaceGroupBox;


    }
}