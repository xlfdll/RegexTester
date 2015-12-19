using System;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using RegexTester.Forms;
using RegexTester.Properties;

namespace RegexTester
{
    internal static class WorkHelper
    {
        #region Match

        internal static void MatchBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RegexInput input = e.Argument as RegexInput;

            if (input != null)
            {
                try
                {
                    e.Result = new Object[2] { Regex.Matches(input.Contents, input.RegexPattern, input.Options), input };
                }
                catch (Exception ex)
                {
                    e.Result = ex;
                }
            }
        }

        internal static void MatchBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork -= MatchBackgroundWorker_DoWork;
            FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted -= MatchBackgroundWorker_RunWorkerCompleted;

            if (e.Result is Exception)
            {
                FormHelper.ProgressFormInstance.Close(e.Result as Exception);
            }
            else if (e.Result is Object[])
            {
                Object[] resultArray = e.Result as Object[];

                RegexInput input = resultArray[1] as RegexInput;

                DataHelper.Status = new SearchStatus(new RegexInput(FormHelper.TextFormInstance.Contents, input.RegexPattern, input.ReplacePattern, input.Options), DateTime.Now, RegexMatchTick(input.Contents, input.RegexPattern, input.Options));

                FormHelper.MainFormInstance.SetTickButtonText();

                FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork += ResultBackgroundWorker_DoWork;
                FormHelper.ProgressFormInstance.MainBackgroundWorker.ProgressChanged += ResultBackgroundWorker_ProgressChanged;
                FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted += ResultBackgroundWorker_RunWorkerCompleted;

                FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerAsync(resultArray[0]);
            }
        }

        #region Result Process

        private static void ResultBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            MatchCollection matches = e.Argument as MatchCollection;

            if (matches != null && matches.Count > 0)
            {
                Int32 progress = 0;
                Int32 singlePercentageCount = Convert.ToInt32(matches.Count * 0.01);

                TreeNode[] treeNodes = new TreeNode[matches.Count];

                for (Int32 i = 0; i < matches.Count; i++)
                {
                    treeNodes[i] = new TreeNode((String.Format(Resources.ResultNodeTextFormat, matches[i].Value, matches[i].Index.ToString())));

                    for (Int32 j = 1; j < matches[i].Groups.Count; j++)
                    {
                        if (matches[i].Groups[j].Success)
                        {
                            TreeNode groupNode = treeNodes[i].Nodes.Add(String.Format(Resources.ResultNodeTextFormat, matches[i].Groups[j].Value, matches[i].Groups[j].Index.ToString()));

                            groupNode.ContextMenuStrip = FormHelper.ResultFormInstance.ResultNodeContextMenuStrip;

                            for (Int32 k = 1; k < matches[i].Groups[j].Captures.Count; k++)
                            {
                                TreeNode captureNode = groupNode.Nodes.Add(String.Format(Resources.ResultNodeTextFormat, matches[i].Groups[j].Captures[k].Value, matches[i].Groups[j].Captures[k].Index.ToString()));

                                captureNode.ContextMenuStrip = FormHelper.ResultFormInstance.ResultNodeContextMenuStrip;
                            }

                            groupNode.Text = String.Format("{0}{1}", groupNode.Text, groupNode.Nodes.Count > 0 ? String.Format(" ({0})", groupNode.Nodes.Count.ToString()) : String.Empty);
                        }
                    }

                    treeNodes[i].Text = String.Format("{0}{1}", treeNodes[i].Text, treeNodes[i].Nodes.Count > 0 ? String.Format(" ({0})", treeNodes[i].Nodes.Count.ToString()) : String.Empty);
                    treeNodes[i].ContextMenuStrip = FormHelper.ResultFormInstance.ResultNodeContextMenuStrip;

                    if (singlePercentageCount > 0 && i % singlePercentageCount == 0)
                    {
                        progress++;

                        FormHelper.ProgressFormInstance.MainBackgroundWorker.ReportProgress(progress);
                    }
                }

                e.Result = treeNodes;

                FormHelper.ProgressFormInstance.MainBackgroundWorker.ReportProgress(100);
            }
        }

        private static void ResultBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            FormHelper.ProgressFormInstance.SetProgressText(String.Format(Resources.DoResultBackgroundWorkProgressTextFormat, e.ProgressPercentage.ToString()));
        }

        private static void ResultBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork -= ResultBackgroundWorker_DoWork;
            FormHelper.ProgressFormInstance.MainBackgroundWorker.ProgressChanged -= ResultBackgroundWorker_ProgressChanged;
            FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted -= ResultBackgroundWorker_RunWorkerCompleted;

            TreeNode[] treeNodes = e.Result as TreeNode[];

            if (treeNodes != null)
            {
                FormHelper.ResultFormInstance.AddNodes(treeNodes);
            }

            FormHelper.ResultFormInstance.Text = String.Format(Resources.ResultFormTitleFormat, FormHelper.ResultFormInstance.ResultNodes.Count.ToString(), DataHelper.Status.DateTimeStamp.ToString("yyyy/MM/dd HH:mm:ss"));

            FormHelper.ProgressFormInstance.Close();
        }

        #endregion

        #endregion

        #region Spilt

        internal static void SpiltBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RegexInput input = e.Argument as RegexInput;

            if (input != null)
            {
                try
                {
                    e.Result = Regex.Split(input.Contents, input.RegexPattern, input.Options);
                }
                catch (Exception ex)
                {
                    e.Result = ex;
                }
            }
        }

        internal static void SpiltBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork -= SpiltBackgroundWorker_DoWork;
            FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted -= SpiltBackgroundWorker_RunWorkerCompleted;

            if (e.Result is Exception)
            {
                FormHelper.ProgressFormInstance.Close(e.Result as Exception);
            }
            else if (e.Result is String[])
            {
                FormHelper.TextFormInstance.LoadText(null, e.Result as String[], false);

                FormHelper.ProgressFormInstance.Close();
            }
        }

        #endregion

        #region Replace

        internal static void ReplaceBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RegexInput input = e.Argument as RegexInput;

            if (input != null)
            {
                try
                {
                    e.Result = Regex.Replace(input.Contents, input.RegexPattern, input.ReplacePattern, input.Options);
                }
                catch (Exception ex)
                {
                    e.Result = ex;
                }
            }
        }

        internal static void ReplaceBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork -= ReplaceBackgroundWorker_DoWork;
            FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted -= ReplaceBackgroundWorker_RunWorkerCompleted;

            if (e.Result is Exception)
            {
                FormHelper.ProgressFormInstance.Close(e.Result as Exception);
            }
            else if (e.Result is String)
            {
                FormHelper.TextFormInstance.LoadText(null, e.Result.ToString().Split('\n'), false);

                FormHelper.ProgressFormInstance.Close();
            }
        }

        #endregion

        #region Tick

        internal static void TickBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RegexInput input = e.Argument as RegexInput;

            if (input != null)
            {
                try
                {
                    Double result = 0.0;

                    for (Int32 i = 0; i < FieldHelper.TickCycleCount; i++)
                    {
                        result += RegexMatchTick(input.Contents, input.RegexPattern, input.Options);
                    }

                    result = result / Convert.ToDouble(FieldHelper.TickCycleCount);

                    e.Result = new Object[2] { result.ToString("F"), input };
                }
                catch (Exception ex)
                {
                    e.Result = ex;
                }
            }
        }

        internal static void TickBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork -= TickBackgroundWorker_DoWork;
            FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted -= TickBackgroundWorker_RunWorkerCompleted;

            if (e.Result is Exception)
            {
                FormHelper.ProgressFormInstance.Close(e.Result as Exception);
            }
            else if (e.Result is Object[])
            {
                Object[] resultArray = e.Result as Object[];

                String result = resultArray[0].ToString();
                String resultInSecond = (Convert.ToDouble(result) * FieldHelper.NanoSecondPerTick).ToString("F");

                RegexInput input = resultArray[1] as RegexInput;

                MessageBox.Show
                    (String.Format(Resources.TickInfoMessageBoxTextFormat, input.RegexPattern, Environment.NewLine, result, resultInSecond, Resources.DefaultSeparator,
                    Stopwatch.Frequency.ToString(), FieldHelper.NanoSecondPerTick.ToString("F"), Stopwatch.IsHighResolution ? Resources.StopwatchHighResolutionCounterText : Resources.StopwatchSystemTimerText),
                    String.Format(Resources.TickInfoMessageBoxTitleFormat, result, resultInSecond, MessageBoxButtons.OK, MessageBoxIcon.Information));

                FormHelper.ProgressFormInstance.Close();
            }
        }

        #region Single Tick Method

        internal static Double RegexMatchTick(String input, String pattern, RegexOptions options)
        {
            Double ticks = 0.0;

            stopWatch.Reset();

            try
            {
                stopWatch.Start();

                Regex.IsMatch(input, pattern, options);

                stopWatch.Stop();

                ticks = Convert.ToDouble(stopWatch.ElapsedTicks);
            }
            finally
            {
                stopWatch.Stop();
            }

            return ticks;
        }

        private static Stopwatch stopWatch = new Stopwatch();

        #endregion

        #endregion

        #region Import

        internal static void ImportBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            FormHelper.ProgressFormInstance.MainBackgroundWorker.ReportProgress(0);

            String fileName = e.Argument.ToString();

            String regexPattern = String.Empty;
            String contents = String.Empty;

            RegexOptions regexOptions = RegexOptions.None;

            using (StreamReader reader = new StreamReader(fileName, true))
            {
                String line = reader.ReadLine();

                while (line != null)
                {
                    if (line == Resources.ReportPatternTitle)
                    {
                        reader.ReadLine();

                        regexPattern = reader.ReadLine();
                    }
                    else if (line == Resources.ReportOptionsTitle)
                    {
                        reader.ReadLine();

                        regexOptions = (RegexOptions)Enum.Parse(typeof(RegexOptions), reader.ReadLine());
                    }
                    else if (line == Resources.ReportTextTitle)
                    {
                        reader.ReadLine();

                        StringBuilder sb = new StringBuilder();

                        line = reader.ReadLine();

                        while (line != null)
                        {
                            sb.AppendLine(line);

                            line = reader.ReadLine();
                        }

                        sb.Replace(Environment.NewLine, String.Empty, sb.Length - 2, Environment.NewLine.Length);

                        contents = sb.ToString();
                    }

                    line = reader.ReadLine();
                }
            }

            e.Result = new Object[2] { new RegexInput(contents, regexPattern, String.Empty, regexOptions), fileName };

            FormHelper.ProgressFormInstance.MainBackgroundWorker.ReportProgress(100);
        }

        internal static void ImportBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            FormHelper.ProgressFormInstance.SetProgressText(String.Format(Resources.DoImportBackgroundWorkProgressTextFormat, e.ProgressPercentage.ToString()));
        }

        internal static void ImportBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork -= ImportBackgroundWorker_DoWork;
            FormHelper.ProgressFormInstance.MainBackgroundWorker.ProgressChanged -= ImportBackgroundWorker_ProgressChanged;
            FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted -= ImportBackgroundWorker_RunWorkerCompleted;

            Object[] resultArray = e.Result as Object[];

            if (resultArray != null)
            {
                RegexInput input = resultArray[0] as RegexInput;

                String fileName = resultArray[1].ToString();

                if (!String.IsNullOrEmpty(input.RegexPattern))
                {
                    FormHelper.MainFormInstance.SetRegexInput(Path.GetFileNameWithoutExtension(fileName), input.RegexPattern, String.Empty, input.Contents, input.Options);
                }
            }

            FormHelper.ProgressFormInstance.Close();
        }

        #endregion

        #region Export

        internal static void ExportBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            String fileName = e.Argument.ToString();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Application.ProductName);
            sb.AppendLine(String.Format(Resources.ReportVersionStringFormat, Application.ProductVersion));
            sb.AppendLine(Application.CompanyName);
            sb.AppendLine();

            FormHelper.ProgressFormInstance.MainBackgroundWorker.ReportProgress(10);

            sb.AppendLine(String.Format(Resources.ReportMatchTimeStringFormat, DataHelper.Status.DateTimeStamp.ToString("yyyy/MM/dd HH:mm:ss")));
            sb.AppendLine(String.Format(Resources.ReportBuiltTimeStringFormat, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")));
            sb.AppendLine(String.Format(Resources.ReportTickTextFormat, DataHelper.Status.Tick.ToString("F"), DataHelper.Status.TickInNanoSeconds.ToString("F")));
            sb.AppendLine();

            FormHelper.ProgressFormInstance.MainBackgroundWorker.ReportProgress(20);

            sb.AppendLine(Resources.DefaultSeparator);
            sb.AppendLine(Resources.ReportPatternTitle);
            sb.AppendLine(Resources.DefaultSeparator);
            sb.AppendLine(DataHelper.Status.Input.RegexPattern);
            sb.AppendLine();

            FormHelper.ProgressFormInstance.MainBackgroundWorker.ReportProgress(30);

            sb.AppendLine(Resources.DefaultSeparator);
            sb.AppendLine(Resources.ReportOptionsTitle);
            sb.AppendLine(Resources.DefaultSeparator);
            sb.AppendLine(DataHelper.Status.Input.Options.ToString());
            sb.AppendLine();

            FormHelper.ProgressFormInstance.MainBackgroundWorker.ReportProgress(40);

            sb.AppendLine(Resources.DefaultSeparator);
            sb.AppendLine(String.Format(Resources.ReportResultTitleFormat, FormHelper.ResultFormInstance.ResultNodes.Count.ToString()));
            sb.AppendLine(Resources.DefaultSeparator);

            if (FormHelper.ResultFormInstance.ResultNodes.Count == 0)
            {
                sb.AppendLine(Resources.ReportNoResultText);
                sb.AppendLine();
            }
            else
            {
                foreach (TreeNode matchNode in FormHelper.ResultFormInstance.ResultNodes)
                {
                    sb.AppendLine(String.Format(Resources.ResultNodeTextFormat, ResultForm.GetNodeValue(matchNode), ResultForm.GetNodeValueIndex(matchNode).ToString()));

                    foreach (TreeNode groupNode in matchNode.Nodes)
                    {
                        sb.Append("\t");
                        sb.AppendLine(String.Format(Resources.ResultNodeTextFormat, ResultForm.GetNodeValue(groupNode), ResultForm.GetNodeValueIndex(groupNode).ToString()));

                        foreach (TreeNode captureNode in groupNode.Nodes)
                        {
                            sb.Append("\t\t");
                            sb.AppendLine(String.Format(Resources.ResultNodeTextFormat, ResultForm.GetNodeValue(captureNode), ResultForm.GetNodeValueIndex(captureNode).ToString()));
                        }
                    }

                    sb.AppendLine();
                }
            }

            FormHelper.ProgressFormInstance.MainBackgroundWorker.ReportProgress(60);

            sb.AppendLine(Resources.DefaultSeparator);
            sb.AppendLine(Resources.ReportTextTitle);
            sb.AppendLine(Resources.DefaultSeparator);

            sb.AppendLine(DataHelper.Status.Input.Contents);

            FormHelper.ProgressFormInstance.MainBackgroundWorker.ReportProgress(80);

            File.WriteAllText(fileName, sb.ToString(), Encoding.UTF8);

            FormHelper.ProgressFormInstance.MainBackgroundWorker.ReportProgress(100);
        }

        internal static void ExportBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            FormHelper.ProgressFormInstance.SetProgressText(String.Format(Resources.DoExportBackgroundWorkProgressTextFormat, e.ProgressPercentage.ToString()));
        }

        internal static void ExportBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormHelper.ProgressFormInstance.MainBackgroundWorker.DoWork -= ExportBackgroundWorker_DoWork;
            FormHelper.ProgressFormInstance.MainBackgroundWorker.ProgressChanged -= ExportBackgroundWorker_ProgressChanged;
            FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted -= ExportBackgroundWorker_RunWorkerCompleted;

            FormHelper.ProgressFormInstance.Close();
        }

        #endregion

        #region Clear

        internal static void NodeClearBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormHelper.ProgressFormInstance.MainBackgroundWorker.RunWorkerCompleted -= NodeClearBackgroundWorker_RunWorkerCompleted;

            FormHelper.ResultFormInstance.ClearNodes();

            FormHelper.ProgressFormInstance.Close();
        }

        #endregion
    }
}