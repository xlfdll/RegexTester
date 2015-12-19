using System;
using System.Windows;
using System.Windows.Input;

using RegexTester.Data;
using RegexTester.Helpers;

namespace RegexTester.Commands.Handlers
{
    public static class JobCommandHandlers
    {
        #region Executed Event Handlers

        public static void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = DialogHelper.ShowChangeMessageBox();

            if (messageBoxResult != MessageBoxResult.Cancel)
            {
                ApplicationHelper.MainWindow.DataContext = new RegexStatus();
            }
        }

        public static void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = DialogHelper.ShowChangeMessageBox();

            if (messageBoxResult != MessageBoxResult.Cancel)
            {
                String path = DialogHelper.ShowOpenRegexJobFileDialog(JobCommands.OpenCommand.Name);

                if (!String.IsNullOrEmpty(path))
                {
                    JobHelper.LoadRegexJob(path);
                }
            }
        }

        public static void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            String path = !String.IsNullOrEmpty(RegexStatus.Current.InputFilePath) ?
                       RegexStatus.Current.InputFilePath : DialogHelper.ShowSaveRegexJobFileDialog(JobCommands.SaveCommand.Name);

            if (!String.IsNullOrEmpty(path))
            {
                JobHelper.SaveRegexJob(path);
            }
        }

        public static void SaveAsCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            String path = DialogHelper.ShowSaveRegexJobFileDialog(JobCommands.SaveAsCommand.Name);

            if (!String.IsNullOrEmpty(path))
            {
                JobHelper.SaveRegexJob(path);
            }
        }

        #endregion
    }
}