using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;

using RegexTester.Properties;

namespace RegexTester.Forms
{
    public partial class TextForm : Form
    {
        #region Constructors

        public TextForm()
        {
            InitializeComponent();
        }

        public TextForm(Boolean showTitleBar)
            : this()
        {
            if (!showTitleBar)
            {
                this.Text = String.Empty;
            }
        }

        public TextForm(String title, String[] contents)
            : this()
        {
            LoadText(title, contents, true);
        }

        public TextForm(String title, String[] contents, Boolean isReadOnly)
            : this(title, contents)
        {
            contentRichTextBox.ReadOnly = isReadOnly;
        }

        #endregion

        #region Public Properties

        public String UnformattedContents
        {
            get { return contentRichTextBox.Text; }
            set { contentRichTextBox.Text = value; }
        }

        public String Contents
        {
            get { return String.Join(Environment.NewLine, contentRichTextBox.Lines); }
        }

        public String[] Lines
        {
            get { return contentRichTextBox.Lines; }
            set { contentRichTextBox.Lines = value; }
        }

        #endregion

        #region Private Event Methods

        private void TextForm_Load(object sender, EventArgs e)
        {
            contentRichTextBox.AllowDrop = true;

            contentRichTextBox.DragEnter += new DragEventHandler(contentRichTextBox_DragEnter);
            contentRichTextBox.DragDrop += new DragEventHandler(contentRichTextBox_DragDrop);
        }

        private void contentRichTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void contentRichTextBox_DragDrop(object sender, DragEventArgs e)
        {
            String[] files = e.Data.GetData(DataFormats.FileDrop) as String[];

            if (files != null && files.Length > 0)
            {
                this.Focus();

                LoadText(Path.GetFileNameWithoutExtension(files[0]), File.ReadAllLines(files[0], Encoding.Default), true);
            }
        }

        private void contentRichTextBox_EnterOrSelectionChanged(object sender, EventArgs e)
        {
            positionToolStripLabel.Text = contentRichTextBox.SelectionStart.ToString();
        }

        private void contentRichTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox richTextBox = sender as RichTextBox;

            if (richTextBox != null && FormHelper.ResultFormInstance.ResultNodes.Count > 0)
            {
                FormHelper.ResultFormInstance.Reset();

                FormHelper.ShowToolTipOnControl(richTextBox, Resources.ResultRemovedToolTipTitle, Resources.ResultRemovedToolTipText);
            }
        }

        private void contentRichTextBoxContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip contextMenuStrip = sender as ContextMenuStrip;

