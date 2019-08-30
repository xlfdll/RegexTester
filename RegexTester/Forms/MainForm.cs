using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegexTester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void patternEditButton_Click(object sender, EventArgs e)
        {
            ComboBox comboBox = null;

            if (sender == regexEditButton)
            {
                comboBox = regexComboBox;
            }
            else if (sender == replacementEditButton)
            {
                comboBox = replacementComboBox;
            }

            if (comboBox != null)
            {
                using (ExpressionEditForm expressionEditForm = new ExpressionEditForm(comboBox.Text, comboBox.Parent.Text.Replace("&", String.Empty)))
                {
                    if (expressionEditForm.ShowDialog(this) == DialogResult.OK)
                    {
                        comboBox.Text = expressionEditForm.Expression;
                    }
                }
            }
        }
    }
}
