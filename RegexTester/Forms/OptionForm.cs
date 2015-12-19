using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexTester.Forms
{
    public partial class OptionForm : Form
    {
        #region Constructors

        public OptionForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Properties

        public RegexOptions CurrentRegexOptions
        {
            get
            {
                RegexOptions regexOptions = RegexOptions.None;

                foreach (Control control in optionTableLayoutPanel.Controls)
                {
                    CheckBox checkBox = control as CheckBox;

                    if (checkBox != null && checkBox.Checked)
                    {
                        regexOptions |= (RegexOptions)Enum.Parse(typeof(RegexOptions), checkBox.Text.Replace("&", String.Empty));
                    }
                }

                return regexOptions;
            }
            set
            {
                this.Reset();

                String[] optionStringArray = value.ToString().Split(',');

                foreach (Control control in optionTableLayoutPanel.Controls)
                {
                    CheckBox checkBox = control as CheckBox;

                    if (checkBox != null && !checkBox.Checked)
                    {
                        foreach (String option in optionStringArray)
                        {
                            if (checkBox.Text.Replace("&", String.Empty).Contains(option.Trim()))
                            {
                                checkBox.Checked = true;

                                break;
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region Public Methods

        public void Reset()
        {
            foreach (Control control in optionTableLayoutPanel.Controls)
            {
                CheckBox checkBox = control as CheckBox;

                if (checkBox != null)
                {
                    checkBox.Checked = false;
                }
            }
        }

        #endregion
    }
}