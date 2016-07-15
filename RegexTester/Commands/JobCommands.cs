using System;
using System.Windows;

using Xlfdll.Windows.Presentation;

using RegexTester.Data;
using RegexTester.Helpers;

namespace RegexTester.Commands
{
    public static class JobCommands
    {
        static JobCommands()
        {
            JobCommands.NewCommand = new RelayCommand<Object>
            (
                delegate
                {
                    MessageBoxResult messageBoxResult = DialogHelper.ShowChangeMessageBox();

                    if (messageBoxResult != MessageBoxResult.Cancel)
                    {
                        ApplicationHelper.MainWindow.DataContext = new RegexState();
                    }
                }
            );

            JobCommands.OpenCommand = new RelayCommand<Object>
            (
                delegate
                {
                    MessageBoxResult messageBoxResult = DialogHelper.ShowChangeMessageBox();

                    if (messageBoxResult != MessageBoxResult.Cancel)
                    {
                        String path = DialogHelper.ShowOpenRegexJobFileDialog(JobCommands.OpenCommandName);

                        if (!String.IsNullOrEmpty(path))
                        {
                            JobHelper.LoadRegexJob(path);
                        }
                    }
                }
            );

            JobCommands.SaveCommand = new RelayCommand<Object>
            (
                delegate
                {
                    String path = !String.IsNullOrEmpty(RegexState.Current.InputFilePath) ?
                       RegexState.Current.InputFilePath : DialogHelper.ShowSaveRegexJobFileDialog(JobCommands.SaveCommandName);

                    if (!String.IsNullOrEmpty(path))
                    {
                        JobHelper.SaveRegexJob(path);
                    }
                }
            );

            JobCommands.SaveAsCommand = new RelayCommand<Object>
            (
                delegate
                {
                    String path = DialogHelper.ShowSaveRegexJobFileDialog(JobCommands.SaveAsCommandName);

                    if (!String.IsNullOrEmpty(path))
                    {
                        JobHelper.SaveRegexJob(path);
                    }
                }
            );
        }

        public static RelayCommand<Object> NewCommand { get; }
        public static RelayCommand<Object> OpenCommand { get; }
        public static RelayCommand<Object> SaveCommand { get; }
        public static RelayCommand<Object> SaveAsCommand { get; }

        public static readonly String OpenCommandName = "Open";
        public static readonly String SaveCommandName = "Save";
        public static readonly String SaveAsCommandName = "Save As";
    }
}