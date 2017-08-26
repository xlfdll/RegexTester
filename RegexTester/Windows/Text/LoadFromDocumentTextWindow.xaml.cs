using System;
using System.IO;
using System.Text;
using System.Windows;

using Microsoft.Win32;

using Xlfdll.Windows.Presentation.Dialogs;

using RegexTester.Data;

namespace RegexTester.Windows.Text
{
	/// <summary>
	/// LoadFromDocumentTextWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class LoadFromDocumentTextWindow : Window
	{
		public LoadFromDocumentTextWindow()
		{
			InitializeComponent();
		}

		private void LoadFromDocumentTextWindow_Loaded(object sender, RoutedEventArgs e)
		{
			EncodingComboBox.ItemsSource = Encoding.GetEncodings();
			EncodingComboBox.SelectedIndex = (EncodingComboBox.ItemsSource as EncodingInfo[]).Length - 1;
		}

		private void BrowseButton_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog()
			{
				Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*"
			};

			if (dlg.ShowDialog() == true)
			{
				FileNameTextBox.Text = dlg.FileName;
			}
		}

		private void LoadButton_Click(object sender, RoutedEventArgs e)
		{
			this.IsEnabled = false;

			try
			{
				AppState.Current.Input.Text = File.ReadAllText(FileNameTextBox.Text, (EncodingComboBox.SelectedItem as EncodingInfo).GetEncoding());

				this.Close();
			}
			catch (IOException ioEx)
			{
				ExceptionMessageBox.Show(this.Title, $"The following error occurred when loading the content from {FileNameTextBox.Text}:", ioEx);
			}
			catch (Exception ex)
			{
				ExceptionMessageBox.Show(this.Title, "The following error occurred:", ex);
			}
			finally
			{
				this.IsEnabled = true;
			}
		}
	}
}