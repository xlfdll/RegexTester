namespace RegexTester
{
    partial class RegexOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegexOptionsForm));
            this.regexOptionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // regexOptionsCheckedListBox
            // 
            resources.ApplyResources(this.regexOptionsCheckedListBox, "regexOptionsCheckedListBox");
            this.regexOptionsCheckedListBox.FormattingEnabled = true;
            this.regexOptionsCheckedListBox.Items.AddRange(new object[] {
            resources.GetString("regexOptionsCheckedListBox.Items"),
            resources.GetString("regexOptionsCheckedListBox.Items1"),
            resources.GetString("regexOptionsCheckedListBox.Items2"),
            resources.GetString("regexOptionsCheckedListBox.Items3"),
            resources.GetString("regexOptionsCheckedListBox.Items4"),
            resources.GetString("regexOptionsCheckedListBox.Items5"),
            resources.GetString("regexOptionsCheckedListBox.Items6"),
            resources.GetString("regexOptionsCheckedListBox.Items7"),
            resources.GetString("regexOptionsCheckedListBox.Items8")});
            this.regexOptionsCheckedListBox.Name = "regexOptionsCheckedListBox";
            // 
            // RegexOptionsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.regexOptionsCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegexOptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox regexOptionsCheckedListBox;
    }
}