using System;

using Xlfdll.Windows.Presentation;
using Xlfdll.Windows.Presentation.Dialogs;

namespace RegexTester.Commands
{
    public static class GeneralCommands
    {
        static GeneralCommands()
        {
            GeneralCommands.AboutCommand = new RelayCommand<Object>
            (
                delegate
                {
                    AboutWindow aboutWindow = new AboutWindow
                    (App.MainWindow, App.Metadata,
                    new ApplicationPackUri("/Images/RegexTester.png"));

                    aboutWindow.ShowDialog();
                }
            );
        }

        public static RelayCommand<Object> AboutCommand { get; }
    }
}