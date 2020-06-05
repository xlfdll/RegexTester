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
                        App.MainWindow.DataContext = new AppState();
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
                        String path = DialogHelper.ShowOpenRegexJobFileDialog();

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
                    String path = !String.IsNullOrEmpty(AppState.Current.InputFilePath) ?
                       AppState.Current.InputFilePath : DialogHelper.ShowSaveRegexJobFileDialog();

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
                    String path = DialogHelper.ShowSaveRegexJobFileDialog();

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
    }
}