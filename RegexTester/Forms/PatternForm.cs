using System;
using System.Windows.Forms;

using RegexTester.Properties;

namespace RegexTester.Forms
{
    public partial class PatternForm : Form
    {
        #region Constructors

        public PatternForm()
        {
            InitializeComponent();
        }

        public PatternForm(String pattern)
            : this()
        {
            patternTextBox.Text = pattern;
            patternTextBox.SelectAll();
        }

        #endregion

        #region Private Event Methods

        private void patternTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == 13 || e.KeyChar == 1);

            if (e.KeyChar == 13)
            {
                okButton.PerformClick();
            }
            else if (e.KeyChar == 1)
            {
                patternTextBox.SelectAll();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            String tag = this.Tag.ToString();

            if (tag == Resources.RegexPatternEditTag)
            {
                FormHelper.MainFormInstance.RegexPattern = patternTextBox.Text;
            }
            else if (tag == Resources.ReplacePatternEditTag)
            {
                FormHelper.MainFormInstance.ReplacePattern = patternTextBox.Text;
            }

            cancelButton_Click(sender, e);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            patternTextBox.Focus();
            patternTextBox.SelectAll();

            this.Close();

            this.Tag = null;
            this.Text = String.Format(Resources.PatternEditDialogTitleFormat, String.Empty);
        }

        #endregion

        #region Public Methods

        public void ShowAndEdit()
        {
            String tag = this.Tag.ToString();

            this.Text = String.Format(Resources.PatternEditDialogTitleFormat, tag);

            if (tag == Resources.RegexPatternEditTag)
            {
                ShowAndEdit(FormHelper.MainFormInstance.RegexPattern);
            }
            else if (tag == Resources.ReplacePatternEditTag)
            {
                ShowAndEdit(FormHelper.MainFormInstance.ReplacePattern);
            }
        }

        public void ShowAndEdit(String pattern)
        {
            patternTextBox.Text = pattern;
            patternTextBox.SelectAll();

            this.ShowDialog();
        }

        #endregion
    }
}