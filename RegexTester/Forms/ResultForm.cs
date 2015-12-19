using System;
using System.ComponentModel;
using System.Windows.Forms;

using RegexTester.Properties;

namespace RegexTester.Forms
{
    public partial class ResultForm : Form
    {
        #region Constructors

        public ResultForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Properties

        public TreeNodeCollection ResultNodes
        {
            get { return resultTreeView.Nodes; }
        }

        public ContextMenuStrip ResultNodeContextMenuStrip
        {
            get { return resultNodeContextMenuStrip; }
        }

        #endregion

        #region Private Event Methods

        private void ResultForm_TextChanged(object sender, EventArgs e)
        {
            resultReportExportToolStripButton.Enabled = (DataHelper.Status != null);
        }

        private void resultTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            resultValueCopyToolStripButton.Enabled = (resultTreeView.SelectedNode != null);

            FormHelper.TextFormInstance.Select(GetNodeValueIndex(e.Node), GetNodeValue(e.Node).Length);
        }

        private void resultTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            resultTreeView_AfterSelect(sender, new TreeViewEventArgs(e.Node));

            if (e.Node.Parent == null)
            {
                resultTreeView.CollapseAll();

                resultTreeView.SelectedNode = e.Node;
            }

            e.Node.Expand();
        }

        private void resultTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FormHelper.SetClipboardText(GetNodeValue(resultTreeView.SelectedNode));
        }

        private void resultToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripButton button = e.ClickedItem as ToolStripButton;

            if (button != null)
            {
                if (button == resultValueCopyToolStripButton)
                {
                    FormHelper.SetClipboardText(GetNodeValue(resultTreeView.SelectedNode));
                }
                else if (button == resultReportImportToolStripButton)
                {
                    using (OpenFileDialog dlg = new OpenFileDialog())
                    {
                        dlg.Title = Resources.ReportImportFileDialogTitle;
                        dlg.Filter = String.Format("{0}|{1}", Resources.ReportOpenFileDialogFirstFilter, Resources.ReportFileDialogFilter);
                        dlg.RestoreDirectory = true;
                        dlg.Multiselect = false;

                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            DataHelper.ImportReport(dlg.FileName);
                        }
                    }
                }
                else if (button == resultReportExportToolStripButton)
                {
                    using (SaveFileDialog dlg = new SaveFileDialog())
                    {
                        dlg.Title = Resources.ReportExportFileDialogTitle;
                        dlg.Filter = Resources.ReportFileDialogFilter;
                        dlg.FileName = String.Format(Resources.ReportFileNameFormat, DataHelper.Status.DateTimeStamp.ToString("yyyy_MM_dd_HH_mm_ss"));
                        dlg.RestoreDirectory = true;

                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            DataHelper.ExportReport(dlg.FileName);
                        }
                    }
                }
            }
        }

        private void resultTreeViewContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            resultTreeView.SelectedNode = resultTreeView.GetNodeAt(resultTreeView.PointToClient(Control.MousePosition));

            copyToolStripMenuItem.Enabled = (resultTreeView.SelectedNode != null);
        }

        private void resultTreeViewContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            resultNodeContextMenuStrip.Close(ToolStripDropDownCloseReason.ItemClicked);

            ToolStripMenuItem menuItem = e.ClickedItem as ToolStripMenuItem;

            if (menuItem != null)
            {
                if (menuItem == copyToolStripMenuItem)
                {
                    resultValueCopyToolStripButton.PerformClick();
                }
            }
        }

        #endregion

        #region Internal Helper Methods

        internal static String GetNodeValue(TreeNode node)
        {
            return FieldHelper.ResultNodeRegex.Match(node.Text).Groups["Value"].Value;
        }

        internal static Int32 GetNodeValueIndex(TreeNode node)
        {
            // When input contains newline characters, remove them, or Index cannot be matched.

            return Convert.ToInt32(FieldHelper.ResultNodeRegex.Match(node.Text.Replace("\n", String.Empty)).Groups["Index"].Value);
        }

        #endregion

        #region Public Methods

        public void AddNodes(TreeNode[] treeNodes)
        {
            if (treeNodes != null)
            {
                resultTreeView.Nodes.AddRange(treeNodes);
            }
        }

        public void ClearNodes()
        {
            if (resultTreeView.Nodes.Count > 0)
            {
                resultTreeView.Nodes.Clear();
            }
        }

        public void Reset()
        {
            DataHelper.Status = null;

            this.Text = Resources.ResultFormDefaultTitle;

            resultReportExportToolStripButton.Enabled = false;

            resultValueCopyToolStripButton.Enabled = false;

            if (!FormHelper.ProgressFormInstance.IsBusy)
            {
                FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted += WorkHelper.NodeClearBackgroundWorker_RunWorkerCompleted;

                FormHelper.ProgressFormInstance.ShowAndWork(null, Resources.DoClearNodeBackgroundWorkProgressText);
            }
            else
            {
                ClearNodes();
            }
        }

        #endregion
    }
}