            if (contextMenuStrip != null)
            {
                foreach (ToolStripItem item in contextMenuStrip.Items)
                {
                    if (item is ToolStripMenuItem && !String.IsNullOrEmpty(item.Text) && item.Text.Contains("&"))
                    {
                        checkContentRichTextBoxContextMenuStripActions(item.Text.Replace("&", String.Empty));
                    }
                }
            }
        }

        private void contentRichTextBoxContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem menuItem = e.ClickedItem as ToolStripMenuItem;

            if (menuItem != null)
            {
                performContentRichTextBoxContextMenuStripActions(menuItem.Text.Replace("&", String.Empty));
            }
        }

        private void contentToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripButton button = e.ClickedItem as ToolStripButton;

            if (button != null)
            {
                if (button == openToolStripButton)
                {
                    using (OpenFileDialog dlg = new OpenFileDialog())
                    {
                        dlg.Filter = Resources.TextDocumentFileDialogFilter;
                        dlg.FileName = "*.txt";
                        dlg.Multiselect = false;
                        dlg.RestoreDirectory = true;

                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            LoadText(Path.GetFileNameWithoutExtension(dlg.FileName), File.ReadAllLines(dlg.FileName, Encoding.Default), true);
                        }
                    }
                }
                else if (button == styleToolStripButton)
                {
                    contentRichTextBox.TextChanged -= contentRichTextBox_TextChanged;

                    styleFontDialog.Font = contentRichTextBox.Font;

                    if (styleFontDialog.ShowDialog() == DialogResult.OK)
                    {
                        styleFontDialog_Apply(sender, e);
                    }
                }
            }
        }

        private void styleFontDialog_Apply(object sender, EventArgs e)
        {
            contentRichTextBox.Font = styleFontDialog.Font;

            contentRichTextBox.TextChanged += contentRichTextBox_TextChanged;
        }

        private void wordWrapToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            contentRichTextBox.WordWrap = wordWrapToolStripButton.Checked;
        }

        #endregion

        #region Private Helper Methods

        private void checkContentRichTextBoxContextMenuStripActions(String action)
        {
            Boolean isTextSelected = !String.IsNullOrEmpty(contentRichTextBox.SelectedText);
            Boolean isClipboardEmpty = Clipboard.ContainsText();

            switch (action)
            {
                case "Undo":
                    {
                        undoToolStripMenuItem.Enabled = contentRichTextBox.CanUndo || _undoList.Count != 0;

                        break;
                    }
                case "Redo":
                    {
                        redoToolStripMenuItem.Enabled = contentRichTextBox.CanRedo || _redoList.Count != 0;

                        break;
                    }
                case "Cut":
                    {
                        cutToolStripMenuItem.Enabled = isTextSelected;

                        break;
                    }
                case "Copy":
                    {
                        copyToolStripMenuItem.Enabled = isTextSelected;

                        break;
                    }
                case "Paste":
                    {
                        pasteToolStripMenuItem.Enabled = isClipboardEmpty;

                        break;
                    }
                case "Delete":
                    {
                        deleteToolStripMenuItem.Enabled = isTextSelected;

                        break;
                    }
                case "Clear":
                    {
                        clearToolStripMenuItem.Enabled = !String.IsNullOrEmpty(contentRichTextBox.Text);

                        break;
                    }
                case "Select All":
                    {
                        selectAllToolStripMenuItem.Enabled = (contentRichTextBox.SelectedText != contentRichTextBox.Text);

                        break;
                    }
                case "Deselect All":
                    {
                        deselectAllToolStripMenuItem.Enabled = !String.IsNullOrEmpty(contentRichTextBox.SelectedText);

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void performContentRichTextBoxContextMenuStripActions(String action)
        {
            switch (action)
            {
                case "Undo":
                    {
                        if (contentRichTextBox.CanUndo)
                        {
                            contentRichTextBox.Undo();
                        }
                        else if (_undoList.Count != 0)
                        {
                            _redoList.Push(this.Lines);

                            contentRichTextBox.Lines = _undoList.Pop();
                        }

                        break;
                    }
                case "Redo":
                    {
                        if (contentRichTextBox.CanRedo)
                        {
                            contentRichTextBox.Redo();
                        }
                        else if (_redoList.Count != 0)
                        {
                            _undoList.Push(this.Lines);

                            contentRichTextBox.Lines = _redoList.Pop();
                        }

                        break;
                    }
                case "Cut":
                    {
                        contentRichTextBox.Cut();

                        break;
                    }
                case "Copy":
                    {
                        contentRichTextBox.Copy();

                        break;
                    }
                case "Paste":
                    {
                        contentRichTextBox.Paste(DataFormats.GetFormat(DataFormats.Text));

                        break;
                    }
                case "Delete":
                    {
                        //BUG: Minor appearance problem.

                        Int32 start = contentRichTextBox.SelectionStart;

                        contentRichTextBox.Text = contentRichTextBox.Text.Remove(contentRichTextBox.SelectionStart, contentRichTextBox.SelectionLength);

                        Select(start, 0);

                        break;
                    }
                case "Clear":
                    {
                        contentRichTextBox.Clear();

                        break;
                    }
                case "Select All":
                    {
                        contentRichTextBox.SelectAll();

                        break;
                    }
                case "Deselect All":
                    {
                        contentRichTextBox.DeselectAll();

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        #endregion

        #region Internal Helper Methods

        internal void SetTitle(String title)
        {
            if (title != null)
            {
                this.Text = String.Format(Resources.TextFormTitleFormat, !String.IsNullOrEmpty(title) ? title : Resources.DefaultUntitledString);
            }
        }

        #endregion

        #region Public Methods

        public void LoadText(String title, String[] contents, Boolean clearUndo)
        {
            SetTitle(title);

            if (clearUndo)
            {
                _undoList.Clear();
            }
            else
            {
                _undoList.Push(contentRichTextBox.Lines);
            }

            _redoList.Clear();

            contentRichTextBox.Lines = contents;
        }

        public void Select(Int32 start, Int32 length)
        {
            contentRichTextBox.Select(start, length);
            contentRichTextBox.ScrollToCaret();

            positionToolStripLabel.Text = contentRichTextBox.SelectionStart.ToString();
        }

        public void Reset()
        {
            LoadText(String.Empty, null, true);

            wordWrapToolStripButton.Checked = true;

            Select(0, 0);
        }

        #endregion

        #region Extra Undo / Redo List

        private Stack<String[]> _undoList = new Stack<String[]>();
        private Stack<String[]> _redoList = new Stack<String[]>();

        internal Stack<String[]> UndoList
        {
            get { return _undoList; }
        }

        internal Stack<String[]> RedoList
        {
            get { return _redoList; }
        }

        #endregion
    }
}