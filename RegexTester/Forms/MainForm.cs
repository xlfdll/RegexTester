using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using RegexTester.Properties;

namespace RegexTester.Forms
{
    public partial class MainForm : Form
    {
        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Properties

        public String RegexPattern
        {
            get { return regexPatternComboBox.Text; }
            set { regexPatternComboBox.Text = value; }
        }

        public String ReplacePattern
        {
            get { return replacePatternComboBox.Text; }
            set { replacePatternComboBox.Text = value; }
        }

        #endregion

        #region Private Event Methods

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.20), Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.005));

            FormHelper.TextFormInstance.Location = new Point(this.Location.X, this.Location.Y + this.Height + 15);
            FormHelper.OptionFormInstance.Location = new Point(FormHelper.TextFormInstance.Location.X + FormHelper.TextFormInstance.Width + 15, FormHelper.TextFormInstance.Location.Y + 5);
            FormHelper.ResultFormInstance.Location = new Point(this.Location.X, FormHelper.OptionFormInstance.Location.Y + FormHelper.OptionFormInstance.Height + 15);

            FormHelper.SetChildWindowsShownState(true);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            clearButton.PerformClick();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            FormHelper.SetChildWindowsShownState(!(this.WindowState == FormWindowState.Minimized));
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            String[] files = e.Data.GetData(DataFormats.FileDrop) as String[];

            if (files != null && files.Length > 0 &&
                (Path.GetExtension(files[0]).Contains(".log")
                || Path.GetExtension(files[0]).Contains(".txt")))
            {
                DataHelper.ImportReport(files[0]);
            }
        }

        private void patternComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                if (sender == regexPatternComboBox)
                {
                    matchButton.PerformClick();
                }
                else if (sender == replacePatternComboBox)
                {
                    replaceButton.PerformClick();
                }
            }
        }

        private void patternComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                e.Handled = true;

                if (sender == regexPatternComboBox)
                {
                    regexPatternEditButton.PerformClick();
                }
                else if (sender == replacePatternComboBox)
                {
                    replacePatternEditButton.PerformClick();
                }
            }
        }

        private void patternEditButton_Click(object sender, EventArgs e)
        {
            if (sender == regexPatternEditButton)
            {
                FormHelper.PatternFormInstance.Tag = Resources.RegexPatternEditTag;
            }
            else if (sender == replacePatternEditButton)
            {
                FormHelper.PatternFormInstance.Tag = Resources.ReplacePatternEditTag;
            }

            if (FormHelper.PatternFormInstance.Tag != null)
            {
                FormHelper.PatternFormInstance.ShowAndEdit();
            }
        }

        private void matchButton_Click(object sender, EventArgs e)
        {
            regexPatternComboBox.Focus();

            try
            {
                if (!String.IsNullOrEmpty(regexPatternComboBox.Text))
                {
                    FormHelper.ResultFormInstance.Reset();

                    FormHelper.TextFormInstance.Select(0, 0);

                    if (!regexPatternComboBox.Items.Contains(regexPatternComboBox.Text))
                    {
                        regexPatternComboBox.Items.Add(regexPatternComboBox.Text);
                    }

                    FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork += WorkHelper.MatchBackgroundWorker_DoWork;
                    FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted += WorkHelper.MatchBackgroundWorker_RunWorkerCompleted;

                    FormHelper.ProgressFormInstance.ShowAndWork(new RegexInput(FormHelper.TextFormInstance.UnformattedContents, regexPatternComboBox.Text, replacePatternComboBox.Text, FormHelper.OptionFormInstance.CurrentRegexOptions), String.Format(Resources.DoBackgroundWorkProgressTextFormat, "Regex.Match"));

                    FormHelper.ResultFormInstance.Focus();
                }
                else
                {
                    throw new ArgumentException(String.Format(Resources.RegexPatternEmptyExceptionMessageFormat, Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                FormHelper.ShowExceptionMessageBox(ex);
            }
        }

        private void textProcessButton_Click(object sender, EventArgs e)
        {
            Button textProcessButton = sender as Button;

            if (textProcessButton != null)
            {
                regexPatternComboBox.Focus();

                try
                {
                    if (!String.IsNullOrEmpty(regexPatternComboBox.Text))
                    {
                        FormHelper.TextFormInstance.Select(0, 0);

                        if (!regexPatternComboBox.Items.Contains(regexPatternComboBox.Text))
                        {
                            regexPatternComboBox.Items.Add(regexPatternComboBox.Text);
                        }
                        if (sender == replaceButton && !replacePatternComboBox.Items.Contains(replacePatternComboBox.Text))
                        {
                            replacePatternComboBox.Items.Add(replacePatternComboBox.Text);
                        }

                        if (sender == spiltButton)
                        {
                            FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork += WorkHelper.SpiltBackgroundWorker_DoWork;
                            FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted += WorkHelper.SpiltBackgroundWorker_RunWorkerCompleted;
                        }
                        else if (sender == replaceButton)
                        {
                            FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork += WorkHelper.ReplaceBackgroundWorker_DoWork;
                            FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted += WorkHelper.ReplaceBackgroundWorker_RunWorkerCompleted;
                        }

                        FormHelper.ProgressFormInstance.ShowAndWork(new RegexInput(FormHelper.TextFormInstance.UnformattedContents, regexPatternComboBox.Text, replacePatternComboBox.Text, FormHelper.OptionFormInstance.CurrentRegexOptions), String.Format(Resources.DoBackgroundWorkProgressTextFormat, String.Format("Regex.{0}", textProcessButton.Text)));

                        FormHelper.TextFormInstance.Focus();
                    }
                    else
                    {
                        throw new ArgumentException(String.Format(Resources.RegexPatternEmptyExceptionMessageFormat, Environment.NewLine));
                    }
                }
                catch (Exception ex)
                {
                    FormHelper.ShowExceptionMessageBox(ex);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            regexPatternComboBox.ResetText();
            replacePatternComboBox.ResetText();

            regexPatternComboBox.Items.Clear();
            replacePatternComboBox.Items.Clear();

            tickButton.Text = String.Format(Resources.TickButtonTextFormat, "0");

            FormHelper.TextFormInstance.Reset();
            FormHelper.OptionFormInstance.Reset();
            FormHelper.ResultFormInstance.Reset();

            regexPatternComboBox.Focus();
        }

        private void tickButton_Click(object sender, EventArgs e)
        {
            regexPatternComboBox.Focus();

            try
            {
                if (!String.IsNullOrEmpty(regexPatternComboBox.Text))
                {
                    FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork += WorkHelper.TickBackgroundWorker_DoWork;
                    FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted += WorkHelper.TickBackgroundWorker_RunWorkerCompleted;

                    FormHelper.ProgressFormInstance.ShowAndWork(new RegexInput(FormHelper.TextFormInstance.UnformattedContents, regexPatternComboBox.Text, replacePatternComboBox.Text, FormHelper.OptionFormInstance.CurrentRegexOptions), String.Format(Resources.DoBackgroundWorkProgressTextFormat, Resources.RunningTimeMeasurementOperationText));

                    FormHelper.MainFormInstance.Focus();
                }
                else
                {
                    throw new ArgumentException(String.Format(Resources.RegexPatternEmptyExceptionMessageFormat, Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                FormHelper.ShowExceptionMessageBox(ex);
            }
        }

        private void regexMSDNLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"http://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex.aspx");

            regexMSDNLinkLabel.LinkVisited = true;
        }

        #endregion

        #region Internal Helper Methods

        internal void SetTickButtonText()
        {
            tickButton.Text = String.Format(Resources.TickButtonTextFormat, DataHelper.Status.TickInNanoSeconds.ToString("F"));
        }

        #endregion

        #region Public Methods

        public void SetRegexInput(String inputTitle, String regexPattern, String replacePattern, String contents, RegexOptions regexOptions)
        {
            regexPatternComboBox.Text = regexPattern;
            replacePatternComboBox.Text = replacePattern;

            if (contents != null)
            {
                FormHelper.TextFormInstance.LoadText(inputTitle, contents.Replace("\r", String.Empty).Split('\n'), true);
            }

            FormHelper.OptionFormInstance.CurrentRegexOptions = regexOptions;
        }

        public void DoMatch()
        {
            matchButton.PerformClick();
        }

        public void DoMatch(String regexPattern, String contents, RegexOptions regexOptions)
        {
            SetRegexInput(String.Empty, regexPattern, String.Empty, contents, regexOptions);

            DoMatch();
        }

        public void DoSpilt()
        {
            spiltButton.PerformClick();
        }

        public void DoSpilt(String regexPattern, String contents, RegexOptions regexOptions)
        {
            SetRegexInput(String.Empty, regexPattern, String.Empty, contents, regexOptions);

            DoSpilt();
        }

        public void DoReplace()
        {
            replaceButton.PerformClick();
        }

        public void DoReplace(String regexPattern, String replacePattern, String contents, RegexOptions regexOptions)
        {
            SetRegexInput(String.Empty, regexPattern, replacePattern, contents, regexOptions);

            DoReplace();
        }

        public void Reset()
        {
            clearButton.PerformClick();
        }

        #endregion
    }
}