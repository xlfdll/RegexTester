using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RegexTester.Forms
{
    public partial class ProgressForm : Form
    {
        #region Constructors

        public ProgressForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Properties

        public Boolean IsBusy
        {
            get { return _isBusy; }
        }

        public BackgroundWorker MainBackgroundWorker
        {
            get { return mainBackgroundWorker; }
        }

        #endregion

        #region Private Fields

        private Boolean _isBusy;

        private Object _argument;

        #endregion

        #region Private Event Methods

        private void ProgressForm_Shown(object sender, EventArgs e)
        {
            _isBusy = true;

            FormHelper.SetAllWindowsEnabledState(false);

            mainBackgroundWorker.RunWorkerAsync(_argument);
        }

        private void ProgressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            progressLabel.Text = String.Empty;

            _argument = null;

            FormHelper.SetAllWindowsEnabledState(true);

            _isBusy = false;
        }

        #endregion

        #region Public Methods

        public void ShowAndWork(Object argument)
        {
            _argument = argument;

            this.ShowDialog();
        }

        public void ShowAndWork(Object argument, String progressText)
        {
            SetProgressText(progressText);

            ShowAndWork(argument);
        }

        public void SetProgressText(String progressText)
        {
            progressLabel.Text = String.Format("{0}{0}{0}{1}", Environment.NewLine, progressText);
        }

        public void Close(Exception exception)
        {
            FormHelper.ShowExceptionMessageBox(exception);

            this.Close();
        }

        #endregion
    }
}