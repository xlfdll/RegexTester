using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexTester
{
    public partial class RegexOptionsForm : Form
    {
        public RegexOptionsForm()
        {
            InitializeComponent();
        }

        public RegexOptions CurrentRegexOptions
        {
            get
            {
                RegexOptions regexOptions = RegexOptions.None;

                foreach (object item in regexOptionsCheckedListBox.CheckedItems)
                {
                    regexOptions |= (RegexOptions)Enum.Parse(typeof(RegexOptions), item.ToString());
                }

                return regexOptions;
            }
            set
            {
                this.Reset();

                foreach (String item in value.ToString().Split(','))
                {
                    if (regexOptionsCheckedListBox.Items.Contains(item))
                    {
                        regexOptionsCheckedListBox.SetItemChecked(regexOptionsCheckedListBox.Items.IndexOf(item), true);
                    }
                }
            }
        }

        public void Reset()
        {
            for (int i = 0; i < regexOptionsCheckedListBox.Items.Count; i++)
            {
                regexOptionsCheckedListBox.SetItemChecked(i, false);
            }
        }
    }
}
