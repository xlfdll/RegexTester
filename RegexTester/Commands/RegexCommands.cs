﻿using System;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;

using Xlfdll.Windows.Presentation;
using Xlfdll.Windows.Presentation.Dialogs;

using RegexTester.Data;
using RegexTester.Helpers;
using RegexTester.Windows;

namespace RegexTester.Commands
{
    public static class RegexCommands
    {
        static RegexCommands()
        {
            RegexCommands.MatchCommand = new RelayCommand<Object>
            (
                delegate
                {
                    TaskWindow taskWindow = new TaskWindow
                    (
                        delegate (Object argument)
                        {
                            return RegexHelper.Match(AppState.Current.Input);
                        },
                        null
                    )
                    {
                        Owner = App.MainWindow
                    };

                    taskWindow.ShowDialog();

                    if (taskWindow.Exception == null)
                    {
                        RegexResult regexResult = taskWindow.Result as RegexResult;

                        if (regexResult != null)
                        {
                            AppState.Current.Result = regexResult;

                            App.Settings.History.AddRecentRegexPattern(AppState.Current.Input.RegexPattern);
                        }
                        else
                        {
                            ExceptionMessageBox.Show(App.MainWindow, App.Metadata.AssemblyTitle, "An unknown error occurred in the process of Match operation.", new ApplicationException("TaskWindow.Result is null"));
                        }
                    }
                    else
                    {
                        ExceptionMessageBox.Show(App.MainWindow, App.Metadata.AssemblyTitle, "An error occurred in the process of Match operation.", taskWindow.Exception.InnerException);
                    }
                },
                delegate { return RegexCommands.CanRegexCommandExecute; }
            );

            RegexCommands.SplitCommand = new RelayCommand<Object>
            (
                delegate
                {
                    TaskWindow taskWindow = new TaskWindow
                    (
                        delegate (Object argument)
                        {
                            return RegexHelper.Split(AppState.Current.Input);
                        },
                        null
                    )
                    {
                        Owner = App.MainWindow
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

                            AppState.Current.Input.Text = sb.ToString();

                            App.Settings.History.AddRecentRegexPattern(AppState.Current.Input.RegexPattern);
                        }
                        else
                        {
                            ExceptionMessageBox.Show(App.MainWindow, App.Metadata.AssemblyTitle, "An unknown error occurred in the process of Split operation.", new ApplicationException("TaskWindow.Result is null"));
                        }
                    }
                    else
                    {
                        ExceptionMessageBox.Show(App.MainWindow, App.Metadata.AssemblyTitle, "An error occurred in the process of Split operation.", taskWindow.Exception.InnerException);
                    }
                },
                delegate { return RegexCommands.CanRegexCommandExecute; }
            );

            RegexCommands.ReplaceCommand = new RelayCommand<Object>
            (
                delegate
                {
                    TaskWindow taskWindow = new TaskWindow
                    (
                        delegate (Object argument)
                        {
                            return RegexHelper.Replace(AppState.Current.Input);
                        },
                        null
                    )
                    {
                        Owner = App.MainWindow
                    };

                    taskWindow.ShowDialog();

                    if (taskWindow.Exception == null)
                    {
                        String result = taskWindow.Result as String;

                        if (result != null)
                        {
                            AppState.Current.Input.Text = result;

                            App.Settings.History.AddRecentRegexPattern(AppState.Current.Input.RegexPattern);
                            App.Settings.History.AddRecentReplacePattern(AppState.Current.Input.ReplacePattern);
                        }
                        else
                        {
                            ExceptionMessageBox.Show(App.MainWindow, App.Metadata.AssemblyTitle, "An unknown error occurred in the process of Replace operation.", new ApplicationException("TaskWindow.Result is null"));
                        }
                    }
                    else
                    {
                        ExceptionMessageBox.Show(App.MainWindow, App.Metadata.AssemblyTitle, "An error occurred in the process of Replace operation.", taskWindow.Exception.InnerException);
                    }
                },
                delegate { return RegexCommands.CanRegexCommandExecute; }
            );

            RegexCommands.MeasureCommand = new RelayCommand<Object>
            (
                delegate
                {
                    TaskWindow taskWindow = new TaskWindow
                    (
                        delegate (Object argument)
                        {
                            return RegexHelper.Measure(AppState.Current.Input);
                        },
                        null
                    )
                    {
                        Owner = App.MainWindow
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
                            ExceptionMessageBox.Show(App.MainWindow, App.Metadata.AssemblyTitle, "An unknown error occurred in the process of Measure operation.", formatEx);
                        }
                    }
                    else
                    {
                        ExceptionMessageBox.Show(App.MainWindow, App.Metadata.AssemblyTitle, "An error occurred in the process of Measure operation.", taskWindow.Exception.InnerException);
                    }
                },
                delegate { return RegexCommands.CanRegexCommandExecute; }
            );

            RegexCommands.EditCommand = new RelayCommand<String>
            (
                delegate (String parameter)
                {
                    EditWindow editWindow = new EditWindow()
                    {
                        Owner = App.MainWindow
                    };

                    editWindow.PatternTextBox.SetBinding(TextBox.TextProperty,
                        new Binding(parameter) { UpdateSourceTrigger = UpdateSourceTrigger.Explicit });

                    editWindow.ShowDialog();
                }
            );
        }

        public static RelayCommand<Object> MatchCommand { get; }
        public static RelayCommand<Object> SplitCommand { get; }
        public static RelayCommand<Object> ReplaceCommand { get; }
        public static RelayCommand<Object> MeasureCommand { get; }
        public static RelayCommand<String> EditCommand { get; }

        private static Boolean CanRegexCommandExecute
            => AppState.Current != null && !String.IsNullOrEmpty(AppState.Current.Input.RegexPattern);
    }
}