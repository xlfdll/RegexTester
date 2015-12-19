using System;

using Xlfdll.Windows.Presentation.Dialogs;

using RegexTester.Data;
using RegexTester.Windows;

namespace RegexTester.Helpers
{
    public static class JobHelper
    {
        public static void LoadRegexJob(String path)
        {
            TaskWindow taskWindow = new TaskWindow(TaskHelper.LoadJob, path)
            {
                Owner = ApplicationHelper.MainWindow
            };

            taskWindow.ShowDialog();

            if (taskWindow.Exception == null)
            {
                RegexInput regexInput = taskWindow.Result as RegexInput;

                if (regexInput != null)
                {
                    RegexStatus.Current.Input = regexInput;
                    RegexStatus.Current.Update(path);
                }
            }
            else
            {
                ExceptionMessageBox.Show(ApplicationHelper.Metadata.AssemblyTitle, "Invalid job file format.", taskWindow.Exception.InnerException);
            }
        }

        public static void SaveRegexJob(String path)
        {
            TaskWindow taskWindow = new TaskWindow(TaskHelper.SaveJob, path)
            {
                Owner = ApplicationHelper.MainWindow
            };

            taskWindow.ShowDialog();

            if (taskWindow.Exception == null)
            {
                RegexStatus.Current.Update(path);
            }
            else
            {
                ExceptionMessageBox.Show(ApplicationHelper.Metadata.AssemblyTitle, "Unexpected exception happened.", taskWindow.Exception.InnerException);
            }
        }

        public static void LoadTextDocument(String path)
        {
            TaskWindow taskWindow = new TaskWindow(TaskHelper.LoadText, path)
            {
                Owner = ApplicationHelper.MainWindow
            };

            taskWindow.ShowDialog();

            if (taskWindow.Exception == null)
            {
                String text = taskWindow.Result as String;

                if (text != null)
                {
                    RegexStatus.Current.Input.Text = text;
                }
            }
            else
            {
                ExceptionMessageBox.Show(ApplicationHelper.Metadata.AssemblyTitle, "Invalid job file format.", taskWindow.Exception.InnerException);
            }
        }
    }
}
