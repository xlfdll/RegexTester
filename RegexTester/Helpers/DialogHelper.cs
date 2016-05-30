using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;

using Microsoft.Win32;

using RegexTester.Data;
using RegexTester.Commands;

namespace RegexTester.Helpers
{
    public static class DialogHelper
    {
        public static String ShowOpenRegexJobFileDialog(String commandName)
        {
            String path = String.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Regex Job (*.xml)|*.xml|All Files(*.*)|*.*",
                RestoreDirectory = true,
                Title = commandName
            };

            if (openFileDialog.ShowDialog(ApplicationHelper.MainWindow) == true)
            {
                path = openFileDialog.FileName;
            }

            return path;
        }

        public static String ShowSaveRegexJobFileDialog(String commandName)
        {
            String path = String.Empty;

            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Regex Job (*.xml)|*.xml|All Files(*.*)|*.*",
                RestoreDirectory = true,
                Title = commandName
            };

            if (saveFileDialog.ShowDialog(ApplicationHelper.MainWindow) == true)
            {
                path = saveFileDialog.FileName;
            }

            return path;
        }

        public static MessageBoxResult ShowChangeMessageBox()
        {
            MessageBoxResult messageBoxResult = MessageBoxResult.No;

            if (RegexStatus.Current.IsInputModified)
            {
                messageBoxResult = MessageBox.Show(ApplicationHelper.MainWindow, String.Format("Do you want to save current input changes to {0}?",
                    (!String.IsNullOrEmpty(RegexStatus.Current.InputFilePath) ? Path.GetFileName(RegexStatus.Current.InputFilePath) : "New Regex Job")),
                    ApplicationHelper.Metadata.AssemblyTitle, MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    String path = !String.IsNullOrEmpty(RegexStatus.Current.InputFilePath) ?
                        RegexStatus.Current.InputFilePath : DialogHelper.ShowSaveRegexJobFileDialog(JobCommands.SaveCommandName);

                    if (!String.IsNullOrEmpty(path))
                    {
                        JobHelper.SaveRegexJob(path);
                    }
                    else
                    {
                        messageBoxResult = MessageBoxResult.Cancel;
                    }
                }
            }

            return messageBoxResult;
        }

        public static void ShowMeasureResultMessageBox(Int64 elapsedTicks)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The amount of time for the regular expression pattern is");
            sb.AppendLine();
            sb.AppendLine(String.Format("{0} ticks ({1} ns)",
                elapsedTicks, ValueHelper.ConvertTicksToNanoseconds(elapsedTicks).ToString("F2")));
            sb.AppendLine();

            sb.AppendLine("Baseline Parameters:");
            sb.AppendLine(String.Format("Frequency: {0} ticks / sec ({1} ns / tick)",
                Stopwatch.Frequency.ToString(), (Math.Pow(10, 9) / Convert.ToDouble(Stopwatch.Frequency)).ToString("F2")));

            if (Stopwatch.IsHighResolution)
            {
                sb.AppendLine("Based on High-Resolution Performance Counter");
            }
            else
            {
                sb.AppendLine("Based on System Timer");
            }

            MessageBox.Show(ApplicationHelper.MainWindow, sb.ToString(), ApplicationHelper.Metadata.AssemblyTitle,
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}