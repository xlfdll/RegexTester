using System;
using System.Windows.Input;
using System.Windows.Media.Imaging;

using Xlfdll.Windows.Presentation.Dialogs;

using RegexTester.Helpers;

namespace RegexTester.Commands.Handlers
{
    public static class GeneralCommandHandlers
    {
        #region CanExecute Event Handlers

        public static void AlwaysEnabledCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        #endregion

        #region Executed Event Handlers

        public static void AboutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow
                (ApplicationHelper.MainWindow,
                ApplicationHelper.Metadata,
                new BitmapImage(new Uri("pack://application:,,,/Images/RegexTester.png")));

            aboutWindow.ShowDialog();
        }

        #endregion
    }
}