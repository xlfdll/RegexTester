using System.Windows;
using System.Windows.Controls;

using Xlfdll.Windows.Presentation;

using RegexTester.Data;

namespace RegexTester.Windows
{
    /// <summary>
    /// EditWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
        }

        private void EditWindow_Loaded(object sender, RoutedEventArgs e)
        {
            WindowFunctions.DisableMinimizeBox(this);

            PatternTextBox.DataContext = RegexStatus.Current.Input;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            PatternTextBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();

            this.Close();
        }
    }
}