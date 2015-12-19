using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

using Xlfdll.Windows.Presentation.Dialogs;

using RegexTester.Data;
using RegexTester.Data.Configuration;
using RegexTester.Helpers;
using RegexTester.Windows;

namespace RegexTester.Commands.Handlers
{
    public static class RegexCommandHandlers
    {
        #region CanExecute Event Handlers

        public static void RegexCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !String.IsNullOrEmpty(RegexStatus.Current.Input.RegexPattern);
        }

        #endregion

        #region Executed Event Handlers

        public static void MatchCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TaskWindow taskWindow = new TaskWindow(TaskHelper.Match, null)
            {
                Owner = Application.Current.MainWindow
            };

            taskWindow.ShowDialog();

            if (taskWindow.Exception == null)
            {
                RegexResult regexResult = taskWindow.Result as RegexResult;

                if (regexResult != null)
                {
                    RegexStatus.Current.Result = regexResult;

                    ConfigurationData.History.AddRecentRegexPattern(RegexStatus.Current.Input.RegexPattern);
                }
                else
                {
                    ExceptionMessageBox.Show(ApplicationHelper.Metadata.AssemblyTitle, "An unknown error occurred in the process of Match operation.", new ApplicationException("TaskWindow.Result is null"));
                }
            }
            else
            {
                ExceptionMessageBox.Show(ApplicationHelper.Metadata.AssemblyTitle, "An error occurred in the process of Match operation.", taskWindow.Exception.InnerException);
            }
        }

        public static void SplitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TaskWindow taskWindow = new TaskWindow(TaskHelper.Split, null)
            {
                Owner = Application.Current.MainWindow
            };

            taskWindow.ShowDialog();

            if (taskWindow.Exception == null)
            {
                String[] results = taskWindow.Result as String[];

                if (results != null)
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (String item in results)
                    {
                        sb.AppendLine(item);
                    }

                    RegexStatus.Current.Input.Text = sb.ToString();

                    ConfigurationData.History.AddRecentRegexPattern(RegexStatus.Current.Input.RegexPattern);
                }
                else
                {
                    ExceptionMessageBox.Show(ApplicationHelper.Metadata.AssemblyTitle, "An unknown error occurred in the process of Split operation.", new ApplicationException("TaskWindow.Result is null"));
                }
            }
            else
            {
                ExceptionMessageBox.Show(ApplicationHelper.Metadata.AssemblyTitle, "An error occurred in the process of Split operation.", taskWindow.Exception.InnerException);
            }
        }

        public static void ReplaceCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TaskWindow taskWindow = new TaskWindow(TaskHelper.Replace, null)
            {
                Owner = Application.Current.MainWindow
            };

            taskWindow.ShowDialog();

            if (taskWindow.Exception == null)
            {
                String result = taskWindow.Result as String;

                if (result != null)
                {
                    RegexStatus.Current.Input.Text = result;

                    ConfigurationData.History.AddRecentRegexPattern(RegexStatus.Current.Input.RegexPattern);
                    ConfigurationData.History.AddRecentReplacePattern(RegexStatus.Current.Input.ReplacePattern);
                }
                else
                {
                    ExceptionMessageBox.Show(ApplicationHelper.Metadata.AssemblyTitle, "An unknown error occurred in the process of Replace operation.", new ApplicationException("TaskWindow.Result is null"));
                }
            }
            else
            {
                ExceptionMessageBox.Show(ApplicationHelper.Metadata.AssemblyTitle, "An error occurred in the process of Replace operation.", taskWindow.Exception.InnerException);
            }
        }

        public static void MeasureCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TaskWindow taskWindow = new TaskWindow(TaskHelper.Measure, null)
            {
                Owner = Application.Current.MainWindow
            };

            taskWindow.ShowDialog();

            if (taskWindow.Exception == null)
            {
                // Defensive code, since Int64 variable cannot be null

                try
                {
                    DialogHelper.ShowMeasureResultMessageBox(Convert.ToInt64(taskWindow.Result));
                }
                catch (FormatException formatEx)
                {
                    ExceptionMessageBox.Show(ApplicationHelper.Metadata.AssemblyTitle, "An unknown error occurred in the process of Measure operation.", formatEx);
                }
            }
            else
            {
                ExceptionMessageBox.Show(ApplicationHelper.Metadata.AssemblyTitle, "An error occurred in the process of Measure operation.", taskWindow.Exception.InnerException);
            }
        }

        public static void EditCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow()
            {
                Owner = Application.Current.MainWindow
            };

            editWindow.PatternTextBox.SetBinding(TextBox.TextProperty,
                new Binding(e.Parameter.ToString()) { UpdateSourceTrigger = UpdateSourceTrigger.Explicit });

            editWindow.ShowDialog();
        }

        #endregion
    }
}