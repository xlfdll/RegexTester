using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;

using RegexTester.Data;
using RegexTester.Helpers;

namespace RegexTester.Windows
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new RegexStatus();
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            MessageBoxResult messageBoxResult = DialogHelper.ShowChangeMessageBox();

            e.Cancel = (messageBoxResult == MessageBoxResult.Cancel);
        }

        // Use preview drag and drop events to override the default behaviors of the control

        private void MainWindow_PreviewDragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Copy;
                e.Handled = true; // Only stop handling after a file drop
            }
        }

        private void MainWindow_Drop(object sender, DragEventArgs e)
        {
            String[] files = e.Data.GetData(DataFormats.FileDrop) as String[];

            if (files != null && files.Length > 0)
            {
                MessageBoxResult messageBoxResult = DialogHelper.ShowChangeMessageBox();

                if (messageBoxResult != MessageBoxResult.Cancel)
                {
                    JobHelper.LoadRegexJob(files[0]);
                }
            }
        }

        private void PatternComboBox_DropDownOpened(object sender, EventArgs e)
        {
            ComboBox patternComboBox = sender as ComboBox;

            if (patternComboBox != null)
            {
                // Need to update binding collection view instead of ComboBox.ItemsSource itself
                ICollectionView collectionView = CollectionViewSource.GetDefaultView(patternComboBox.ItemsSource);
                collectionView.Refresh();
            }
        }

        private void ContentTextBox_PreviewDrop(object sender, DragEventArgs e)
        {
            String[] files = e.Data.GetData(DataFormats.FileDrop) as String[];

            if (files != null && files.Length > 0)
            {
                JobHelper.LoadTextDocument(files[0]);

                e.Handled = true; // Only stop handling after a file drop
            }
        }

        private void ContentTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = e.Source as TextBox;

            if (textBox != null)
            {
                ContentCaretIndexTextBlock.Text = textBox.CaretIndex.ToString();
                ContentLineIndexTextBlock.Text = (textBox.GetLineIndexFromCharacterIndex(textBox.CaretIndex) + 1).ToString();
                ContentLineCountTextBlock.Text = textBox.LineCount.ToString();
            }
        }

        private void ContentTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            RegexStatus.Current.Result = new RegexResult();
        }

        // GridSplitter is a Thumb control, hence DragStarted and DragCompleted events are available

        private void ResultGridSplitter_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            Settings.UI.ResultRowHeight = ResultRowDefinition.Height;
        }

        private void ResultExpander_Expanded(object sender, RoutedEventArgs e)
        {
            ResultRowDefinition.Height = Settings.UI.ResultRowHeight;
        }

        private void ResultExpander_Collapsed(object sender, RoutedEventArgs e)
        {
            ResultRowDefinition.Height = GridLength.Auto;
        }

        private void ResultTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<Object> e)
        {
            RegexMatch regexMatch = ResultTreeView.SelectedItem as RegexMatch;

            if (regexMatch != null)
            {
                // A fix to simulate TextBox.HideSelection in Windows Forms
                // Set FocusManager.IsFocusScope = true on TreeView
                // Then, the following Keyboard.Focus() statements can set logical focus on TextBox
                Keyboard.Focus(ContentTextBox);
                Keyboard.Focus(ResultTreeView);

                ContentTextBox.Select(regexMatch.Index, regexMatch.Value.Length);
            }
        }
    }
}