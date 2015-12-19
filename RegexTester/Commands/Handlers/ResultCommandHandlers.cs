using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using RegexTester.Data;

namespace RegexTester.Commands.Handlers
{
    public static class ResultCommandHandlers
    {
        #region CanExecute Event Handlers

        public static void CopyValueCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            TreeView treeView = e.Source as TreeView;

            if (treeView != null)
            {
                e.CanExecute = (treeView.SelectedItem != null);
            }
        }

        #endregion

        #region Executed Event Handlers

        public static void CopyValueCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TreeView treeView = e.Source as TreeView;

            if (treeView != null)
            {
                RegexMatch regexMatch = treeView.SelectedItem as RegexMatch;

                if (regexMatch != null)
                {
                    Clipboard.SetText(regexMatch.Value);
                }
            }
        }

        #endregion
    }
}