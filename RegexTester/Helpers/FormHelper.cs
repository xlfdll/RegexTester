using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RegexTester
{
    internal static class FormHelper
    {
        internal static MainForm MainForm
        {
            get { return _mainForm; }
        }

        internal static RegexOptionsForm RegexOptionsForm
        {
            get { return _regexOptionsForm; }
        }

        private static MainForm _mainForm = new MainForm();
        private static RegexOptionsForm _regexOptionsForm = new RegexOptionsForm();
    }
}
