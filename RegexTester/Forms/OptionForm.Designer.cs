namespace RegexTester.Forms
{
    partial class OptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.compiledCheckBox = new System.Windows.Forms.CheckBox();
            this.cultureInvariantCheckBox = new System.Windows.Forms.CheckBox();
            this.ecmaScriptCheckBox = new System.Windows.Forms.CheckBox();
            this.rightToLeftCheckBox = new System.Windows.Forms.CheckBox();
            this.ignorePatternWhitespaceCheckBox = new System.Windows.Forms.CheckBox();
            this.singleLineCheckBox = new System.Windows.Forms.CheckBox();
            this.explicitCaptureCheckBox = new System.Windows.Forms.CheckBox();
            this.multiLineCheckBox = new System.Windows.Forms.CheckBox();
            this.ignoreCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.optionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.optionTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // compiledCheckBox
            // 
            resources.ApplyResources(this.compiledCheckBox, "compiledCheckBox");
            this.compiledCheckBox.Name = "compiledCheckBox";
            this.compiledCheckBox.UseVisualStyleBackColor = true;
            // 
            // cultureInvariantCheckBox
            // 
            resources.ApplyResources(this.cultureInvariantCheckBox, "cultureInvariantCheckBox");
            this.cultureInvariantCheckBox.Name = "cultureInvariantCheckBox";
            this.cultureInvariantCheckBox.UseVisualStyleBackColor = true;
            // 
            // ecmaScriptCheckBox
            // 
            resources.ApplyResources(this.ecmaScriptCheckBox, "ecmaScriptCheckBox");
            this.ecmaScriptCheckBox.Name = "ecmaScriptCheckBox";
            this.ecmaScriptCheckBox.UseVisualStyleBackColor = true;
            // 
            // rightToLeftCheckBox
            // 
            resources.ApplyResources(this.rightToLeftCheckBox, "rightToLeftCheckBox");
            this.rightToLeftCheckBox.Name = "rightToLeftCheckBox";
            this.rightToLeftCheckBox.UseVisualStyleBackColor = true;
            // 
            // ignorePatternWhitespaceCheckBox
            // 
            resources.ApplyResources(this.ignorePatternWhitespaceCheckBox, "ignorePatternWhitespaceCheckBox");
            this.ignorePatternWhitespaceCheckBox.Name = "ignorePatternWhitespaceCheckBox";
            this.ignorePatternWhitespaceCheckBox.UseVisualStyleBackColor = true;
            // 
            // singleLineCheckBox
            // 
            resources.ApplyResources(this.singleLineCheckBox, "singleLineCheckBox");
            this.singleLineCheckBox.Name = "singleLineCheckBox";
            this.singleLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // explicitCaptureCheckBox
            // 
            resources.ApplyResources(this.explicitCaptureCheckBox, "explicitCaptureCheckBox");
            this.explicitCaptureCheckBox.Name = "explicitCaptureCheckBox";
            this.explicitCaptureCheckBox.UseVisualStyleBackColor = true;
            // 
            // multiLineCheckBox
            // 
            resources.ApplyResources(this.multiLineCheckBox, "multiLineCheckBox");
            this.multiLineCheckBox.Name = "multiLineCheckBox";
            this.multiLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // ignoreCaseCheckBox
            // 
            resources.ApplyResources(this.ignoreCaseCheckBox, "ignoreCaseCheckBox");
            this.ignoreCaseCheckBox.Name = "ignoreCaseCheckBox";
            this.ignoreCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionTableLayoutPanel
            // 
            resources.ApplyResources(this.optionTableLayoutPanel, "optionTableLayoutPanel");
            this.optionTableLayoutPanel.Controls.Add(this.compiledCheckBox, 0, 0);
            this.optionTableLayoutPanel.Controls.Add(this.ignoreCaseCheckBox, 0, 1);
            this.optionTableLayoutPanel.Controls.Add(this.multiLineCheckBox, 0, 2);
            this.optionTableLayoutPanel.Controls.Add(this.explicitCaptureCheckBox, 0, 3);
            this.optionTableLayoutPanel.Controls.Add(this.singleLineCheckBox, 0, 4);
            this.optionTableLayoutPanel.Controls.Add(this.ignorePatternWhitespaceCheckBox, 0, 5);
            this.optionTableLayoutPanel.Controls.Add(this.rightToLeftCheckBox, 0, 6);
            this.optionTableLayoutPanel.Controls.Add(this.ecmaScriptCheckBox, 0, 7);
            this.optionTableLayoutPanel.Controls.Add(this.cultureInvariantCheckBox, 0, 8);
            this.optionTableLayoutPanel.Name = "optionTableLayoutPanel";
            // 
            // OptionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.optionTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.ShowInTaskbar = false;
            this.optionTableLayoutPanel.ResumeLayout(false);
            this.optionTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox compiledCheckBox;
        private System.Windows.Forms.CheckBox cultureInvariantCheckBox;
        private System.Windows.Forms.CheckBox ecmaScriptCheckBox;
        private System.Windows.Forms.CheckBox rightToLeftCheckBox;
        private System.Windows.Forms.CheckBox ignorePatternWhitespaceCheckBox;
        private System.Windows.Forms.CheckBox singleLineCheckBox;
        private System.Windows.Forms.CheckBox explicitCaptureCheckBox;
        private System.Windows.Forms.CheckBox multiLineCheckBox;
        private System.Windows.Forms.CheckBox ignoreCaseCheckBox;
        private System.Windows.Forms.TableLayoutPanel optionTableLayoutPanel;
    }
}