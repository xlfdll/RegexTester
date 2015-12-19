using System;
using System.Windows.Forms;

using RegexTester.Forms;
using RegexTester.Properties;

namespace RegexTester
{
    internal static class FormHelper
    {
        #region Static Constructor

        static FormHelper()
        {
            // Fix a problem that raising an InvalidOperationException when starting Release version.
            // Delay all the form constructor calls until SetCompatibleTextRenderingDefault method has been called. 

            _mainForm = new MainForm();
            _textForm = new TextForm();
            _optionForm = new OptionForm();
            _resultForm = new ResultForm();
            _patternForm = new PatternForm();
            _progressForm = new ProgressForm();

            formToolTip = new ToolTip();
        }

        #endregion

        #region Private Form Fields

        private static MainForm _mainForm;
        private static TextForm _textForm;
        private static OptionForm _optionForm;
        private static ResultForm _resultForm;
        private static PatternForm _patternForm;
        private static ProgressForm _progressForm;

        #endregion

        #region Internal Form Properties

        internal static MainForm MainFormInstance
        {
            get { return _mainForm; }
        }

        internal static TextForm TextFormInstance
        {
            get { return _textForm; }
        }

        internal static OptionForm OptionFormInstance
        {
            get { return _optionForm; }
        }

        internal static ResultForm ResultFormInstance
        {
            get { return _resultForm; }
        }

        internal static PatternForm PatternFormInstance
        {
            get { return _patternForm; }
        }

        internal static ProgressForm ProgressFormInstance
        {
            get { return _progressForm; }
        }

        #endregion

        #region Internal Form Methods

        internal static void SetAllWindowsEnabledState(Boolean isEnabled)
        {
            _mainForm.Enabled = isEnabled;
            _textForm.Enabled = isEnabled;
            _optionForm.Enabled = isEnabled;
            _resultForm.Enabled = isEnabled;
        }

        internal static void SetChildWindowsShownState(Boolean canShow)
        {
            if (canShow)
            {
                _textForm.Show(_mainForm);
                _optionForm.Show(_mainForm);
                _resultForm.Show(_mainForm);
            }
            else
            {
                _textForm.Hide();
                _optionForm.Hide();
                _resultForm.Hide();
            }
        }

        #endregion

        #region Internal MessageBox Methods

        internal static void ShowExceptionMessageBox(Exception ex)
        {
            String exceptionMessage = String.Format(Resources.ExceptionMessageBoxStructureFormat, Environment.NewLine, Resources.ExceptionMessageBoxExceptionOccuredText, String.Format(Resources.ExceptionMessageBoxTextFormat, Environment.NewLine, ex.GetType().ToString(), ex.Message, Resources.DefaultSeparator));
            String innerExceptionMessage = ex.InnerException == null ? String.Empty : String.Format("{0}{0}{1}", Environment.NewLine, String.Format(Resources.ExceptionMessageBoxStructureFormat, Environment.NewLine, Resources.ExceptionMessageBoxInnerExceptionOccuredText, String.Format(Resources.ExceptionMessageBoxTextFormat, Environment.NewLine, ex.InnerException.GetType().ToString(), ex.InnerException.Message, Resources.DefaultSeparator)));

            MessageBox.Show(String.Format("{0}{1}", exceptionMessage, innerExceptionMessage), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Internal Clipboard Methods

        internal static String GetClipboardText()
        {
            return Clipboard.ContainsText() ? Clipboard.GetText() : null;
        }

        internal static void SetClipboardText(String text)
        {
            try
            {
                if (!String.IsNullOrEmpty(text))
                {
                    Clipboard.SetText(text);
                }
            }
            catch { return; }
        }

        #endregion

        #region Internal Tooltip Methods w/ Fields

        internal static void ShowToolTipOnControl(Control control, String title, String text)
        {
            ShowToolTipOnControl(control, title, text, ToolTipIcon.Info, 5000);
        }

        internal static void ShowToolTipOnControl(Control control, String title, String text, ToolTipIcon icon, Int32 duration)
        {
            formToolTip.ToolTipIcon = icon;
            formToolTip.ToolTipTitle = title;
            formToolTip.Show(text, control, 0, control.Height, duration);
        }

        private static ToolTip formToolTip;

        #endregion
    }
}