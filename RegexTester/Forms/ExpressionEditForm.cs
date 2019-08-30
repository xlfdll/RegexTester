using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegexTester
{
    public partial class ExpressionEditForm : Form
    {
        public ExpressionEditForm()
        {
            InitializeComponent();
        }

        public ExpressionEditForm(String expression, String subTitle)
            : this()
        {
            this.Text = String.Format(this.Text, subTitle);

            expressionTextBox.Text = expression;
        }

        public String Expression
        {
            get { return expressionTextBox.Text; }
            set { expressionTextBox.Text = value; }
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.AllowVerticalFonts = false;
                fontDialog.ShowEffects = false;
                fontDialog.FontMustExist = true;
                fontDialog.ShowApply = true;
                fontDialog.Apply += delegate { expressionTextBox.Font = fontDialog.Font; };
                fontDialog.Font = expressionTextBox.Font;

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    expressionTextBox.Font = fontDialog.Font;
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
